namespace Shared

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

[<RequireQualifiedAccess>]
type RateLimited<'T> =
    | Response of 'T
    | RateLimitReached

type ToolApi = {
    getPulumiVersion : unit -> Async<string>
}