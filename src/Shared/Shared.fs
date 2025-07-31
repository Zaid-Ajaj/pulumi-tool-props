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
    author: string
    pulumiBotWorkflowFailures: Map<string, string>
}

type GithubCheckStep = {
    /// Identifies the date and time when the check step was started.
    startedAt: Option<System.DateTimeOffset>
    /// Identifies the date and time when the check step was completed.
    completedAt: Option<System.DateTimeOffset>
    /// The step's name.
    name: string
    /// The current status of the check step.
    status: string
    /// The conclusion of the check step.
    conclusion: string
    /// The index of the step in the list of steps of the parent check run.
    number: int
    content: string
}

type GithubCheckRun = {
    id: string
    name: string
    status: string
    conclusion: string
    steps : GithubCheckStep list
}

type GithubWorkflowDetails = {
    id: string
    status: string
    conclusion: string
    checkRuns: GithubCheckRun list
}

type DownloadWorkflowLogsInput = {
    workflowUrl: string
    /// the name of the run
    run: string
}

type ToolApi = {
    getPulumiVersion : unit -> Async<string>
    currentGithubUser : unit -> Async<Result<GithubUser, string>>
    triageIssues : unit -> Async<Result<GithubIssue list, string>>
    issueDetails : string -> Async<Result<DetailedGithubIssue, string>>
    workflowDetails : string -> Async<Result<GithubWorkflowDetails, string>>
    downloadWorkflowLogs : DownloadWorkflowLogsInput -> Async<Result<string, string>>
}