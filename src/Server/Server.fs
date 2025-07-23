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
        let graphqlClient = Github.GithubGraphqlClient httpClient
        return Ok graphqlClient
    | Error errorMessage ->
        return Error errorMessage
}

let currentGithubUser() = task {
    let! client = githubClient()
    match client with
    | Ok graphqlClient ->
        match! graphqlClient.CurrentUserAsync() with
        | Ok response ->
            let user = { login = response.viewer.login }
            return Ok user
        | Error errorMessage ->
            return Error $"Error while fetching current GitHub user: {errorMessage}"
    | Error errorMessage ->
        return Error $"Error while initializing GitHub client: {errorMessage}"
}

let toolApi = {
    getPulumiVersion = getPulumiVersion >> Async.AwaitTask
    currentGithubUser = currentGithubUser >> Async.AwaitTask
}

let docs = Remoting.documentation "Pulumi Tool!" [ ]

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