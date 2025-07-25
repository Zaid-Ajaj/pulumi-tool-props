namespace Shared

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type GithubUser = {
    login: string
}

type GithubIssue = {
    id: string
    title: string
    number: int
    url: string
    repository: string
    assignees: string list
    labels: string list
    createdAt: System.DateTime
    tier: int option
    author: string
}

type GithubComment = {
    bodyHTML: string
    author: string
    createdAt: System.DateTime
}

type DetailedGithubIssue = {
    id: string
    title: string
    url: string
    assignees: string list
    createdAt: System.DateTime
    body: string
    bodyHTML: string
    comments: GithubComment list
}

type ToolApi = {
    getPulumiVersion : unit -> Async<string>
    currentGithubUser : unit -> Async<Result<GithubUser, string>>
    triageIssues : unit -> Async<Result<GithubIssue list, string>>
    issueDetails : string -> Async<Result<DetailedGithubIssue, string>>
}