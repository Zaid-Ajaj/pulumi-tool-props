module Server

open System
open System.Collections.Generic
open System.Globalization
open System.IO
open System.IO.Compression
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
open System.Text
open OpenAI
open OpenAI.Chat

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
        let homeDir = Environment.GetFolderPath Environment.SpecialFolder.UserProfile
        let pulumiPath = Path.Combine(homeDir, ".pulumi-dev", "bin", "pulumi")
        if File.Exists pulumiPath then
            return pulumiPath
        elif File.Exists $"{pulumiPath}.exe" then
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
                                        content = ""
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


let logsUrlFromWorkflowUrl (workflowUrl: string) =
    let parts =
        workflowUrl.Split '/'
        |> Array.filter (fun part -> not (String.IsNullOrWhiteSpace part))
    match parts with
    | [| _; _; owner; repo; "actions"; "runs"; runId |] ->
        Some $"https://api.github.com/repos/%s{owner}/%s{repo}/actions/runs/%s{runId}/logs"
    | _ ->
        None

let splitLogFileContents (content: string) (run: GithubCheckRun) =
    let lines = content.Split '\n'
    let stepsByName = Dictionary<string, StringBuilder>()
    for step in run.steps do
        stepsByName[step.name] <- StringBuilder()

    for line in lines do
        let timestamp, rest =
            if line.Length >= 28 then
                DateTimeOffset.Parse(line.Substring(0, 27), CultureInfo.InvariantCulture), line.Substring(28).Trim()
            else
                DateTimeOffset.MinValue, line.Trim()

        for step in run.steps do
            match step.startedAt, step.completedAt with
            | Some startedAt, Some completedAt ->
                let start = startedAt.DateTime
                let finish = completedAt.DateTime
                if timestamp.DateTime >= start && timestamp.DateTime <= finish then
                    let stepName = step.name
                    if stepsByName.ContainsKey stepName then
                        stepsByName[stepName].AppendLine rest |> ignore
            | _ -> ()

    let steps =
        run.steps
        |> List.map (fun step ->
            let stepName = step.name
            let content =
                if stepsByName.ContainsKey stepName then
                    stepsByName[stepName].ToString().Trim()
                else
                    ""
            { step with content = content })

    { run with steps = steps }

let openAiClient() =
    let apiKey = Environment.GetEnvironmentVariable "OPENAI_API_KEY"
    if String.IsNullOrWhiteSpace apiKey then
        Error "Environment variable OPENAI_API_KEY is not set which is required for AI features"
    else
        let client = OpenAIClient apiKey
        Ok (client.GetChatClient "gpt-4o")

let analyzeWorkflowLogs (input: AnalyzeWorkflowLogsInput) = task {
    match openAiClient() with
    | Error errorMessage ->
        return Error errorMessage
    | Ok chatClient ->
        let systemMessage = """
        You are an AI assistant that analyzes GitHub Actions workflow run logs for Pulumi. 
        Your task is to identify errors, warnings, and issues in the logs and provide a summary
        of findings, emphasizing the most critical points and focus on the following:
        - Errors and warnings in the logs
        - Any failed tests and their error details
        """
        
        let steps = 
            input.run.steps
            |> List.map (fun step ->
                $"- {step.name} (status: {step.status}, conclusion: {step.conclusion}):")
            |> String.concat "\n"

        let stepsMessage = $"""
        The workflow run has the following steps:
        {steps}
        """

        let userMessage = $"""
        Here are the logs for the workflow run:
        {input.content}
        """

        let messages = ResizeArray<ChatMessage> [
            SystemChatMessage systemMessage :> ChatMessage
            SystemChatMessage stepsMessage :> ChatMessage
            UserChatMessage userMessage :> ChatMessage
        ]

        let options = ChatCompletionOptions(Temperature=0.0f)

        try
            let! response = chatClient.CompleteChatAsync(messages, options)
            if response.Value.Content.Count > 0 then
                return Ok response.Value.Content[0].Text
            else
                return Error "No relevant information found in workflow logs"
        with
        | ex ->
            return Error $"Failed to analyze workflow logs using OpenAI API: {ex.Message}"

}

let cleanTimestamps (logContent: string) : string = 
    let builder = StringBuilder()
    for line in logContent.Split '\n' do
        if line.Length >= 28 then
            let rest = line.Substring(28).Trim()
            builder.AppendLine rest |> ignore
        else
            builder.AppendLine line |> ignore
    builder.ToString().Trim()

let downloadWorkflowLogs (input: DownloadWorkflowLogsInput) = task {
    match! acquireGithubToken() with
    | Error errorMessage ->
        return Error $"failed to acquire GitHub token: {errorMessage}"
    | Ok token ->
        let client = new HttpClient()
        client.DefaultRequestHeaders.UserAgent.Add(ProductInfoHeaderValue("PulumiTool", "0.1.0"))
        client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue("application/vnd.github.v4+json"))
        client.DefaultRequestHeaders.Authorization <- new AuthenticationHeaderValue("Bearer", token)
        match logsUrlFromWorkflowUrl input.workflowUrl with
        | None -> return Error "Invalid workflow URL format"
        | Some logsUrl ->
            let! response = client.GetAsync logsUrl
            match response.StatusCode with
            | HttpStatusCode.OK ->
                let! zipFileStream = response.Content.ReadAsStreamAsync()
                use archive = new ZipArchive(zipFileStream, ZipArchiveMode.Read)
                let logFile =
                    archive.Entries
                    |> Seq.tryFind (fun entry ->
                        let entryName = entry.Name.Replace("/", "_").Replace("-", "_")
                        entryName.Contains (input.run.Replace("/", "_").Replace("-", "_")))

                match logFile with
                | Some entry ->
                    use entryStream = entry.Open()
                    use reader = new StreamReader(entryStream)
                    let! content = reader.ReadToEndAsync()
                    let cleanedContent = cleanTimestamps content
                    return Ok cleanedContent
                | None ->
                    return Error "log file was not found in the log archive of the workflow run"
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

let parseWorkflowUrls (issueBody: string) : Map<string, string> =
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

let toolApi = {
    getPulumiVersion = getPulumiVersion >> Async.AwaitTask
    currentGithubUser = currentGithubUser >> Async.AwaitTask
    triageIssues = triageIssues >> Async.AwaitTask
    issueDetails = issueDetails >> Async.AwaitTask
    workflowDetails = workflowDetails >> Async.AwaitTask
    downloadWorkflowLogs = downloadWorkflowLogs >> Async.AwaitTask
    analyzeWorkflowLogs = analyzeWorkflowLogs >> Async.AwaitTask
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