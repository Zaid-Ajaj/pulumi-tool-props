[<RequireQualifiedAccess>]
module rec Github.SearchIssues

type InputVariables =
    { query: string
      afterCurser: Option<string> }

/// Information to aid in pagination.
type PageInfo =
    {
        /// When paginating forwards, are there more items?
        hasNextPage: bool
        /// When paginating forwards, the cursor to continue.
        endCursor: Option<string>
    }

/// A list of nodes.
type User =
    {
        /// The username used to login.
        login: string
    }

/// A list of Users assigned to this object.
type UserConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<User>>>
    }

/// The repository associated with this node.
type Repository =
    {
        /// The name of the repository.
        name: string
    }

/// The actor who authored the comment.
type Actor =
    {
        /// The username of the actor.
        login: string
    }

/// A list of nodes.
type Label =
    {
        /// Identifies the label name.
        name: string
    }

/// A list of labels associated with the object.
type LabelConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<Label>>>
    }

/// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
type Issue =
    {
        ///The name of the type
        __typename: string
        /// The Node ID of the Issue object
        id: string
        /// Identifies the issue title.
        title: string
        /// A list of Users assigned to this object.
        assignees: UserConnection
        /// Identifies the issue number.
        number: int
        /// The repository associated with this node.
        repository: Repository
        /// The HTTP URL for this issue
        url: string
        /// Identifies the date and time when the object was created.
        createdAt: System.DateTime
        /// The actor who authored the comment.
        author: Option<Actor>
        /// A list of labels associated with the object.
        labels: Option<LabelConnection>
    }

/// Perform a search across resources, returning a maximum of 1,000 results.
[<RequireQualifiedAccess>]
type SearchResultItem = Issue of issue: Issue

/// Perform a search across resources, returning a maximum of 1,000 results.
type SearchResultItemConnection =
    {
        /// The total number of issues that matched the search query. Regardless of the total number of matches, a maximum of 1,000 results will be available across all types.
        issueCount: int
        /// Information to aid in pagination.
        pageInfo: PageInfo
        /// A list of nodes.
        nodes: Option<list<Option<SearchResultItem>>>
    }

/// The query root of GitHub's GraphQL interface.
type Query =
    {
        /// Perform a search across resources, returning a maximum of 1,000 results.
        search: SearchResultItemConnection
    }
