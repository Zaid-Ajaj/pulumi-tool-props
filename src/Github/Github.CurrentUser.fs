[<RequireQualifiedAccess>]
module rec Github.CurrentUser

/// The currently authenticated user.
type User =
    {
        /// The username used to login.
        login: string
    }

/// The query root of GitHub's GraphQL interface.
type Query =
    {
        /// The currently authenticated user.
        viewer: User
    }
