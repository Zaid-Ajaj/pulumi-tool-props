namespace Shared

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type GithubUser = {
    login: string
}


type ToolApi = {
    getPulumiVersion : unit -> Async<string>
    currentGithubUser : unit -> Async<Result<GithubUser, string>>
}