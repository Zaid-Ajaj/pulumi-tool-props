module Server

open System
open System.Collections.Generic
open System.IO
open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open Newtonsoft.Json
open Saturn
open CliWrap
open CliWrap.Buffered
open Newtonsoft.Json.Linq
open Shared
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open System.Net.Http
open System.Net.Http.Headers
open Markdig.Syntax
open Markdig.Syntax.Inlines
open Github
open System.Net

let capitalize (input: string) =
    match input with
    | null -> ""
    | "" -> ""
    | _ -> input.[0].ToString().ToUpper() + input.Substring(1)

let notEmpty (input: string) = not (String.IsNullOrWhiteSpace input)

let getJObject (key: string) (json: JObject) =
    if json.ContainsKey key && json[key].Type = JTokenType.Object then
        json[key] :?> JObject
    else
        JObject()

let isValidJson (json: string) =
    try
        let _ = JObject.Parse json
        true
    with
    | _ -> false

let pulumiCliBinary() : Task<string> = task {
    try
        // try to get the version of pulumi installed on the system
        let! pulumiVersionResult =
            Cli.Wrap("pulumi")
                .WithArguments("version")
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync()

        let version = pulumiVersionResult.StandardOutput.Trim()
        let versionRegex = Text.RegularExpressions.Regex("v[0-9]+\\.[0-9]+\\.[0-9]+")
        if versionRegex.IsMatch version then
            return "pulumi"
        else
            return! failwith "Pulumi not installed"
    with
    | error ->
        // when pulumi is not installed, try to get the version of of the dev build
        // installed on the system using `make install` in the pulumi repo
        let homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        let pulumiPath = System.IO.Path.Combine(homeDir, ".pulumi-dev", "bin", "pulumi")
        if System.IO.File.Exists pulumiPath then
            return pulumiPath
        elif System.IO.File.Exists $"{pulumiPath}.exe" then
            return $"{pulumiPath}.exe"
        else
            return "pulumi"
}

let getPulumiVersion() = task {
    let! binary = pulumiCliBinary()
    let! output = Cli.Wrap(binary).WithArguments("version").ExecuteBufferedAsync()
    return output.StandardOutput
}

let acquireGithubToken() = task {
    let tokenFromEnv = Environment.GetEnvironmentVariable "GITHUB_TOKEN"
    if notEmpty tokenFromEnv then
        return Ok tokenFromEnv
    else
        try
            let! tokenFromCli =
                Cli.Wrap("gh")
                    .WithArguments("auth token")
                    .WithValidation(CommandResultValidation.None)
                    .ExecuteBufferedAsync()

            return Ok (tokenFromCli.StandardOutput.Trim())
        with
        | error ->
            return Error $"Error while obtaining GitHub token. Either GITHUB_TOKEN environment variable was not set or 'gh auth login' has failed: {error.Message}"
}

let httpClient = new HttpClient(BaseAddress = Uri "https://api.github.com/graphql")
httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("PulumiTool", "0.1.0"))

let githubClient() = task {
    let! tokenResult = acquireGithubToken()
    match tokenResult with
    | Ok token ->
        httpClient.DefaultRequestHeaders.Authorization <- new AuthenticationHeaderValue("Bearer", token)
        let graphqlClient = GithubGraphqlClient httpClient
        return Ok graphqlClient
    | Error errorMessage ->
        return Error errorMessage
}

let logsUrlFromWorkflowUrl (workflowUrl: string) =
    let parts =
        workflowUrl.Split '/'
        |> Array.filter (fun part -> not (String.IsNullOrWhiteSpace part))
    match parts with
    | [| _; _; owner; repo; "actions"; "runs"; runId |] ->
        Some $"https://api.github.com/repos/%s{owner}/%s{repo}/actions/runs/%s{runId}/logs"
    | _ ->
        None

let downloadWorkflowLogs (workflowUrl: string) = task {
    match! acquireGithubToken() with
    | Error errorMessage ->
        return Error $"failed to acquire GitHub token: {errorMessage}"
    | Ok token ->
        let client = new HttpClient()
        client.DefaultRequestHeaders.UserAgent.Add(ProductInfoHeaderValue("PulumiTool", "0.1.0"))
        client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue("application/vnd.github.v4+json"))
        client.DefaultRequestHeaders.Authorization <- new AuthenticationHeaderValue("Bearer", token)
        match logsUrlFromWorkflowUrl workflowUrl with
        | None -> return Error "Invalid workflow URL format"
        | Some logsUrl ->
            let! response = client.GetAsync logsUrl
            match response.StatusCode with
            | HttpStatusCode.OK ->
                let! zipFileStream = response.Content.ReadAsStreamAsync()
                use archive = new Compression.ZipArchive(zipFileStream, Compression.ZipArchiveMode.Read)
                let entries =  Seq.toList archive.Entries
                return Ok entries
            | _ ->
                return Error $"Failed to download workflow logs: {response.ReasonPhrase}"
}

let currentGithubUser() = task {
    let! client = githubClient()
    match client with
    | Ok graphqlClient ->
        match! graphqlClient.CurrentUserAsync() with
        | Ok response ->
            let user = { login = response.viewer.login }
            return Ok user
        | Error errorMessages ->
            let messages = errorMessages |> List.map (fun e -> e.message) |> String.concat "; "
            return Error $"Error(s) while fetching current GitHub user: {messages}"
    | Error errorMessage ->
        return Error $"Error while initializing GitHub client: {errorMessage}"
}

let tierByRepo = function
| "pulumi-aws"
| "pulumi-azure"
| "pulumi-gcp"
| "pulumi-kubernetes" -> Some 1
| "pulumi-aws-native"
| "pulumi-azure-native"
| "pulumi-awsx"
| "pulumi-terraform-provider"
| "pulumi-eks" -> Some 2
| _ -> None

let excludedRepos = [
    "marketing"
    "salesforce"
    "business-development"
    "home"
    "ci-mgmt"
    "customer-support"
    "pulumi-service"
    "pulumi-hugo-private"
    "pulumi-internal"
    "customer-engineering"
    "programhunt"
]

let allTriageIssues (client: Github.GithubGraphqlClient) =
    let query = "label:\"needs-triage\" is:issue state:open org:pulumi"
    let mutable afterCurser = None
    let mutable search = true
    let triageIssues = ResizeArray<GithubIssue> [ ]
    let errors = ResizeArray<Github.ErrorType> [ ]
    while search do
        let response = client.SearchIssues { query = query; afterCurser = afterCurser }
        match response with
        | Error errorMessages ->
            errors.AddRange errorMessages
        | Ok response ->
            let issues =
                response.search.nodes
                |> Option.defaultValue []
                |> List.choose id
                |> List.filter (function
                    | Github.SearchIssues.SearchResultItem.Issue issue ->
                        not (excludedRepos |> List.contains issue.repository.name))
                |> List.map (function
                    | Github.SearchIssues.SearchResultItem.Issue issue ->
                        {
                            id = issue.id
                            title = issue.title
                            number = issue.number
                            url = issue.url
                            repository = issue.repository.name
                            createdAt = issue.createdAt
                            tier = tierByRepo issue.repository.name
                            author =
                                issue.author
                                |> Option.map (fun a -> a.login)
                                |> Option.defaultValue ""
                            labels =
                                issue.labels
                                |> Option.map (fun labels -> labels.nodes |> Option.defaultValue [] |> List.choose (fun l -> l |> Option.map (fun label -> label.name)))
                                |> Option.defaultValue []
                            assignees =
                                issue.assignees.nodes
                                |> Option.defaultValue []
                                |> List.choose (fun a -> a |> Option.map (fun assignee -> assignee.login))
                        })

            triageIssues.AddRange issues
            afterCurser <- response.search.pageInfo.endCursor
            search <- response.search.pageInfo.hasNextPage

    if errors.Count > 0 then
        Error (List.ofSeq errors)
    else
        Ok (List.ofSeq triageIssues)

let triageIssues() = task {
    let! client = githubClient()
    match client with
    | Error errorMessage ->
        return Error $"Error while initializing GitHub client: {errorMessage}"
    | Ok graphqlClient ->
        match allTriageIssues graphqlClient with
        | Error errorMessages ->
            let messages = errorMessages |> List.map (fun e -> e.message) |> String.concat ";"
            return Error $"Error(s) while fetching triage issues: {messages}"
        | Ok issues ->
            let sorted =
                issues
                |> List.groupBy (fun issue -> issue.repository)
                |> List.sortBy (fun (repo, _) -> tierByRepo repo |> Option.defaultValue 99)
                |> List.map (fun (repo, issues) ->
                    let sortedIssues =
                        issues
                        |> List.sortByDescending (fun issue -> issue.createdAt)
                    repo, sortedIssues)
                |> List.collect (fun (repo, items) -> items)

            return Ok sorted
}

let parseWorkflowUrls (issueBody: string) =
    let ast = Markdig.Markdown.Parse(issueBody, Markdig.MarkdownPipelineBuilder().Build())
    Map.ofList [
        for node in ast.Descendants<LinkInline>() do
            if node.Url.Contains "/actions/runs" then
                for literal in Seq.truncate 1 (node.Descendants<LiteralInline>()) do
                    yield literal.Content.ToString(), node.Url
    ]

let issueDetails (issueId: string) = task {
    let! client = githubClient()
    match client with
    | Error errorMessage ->
        return Error $"Error while initializing GitHub client: {errorMessage}"
    | Ok graphqlClient ->
        match! graphqlClient.IssueDetailsAsync { id = issueId } with
        | Ok response ->
            match response.node with
            | None ->
                return Error $"Issue with ID {issueId} not found"
            | Some (Github.IssueDetails.Node.Issue issue) ->
                let comments =
                    issue.comments.nodes
                    |> Option.defaultValue []
                    |> List.choose id
                    |> List.map (fun comment ->
                        {
                            bodyHTML = comment.bodyHTML
                            createdAt = comment.createdAt
                            author =
                                comment.author
                                |> Option.map (fun a -> a.login)
                                |> Option.defaultValue ""
                        })

                let author =
                    issue.author
                    |> Option.map (fun a -> a.login)
                    |> Option.defaultValue ""

                let workflowUrls =
                    if author = "pulumi-bot" && issue.title.Contains "Workflow failure" then
                        parseWorkflowUrls issue.body
                    else
                        Map.empty

                let detailedIssue : DetailedGithubIssue = {
                    id = issue.id
                    title = issue.title
                    url = issue.url
                    author =
                        issue.author
                        |> Option.map (fun a -> a.login)
                        |> Option.defaultValue ""
                    assignees =
                        issue.assignees.nodes
                        |> Option.defaultValue []
                        |> List.choose (fun a -> a |> Option.map (fun assignee -> assignee.login))
                    createdAt = issue.createdAt
                    body = issue.body
                    bodyHTML = issue.bodyHTML
                    comments = comments
                    pulumiBotWorkflowFailures = workflowUrls
                }

                return Ok detailedIssue
            | Some _ ->
                return Error "Unexpected node type returned from GitHub API"
        | Error errorMessages ->
            let messages = errorMessages |> List.map (fun e -> e.message) |> String.concat "; "
            return Error $"Error(s) while fetching issue details: {messages}"
}

let workflowDetails (workflowUrl: string) = task {
    let! client = githubClient()
    match client with
    | Error errorMessage ->
        return Error $"Error while initializing GitHub client: {errorMessage}"
    | Ok graphqlClient ->
        match! graphqlClient.WorkflowByUrlAsync { url = workflowUrl } with
        | Ok response ->
            match response.resource with
            | None ->
                return Error $"Workflow run not found for URL {workflowUrl}"
            | Some (WorkflowByUrl.UniformResourceLocatable.WorkflowRun workflowRun) ->
                let checkRuns =
                    workflowRun.checkSuite.checkRuns
                    |> Option.bind (fun cr ->
                        cr.nodes
                        |> Option.map (List.choose id)
                    )
                    |> Option.defaultValue []
                    |> List.map (fun checkRun ->
                        {
                            id = checkRun.id
                            name = checkRun.name
                            status = checkRun.status.ToString()
                            conclusion =
                                checkRun.conclusion
                                |> Option.map (fun c -> c.ToString())
                                |> Option.defaultValue ""
                            steps =
                                checkRun.steps
                                |> Option.bind (fun steps ->
                                    steps.nodes
                                    |> Option.map (List.choose id)
                                )
                                |> Option.defaultValue []
                                |> List.map (fun step ->
                                    {
                                        startedAt = step.startedAt
                                        completedAt = step.completedAt
                                        name = step.name
                                        status = step.status.ToString()
                                        conclusion =
                                            step.conclusion
                                            |> Option.map (fun c -> c.ToString())
                                            |> Option.defaultValue ""
                                        number = step.number
                                    })
                        })

                let workflowDetails : GithubWorkflowDetails = {
                    id = workflowRun.id
                    status = workflowRun.checkSuite.status.ToString()
                    checkRuns = checkRuns
                    conclusion = workflowRun.checkSuite.conclusion
                        |> Option.map (fun c -> c.ToString())
                        |> Option.defaultValue ""
                }

                return Ok workflowDetails
            | Some _ ->
                return Error "Unexpected resource type returned from GitHub API"
        | Error errorMessages ->
            let messages = errorMessages |> List.map (fun e -> e.message) |> String.concat "; "
            return Error $"Error(s) while fetching workflow details: {messages}"
}

let toolApi = {
    getPulumiVersion = getPulumiVersion >> Async.AwaitTask
    currentGithubUser = currentGithubUser >> Async.AwaitTask
    triageIssues = triageIssues >> Async.AwaitTask
    issueDetails = issueDetails >> Async.AwaitTask
    workflowDetails = workflowDetails >> Async.AwaitTask
}

let docs = Remoting.documentation "Pulumi Tool" [ ]

let webApp =
    Remoting.createApi()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.withErrorHandler (fun error routeInfo ->
        printfn "%A" error
        Ignore
    )
    |> Remoting.fromValue toolApi
    |> Remoting.withDocs "/api/docs" docs
    |> Remoting.buildHttpHandler

let app = application {
    logging (fun config -> config.ClearProviders() |> ignore)
    use_router webApp
    memory_cache
    use_static AppContext.BaseDirectory
    use_gzip
}

[<EntryPoint>]
let main _ =
    printfn "Pulumi Tool started, navigate to http://localhost:5000"
    run app
    0