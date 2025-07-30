[<RequireQualifiedAccess>]
module rec Github.WorkflowByUrl

type InputVariables = { url: string }

/// A special type of user which takes actions on behalf of GitHub Apps.
type Bot =
    {
        ///The name of the type
        __typename: string
    }

/// A check run.
type CheckRun =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'closed' event on any `Closable`.
type ClosedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Git commit.
type Commit =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'convert_to_draft' event on a given pull request.
type ConvertToDraftEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a mention made by one issue or pull request to another.
type CrossReferencedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A Gist.
type Gist =
    {
        ///The name of the type
        __typename: string
    }

/// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
type Issue =
    {
        ///The name of the type
        __typename: string
    }

/// A placeholder user for attribution of imported data on GitHub.
type Mannequin =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'merged' event on a given pull request.
type MergedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Milestone object on a given repository.
type Milestone =
    {
        ///The name of the type
        __typename: string
    }

/// An account on GitHub, with one or more owners, that has repositories, members and teams.
type Organization =
    {
        ///The name of the type
        __typename: string
    }

/// A repository pull request.
type PullRequest =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Git commit part of a pull request.
type PullRequestCommit =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'ready_for_review' event on a given pull request.
type ReadyForReviewEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A release contains the content for a release.
type Release =
    {
        ///The name of the type
        __typename: string
    }

/// A repository contains the content for a project.
type Repository =
    {
        ///The name of the type
        __typename: string
    }

/// A repository-topic connects a repository to a topic.
type RepositoryTopic =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'review_dismissed' event on a given issue or pull request.
type ReviewDismissedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A team discussion.
type TeamDiscussion =
    {
        ///The name of the type
        __typename: string
    }

/// A comment on a team discussion.
type TeamDiscussionComment =
    {
        ///The name of the type
        __typename: string
    }

/// A user is an individual's account on GitHub that owns repositories and can make new content.
type User =
    {
        ///The name of the type
        __typename: string
    }

/// A workflow contains meta information about an Actions workflow file.
type Workflow =
    {
        ///The name of the type
        __typename: string
    }

/// An executed workflow file for a workflow run.
type WorkflowRunFile =
    {
        ///The name of the type
        __typename: string
    }

/// A list of nodes.
type CheckStep =
    {
        /// Identifies the date and time when the check step was started.
        startedAt: Option<System.DateTime>
        /// Identifies the date and time when the check step was completed.
        completedAt: Option<System.DateTime>
        /// The step's name.
        name: string
        /// The current status of the check step.
        status: CheckStatusState
        /// The conclusion of the check step.
        conclusion: Option<CheckConclusionState>
        /// The index of the step in the list of steps of the parent check run.
        number: int
    }

/// The check run's steps
type CheckStepConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<CheckStep>>>
    }

/// A list of nodes.
type Nodes =
    {
        /// The name of the check for this check run.
        name: string
        /// The conclusion of the check run.
        conclusion: Option<CheckConclusionState>
        /// The current status of the check run.
        status: CheckStatusState
        /// The URL from which to find full details of the check run on the integrator's site.
        detailsUrl: Option<string>
        /// The Node ID of the CheckRun object
        id: string
        /// The check run's steps
        steps: Option<CheckStepConnection>
    }

/// The check runs associated with a check suite.
type CheckRunConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<Nodes>>>
    }

/// The check suite this workflow run belongs to.
type CheckSuite =
    {
        /// The conclusion of this check suite.
        conclusion: Option<CheckConclusionState>
        /// The status of this check suite.
        status: CheckStatusState
        /// The check runs associated with a check suite.
        checkRuns: Option<CheckRunConnection>
    }

/// A workflow run.
type WorkflowRun =
    {
        ///The name of the type
        __typename: string
        /// The Node ID of the WorkflowRun object
        id: string
        /// The check suite this workflow run belongs to.
        checkSuite: CheckSuite
    }

/// The query root of GitHub's GraphQL interface.
[<RequireQualifiedAccess>]
type UniformResourceLocatable =
    | Bot of bot: Bot
    | CheckRun of checkrun: CheckRun
    | ClosedEvent of closedevent: ClosedEvent
    | Commit of commit: Commit
    | ConvertToDraftEvent of converttodraftevent: ConvertToDraftEvent
    | CrossReferencedEvent of crossreferencedevent: CrossReferencedEvent
    | Gist of gist: Gist
    | Issue of issue: Issue
    | Mannequin of mannequin: Mannequin
    | MergedEvent of mergedevent: MergedEvent
    | Milestone of milestone: Milestone
    | Organization of organization: Organization
    | PullRequest of pullrequest: PullRequest
    | PullRequestCommit of pullrequestcommit: PullRequestCommit
    | ReadyForReviewEvent of readyforreviewevent: ReadyForReviewEvent
    | Release of release: Release
    | Repository of repository: Repository
    | RepositoryTopic of repositorytopic: RepositoryTopic
    | ReviewDismissedEvent of reviewdismissedevent: ReviewDismissedEvent
    | TeamDiscussion of teamdiscussion: TeamDiscussion
    | TeamDiscussionComment of teamdiscussioncomment: TeamDiscussionComment
    | User of user: User
    | Workflow of workflow: Workflow
    | WorkflowRunFile of workflowrunfile: WorkflowRunFile
    | WorkflowRun of workflowrun: WorkflowRun

/// The query root of GitHub's GraphQL interface.
type Query =
    {
        /// Lookup resource by a URL.
        resource: Option<UniformResourceLocatable>
    }
