namespace rec Github

/// The actor's type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ActorType =
    /// Indicates a user actor.
    | [<CompiledName "USER">] User
    /// Indicates a team actor.
    | [<CompiledName "TEAM">] Team

/// Properties by which Audit Log connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AuditLogOrderField =
    /// Order audit log entries by timestamp
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Represents an annotation's information level.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckAnnotationLevel =
    /// An annotation indicating an inescapable error.
    | [<CompiledName "FAILURE">] Failure
    /// An annotation indicating some information.
    | [<CompiledName "NOTICE">] Notice
    /// An annotation indicating an ignorable error.
    | [<CompiledName "WARNING">] Warning

/// The possible states for a check suite or run conclusion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckConclusionState =
    /// The check suite or run requires action.
    | [<CompiledName "ACTION_REQUIRED">] ActionRequired
    /// The check suite or run has timed out.
    | [<CompiledName "TIMED_OUT">] TimedOut
    /// The check suite or run has been cancelled.
    | [<CompiledName "CANCELLED">] Cancelled
    /// The check suite or run has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The check suite or run has succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// The check suite or run was neutral.
    | [<CompiledName "NEUTRAL">] Neutral
    /// The check suite or run was skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// The check suite or run has failed at startup.
    | [<CompiledName "STARTUP_FAILURE">] StartupFailure
    /// The check suite or run was marked stale by GitHub. Only GitHub can use this conclusion.
    | [<CompiledName "STALE">] Stale

/// The possible states of a check run in a status rollup.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckRunState =
    /// The check run requires action.
    | [<CompiledName "ACTION_REQUIRED">] ActionRequired
    /// The check run has been cancelled.
    | [<CompiledName "CANCELLED">] Cancelled
    /// The check run has been completed.
    | [<CompiledName "COMPLETED">] Completed
    /// The check run has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The check run is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The check run was neutral.
    | [<CompiledName "NEUTRAL">] Neutral
    /// The check run is in pending state.
    | [<CompiledName "PENDING">] Pending
    /// The check run has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The check run was skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// The check run was marked stale by GitHub. Only GitHub can use this conclusion.
    | [<CompiledName "STALE">] Stale
    /// The check run has failed at startup.
    | [<CompiledName "STARTUP_FAILURE">] StartupFailure
    /// The check run has succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// The check run has timed out.
    | [<CompiledName "TIMED_OUT">] TimedOut
    /// The check run is in waiting state.
    | [<CompiledName "WAITING">] Waiting

/// The possible types of check runs.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckRunType =
    /// Every check run available.
    | [<CompiledName "ALL">] All
    /// The latest check run.
    | [<CompiledName "LATEST">] Latest

/// The possible states for a check suite or run status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CheckStatusState =
    /// The check suite or run has been requested.
    | [<CompiledName "REQUESTED">] Requested
    /// The check suite or run has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The check suite or run is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The check suite or run has been completed.
    | [<CompiledName "COMPLETED">] Completed
    /// The check suite or run is in waiting state.
    | [<CompiledName "WAITING">] Waiting
    /// The check suite or run is in pending state.
    | [<CompiledName "PENDING">] Pending

/// Collaborators affiliation level with a subject.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CollaboratorAffiliation =
    /// All outside collaborators of an organization-owned subject.
    | [<CompiledName "OUTSIDE">] Outside
    /// All collaborators with permissions to an organization-owned subject, regardless of organization membership status.
    | [<CompiledName "DIRECT">] Direct
    /// All collaborators the authenticated user can see.
    | [<CompiledName "ALL">] All

/// A comment author association with repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommentAuthorAssociation =
    /// Author is a member of the organization that owns the repository.
    | [<CompiledName "MEMBER">] Member
    /// Author is the owner of the repository.
    | [<CompiledName "OWNER">] Owner
    /// Author is a placeholder for an unclaimed user.
    | [<CompiledName "MANNEQUIN">] Mannequin
    /// Author has been invited to collaborate on the repository.
    | [<CompiledName "COLLABORATOR">] Collaborator
    /// Author has previously committed to the repository.
    | [<CompiledName "CONTRIBUTOR">] Contributor
    /// Author has not previously committed to the repository.
    | [<CompiledName "FIRST_TIME_CONTRIBUTOR">] FirstTimeContributor
    /// Author has not previously committed to GitHub.
    | [<CompiledName "FIRST_TIMER">] FirstTimer
    /// Author has no association with the repository.
    | [<CompiledName "NONE">] None

/// The possible errors that will prevent a user from updating a comment.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommentCannotUpdateReason =
    /// Unable to create comment because repository is archived.
    | [<CompiledName "ARCHIVED">] Archived
    /// You must be the author or have write access to this repository to update this comment.
    | [<CompiledName "INSUFFICIENT_ACCESS">] InsufficientAccess
    /// Unable to create comment because issue is locked.
    | [<CompiledName "LOCKED">] Locked
    /// You must be logged in to update this comment.
    | [<CompiledName "LOGIN_REQUIRED">] LoginRequired
    /// Repository is under maintenance.
    | [<CompiledName "MAINTENANCE">] Maintenance
    /// At least one email address must be verified to update this comment.
    | [<CompiledName "VERIFIED_EMAIL_REQUIRED">] VerifiedEmailRequired
    /// You cannot update this comment
    | [<CompiledName "DENIED">] Denied

/// Properties by which commit contribution connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommitContributionOrderField =
    /// Order commit contributions by when they were made.
    | [<CompiledName "OCCURRED_AT">] OccurredAt
    /// Order commit contributions by how many commits they represent.
    | [<CompiledName "COMMIT_COUNT">] CommitCount

/// The status of a git comparison between two refs.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComparisonStatus =
    /// The head ref is both ahead and behind of the base ref, indicating git history has diverged.
    | [<CompiledName "DIVERGED">] Diverged
    /// The head ref is ahead of the base ref.
    | [<CompiledName "AHEAD">] Ahead
    /// The head ref is behind the base ref.
    | [<CompiledName "BEHIND">] Behind
    /// The head ref and base ref are identical.
    | [<CompiledName "IDENTICAL">] Identical

/// Varying levels of contributions from none to many.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContributionLevel =
    /// No contributions occurred.
    | [<CompiledName "NONE">] None
    /// Lowest 25% of days of contributions.
    | [<CompiledName "FIRST_QUARTILE">] FirstQuartile
    /// Second lowest 25% of days of contributions. More contributions than the first quartile.
    | [<CompiledName "SECOND_QUARTILE">] SecondQuartile
    /// Second highest 25% of days of contributions. More contributions than second quartile, less than the fourth quartile.
    | [<CompiledName "THIRD_QUARTILE">] ThirdQuartile
    /// Highest 25% of days of contributions. More contributions than the third quartile.
    | [<CompiledName "FOURTH_QUARTILE">] FourthQuartile

/// The possible base permissions for repositories.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DefaultRepositoryPermissionField =
    /// No access
    | [<CompiledName "NONE">] None
    /// Can read repos by default
    | [<CompiledName "READ">] Read
    /// Can read and write repos by default
    | [<CompiledName "WRITE">] Write
    /// Can read, write, and administrate repos by default
    | [<CompiledName "ADMIN">] Admin

/// The possible ecosystems of a dependency graph package.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DependencyGraphEcosystem =
    /// Ruby gems hosted at RubyGems.org
    | [<CompiledName "RUBYGEMS">] Rubygems
    /// JavaScript packages hosted at npmjs.com
    | [<CompiledName "NPM">] Npm
    /// Python packages hosted at PyPI.org
    | [<CompiledName "PIP">] Pip
    /// Java artifacts hosted at the Maven central repository
    | [<CompiledName "MAVEN">] Maven
    /// .NET packages hosted at the NuGet Gallery
    | [<CompiledName "NUGET">] Nuget
    /// PHP packages hosted at packagist.org
    | [<CompiledName "COMPOSER">] Composer
    /// Go modules
    | [<CompiledName "GO">] Go
    /// GitHub Actions
    | [<CompiledName "ACTIONS">] Actions
    /// Rust crates
    | [<CompiledName "RUST">] Rust
    /// Dart packages hosted at pub.dev
    | [<CompiledName "PUB">] Pub
    /// Swift packages
    | [<CompiledName "SWIFT">] Swift

/// Properties by which deployment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentOrderField =
    /// Order collection by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible protection rule types.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentProtectionRuleType =
    /// Required reviewers
    | [<CompiledName "REQUIRED_REVIEWERS">] RequiredReviewers
    /// Wait timer
    | [<CompiledName "WAIT_TIMER">] WaitTimer
    /// Branch policy
    | [<CompiledName "BRANCH_POLICY">] BranchPolicy

/// The possible states for a deployment review.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentReviewState =
    /// The deployment was approved.
    | [<CompiledName "APPROVED">] Approved
    /// The deployment was rejected.
    | [<CompiledName "REJECTED">] Rejected

/// The possible states in which a deployment can be.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentState =
    /// The pending deployment was not updated after 30 minutes.
    | [<CompiledName "ABANDONED">] Abandoned
    /// The deployment is currently active.
    | [<CompiledName "ACTIVE">] Active
    /// An inactive transient deployment.
    | [<CompiledName "DESTROYED">] Destroyed
    /// The deployment experienced an error.
    | [<CompiledName "ERROR">] Error
    /// The deployment has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The deployment is inactive.
    | [<CompiledName "INACTIVE">] Inactive
    /// The deployment is pending.
    | [<CompiledName "PENDING">] Pending
    /// The deployment was successful.
    | [<CompiledName "SUCCESS">] Success
    /// The deployment has queued
    | [<CompiledName "QUEUED">] Queued
    /// The deployment is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The deployment is waiting.
    | [<CompiledName "WAITING">] Waiting

/// The possible states for a deployment status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentStatusState =
    /// The deployment is pending.
    | [<CompiledName "PENDING">] Pending
    /// The deployment was successful.
    | [<CompiledName "SUCCESS">] Success
    /// The deployment has failed.
    | [<CompiledName "FAILURE">] Failure
    /// The deployment is inactive.
    | [<CompiledName "INACTIVE">] Inactive
    /// The deployment experienced an error.
    | [<CompiledName "ERROR">] Error
    /// The deployment is queued
    | [<CompiledName "QUEUED">] Queued
    /// The deployment is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The deployment is waiting.
    | [<CompiledName "WAITING">] Waiting

/// The possible sides of a diff.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiffSide =
    /// The left side of the diff.
    | [<CompiledName "LEFT">] Left
    /// The right side of the diff.
    | [<CompiledName "RIGHT">] Right

/// The possible reasons for closing a discussion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiscussionCloseReason =
    /// The discussion has been resolved
    | [<CompiledName "RESOLVED">] Resolved
    /// The discussion is no longer relevant
    | [<CompiledName "OUTDATED">] Outdated
    /// The discussion is a duplicate of another
    | [<CompiledName "DUPLICATE">] Duplicate

/// Properties by which discussion connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiscussionOrderField =
    /// Order discussions by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order discussions by most recent modification time.
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// Properties by which discussion poll option connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiscussionPollOptionOrderField =
    /// Order poll options by the order that the poll author specified when creating the poll.
    | [<CompiledName "AUTHORED_ORDER">] AuthoredOrder
    /// Order poll options by the number of votes it has.
    | [<CompiledName "VOTE_COUNT">] VoteCount

/// The possible states of a discussion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiscussionState =
    /// A discussion that is open
    | [<CompiledName "OPEN">] Open
    /// A discussion that has been closed
    | [<CompiledName "CLOSED">] Closed

/// The possible state reasons of a discussion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiscussionStateReason =
    /// The discussion has been resolved
    | [<CompiledName "RESOLVED">] Resolved
    /// The discussion is no longer relevant
    | [<CompiledName "OUTDATED">] Outdated
    /// The discussion is a duplicate of another
    | [<CompiledName "DUPLICATE">] Duplicate
    /// The discussion was reopened
    | [<CompiledName "REOPENED">] Reopened

/// The possible reasons that a Dependabot alert was dismissed.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DismissReason =
    /// A fix has already been started
    | [<CompiledName "FIX_STARTED">] FixStarted
    /// No bandwidth to fix this
    | [<CompiledName "NO_BANDWIDTH">] NoBandwidth
    /// Risk is tolerable to this project
    | [<CompiledName "TOLERABLE_RISK">] TolerableRisk
    /// This alert is inaccurate or incorrect
    | [<CompiledName "INACCURATE">] Inaccurate
    /// Vulnerable code is not actually used
    | [<CompiledName "NOT_USED">] NotUsed

/// Properties by which enterprise administrator invitation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseAdministratorInvitationOrderField =
    /// Order enterprise administrator member invitations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible administrator roles in an enterprise account.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseAdministratorRole =
    /// Represents an owner of the enterprise account.
    | [<CompiledName "OWNER">] Owner
    /// Represents a billing manager of the enterprise account.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// Unaffiliated member of the enterprise account without an admin role.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated

/// The possible values for the enterprise allow private repository forking policy value.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseAllowPrivateRepositoryForkingPolicyValue =
    /// Members can fork a repository to an organization within this enterprise.
    | [<CompiledName "ENTERPRISE_ORGANIZATIONS">] EnterpriseOrganizations
    /// Members can fork a repository only within the same organization (intra-org).
    | [<CompiledName "SAME_ORGANIZATION">] SameOrganization
    /// Members can fork a repository to their user account or within the same organization.
    | [<CompiledName "SAME_ORGANIZATION_USER_ACCOUNTS">] SameOrganizationUserAccounts
    /// Members can fork a repository to their enterprise-managed user account or an organization inside this enterprise.
    | [<CompiledName "ENTERPRISE_ORGANIZATIONS_USER_ACCOUNTS">] EnterpriseOrganizationsUserAccounts
    /// Members can fork a repository to their user account.
    | [<CompiledName "USER_ACCOUNTS">] UserAccounts
    /// Members can fork a repository to their user account or an organization, either inside or outside of this enterprise.
    | [<CompiledName "EVERYWHERE">] Everywhere

/// The possible values for the enterprise base repository permission setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseDefaultRepositoryPermissionSettingValue =
    /// Organizations in the enterprise choose base repository permissions for their members.
    | [<CompiledName "NO_POLICY">] NoPolicy
    /// Organization members will be able to clone, pull, push, and add new collaborators to all organization repositories.
    | [<CompiledName "ADMIN">] Admin
    /// Organization members will be able to clone, pull, and push all organization repositories.
    | [<CompiledName "WRITE">] Write
    /// Organization members will be able to clone and pull all organization repositories.
    | [<CompiledName "READ">] Read
    /// Organization members will only be able to clone and pull public repositories.
    | [<CompiledName "NONE">] None

/// The possible values for an enabled/no policy enterprise setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseDisallowedMethodsSettingValue =
    /// The setting prevents insecure 2FA methods from being used by members of the enterprise.
    | [<CompiledName "INSECURE">] Insecure
    /// There is no policy set for preventing insecure 2FA methods from being used by members of the enterprise.
    | [<CompiledName "NO_POLICY">] NoPolicy

/// The possible values for an enabled/disabled enterprise setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseEnabledDisabledSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for organizations in the enterprise.
    | [<CompiledName "DISABLED">] Disabled
    /// There is no policy set for organizations in the enterprise.
    | [<CompiledName "NO_POLICY">] NoPolicy

/// The possible values for an enabled/no policy enterprise setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseEnabledSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// There is no policy set for organizations in the enterprise.
    | [<CompiledName "NO_POLICY">] NoPolicy

/// Properties by which enterprise member invitation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMemberInvitationOrderField =
    /// Order enterprise member invitations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which enterprise member connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMemberOrderField =
    /// Order enterprise members by login
    | [<CompiledName "LOGIN">] Login
    /// Order enterprise members by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible values for the enterprise members can create repositories setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMembersCanCreateRepositoriesSettingValue =
    /// Organization owners choose whether to allow members to create repositories.
    | [<CompiledName "NO_POLICY">] NoPolicy
    /// Members will be able to create public and private repositories.
    | [<CompiledName "ALL">] All
    /// Members will be able to create only public repositories.
    | [<CompiledName "PUBLIC">] Public
    /// Members will be able to create only private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// Members will not be able to create public or private repositories.
    | [<CompiledName "DISABLED">] Disabled

/// The possible values for the members can make purchases setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMembersCanMakePurchasesSettingValue =
    /// The setting is enabled for organizations in the enterprise.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for organizations in the enterprise.
    | [<CompiledName "DISABLED">] Disabled

/// The possible values we have for filtering Platform::Objects::User#enterprises.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseMembershipType =
    /// Returns all enterprises in which the user is a member, admin, or billing manager.
    | [<CompiledName "ALL">] All
    /// Returns all enterprises in which the user is an admin.
    | [<CompiledName "ADMIN">] Admin
    /// Returns all enterprises in which the user is a billing manager.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// Returns all enterprises in which the user is a member of an org that is owned by the enterprise.
    | [<CompiledName "ORG_MEMBERSHIP">] OrgMembership

/// Properties by which enterprise connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseOrderField =
    /// Order enterprises by name
    | [<CompiledName "NAME">] Name

/// Properties by which Enterprise Server installation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerInstallationOrderField =
    /// Order Enterprise Server installations by host name
    | [<CompiledName "HOST_NAME">] HostName
    /// Order Enterprise Server installations by customer name
    | [<CompiledName "CUSTOMER_NAME">] CustomerName
    /// Order Enterprise Server installations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which Enterprise Server user account email connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountEmailOrderField =
    /// Order emails by email
    | [<CompiledName "EMAIL">] Email

/// Properties by which Enterprise Server user account connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountOrderField =
    /// Order user accounts by login
    | [<CompiledName "LOGIN">] Login
    /// Order user accounts by creation time on the Enterprise Server installation
    | [<CompiledName "REMOTE_CREATED_AT">] RemoteCreatedAt

/// Properties by which Enterprise Server user accounts upload connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountsUploadOrderField =
    /// Order user accounts uploads by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Synchronization state of the Enterprise Server user accounts upload
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseServerUserAccountsUploadSyncState =
    /// The synchronization of the upload is pending.
    | [<CompiledName "PENDING">] Pending
    /// The synchronization of the upload succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// The synchronization of the upload failed.
    | [<CompiledName "FAILURE">] Failure

/// The possible roles for enterprise membership.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseUserAccountMembershipRole =
    /// The user is a member of an organization in the enterprise.
    | [<CompiledName "MEMBER">] Member
    /// The user is an owner of an organization in the enterprise.
    | [<CompiledName "OWNER">] Owner
    /// The user is not an owner of the enterprise, and not a member or owner of any organizations in the enterprise; only for EMU-enabled enterprises.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated

/// The possible GitHub Enterprise deployments where this user can exist.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnterpriseUserDeployment =
    /// The user is part of a GitHub Enterprise Cloud deployment.
    | [<CompiledName "CLOUD">] Cloud
    /// The user is part of a GitHub Enterprise Server deployment.
    | [<CompiledName "SERVER">] Server

/// Properties by which environments connections can be ordered
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnvironmentOrderField =
    /// Order environments by name.
    | [<CompiledName "NAME">] Name

/// Properties by which environments connections can be ordered
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EnvironmentPinnedFilterField =
    /// All environments will be returned.
    | [<CompiledName "ALL">] All
    /// Only pinned environment will be returned
    | [<CompiledName "ONLY">] Only
    /// Environments exclude pinned will be returned
    | [<CompiledName "NONE">] None

/// The possible viewed states of a file .
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FileViewedState =
    /// The file has new changes since last viewed.
    | [<CompiledName "DISMISSED">] Dismissed
    /// The file has been marked as viewed.
    | [<CompiledName "VIEWED">] Viewed
    /// The file has not been marked as viewed.
    | [<CompiledName "UNVIEWED">] Unviewed

/// The possible funding platforms for repository funding links.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FundingPlatform =
    /// GitHub funding platform.
    | [<CompiledName "GITHUB">] Github
    /// Patreon funding platform.
    | [<CompiledName "PATREON">] Patreon
    /// Open Collective funding platform.
    | [<CompiledName "OPEN_COLLECTIVE">] OpenCollective
    /// Ko-fi funding platform.
    | [<CompiledName "KO_FI">] KoFi
    /// Tidelift funding platform.
    | [<CompiledName "TIDELIFT">] Tidelift
    /// Community Bridge funding platform.
    | [<CompiledName "COMMUNITY_BRIDGE">] CommunityBridge
    /// Liberapay funding platform.
    | [<CompiledName "LIBERAPAY">] Liberapay
    /// IssueHunt funding platform.
    | [<CompiledName "ISSUEHUNT">] Issuehunt
    /// LFX Crowdfunding funding platform.
    | [<CompiledName "LFX_CROWDFUNDING">] LfxCrowdfunding
    /// Polar funding platform.
    | [<CompiledName "POLAR">] Polar
    /// Buy Me a Coffee funding platform.
    | [<CompiledName "BUY_ME_A_COFFEE">] BuyMeACoffee
    /// thanks.dev funding platform.
    | [<CompiledName "THANKS_DEV">] ThanksDev
    /// Custom funding platform.
    | [<CompiledName "CUSTOM">] Custom

/// Properties by which gist connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GistOrderField =
    /// Order gists by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order gists by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order gists by push time
    | [<CompiledName "PUSHED_AT">] PushedAt

/// The privacy of a Gist
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GistPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Secret
    | [<CompiledName "SECRET">] Secret
    /// Gists that are public and secret
    | [<CompiledName "ALL">] All

/// The state of a Git signature.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GitSignatureState =
    /// Valid signature and verified by GitHub
    | [<CompiledName "VALID">] Valid
    /// Invalid signature
    | [<CompiledName "INVALID">] Invalid
    /// Malformed signature
    | [<CompiledName "MALFORMED_SIG">] MalformedSig
    /// Key used for signing not known to GitHub
    | [<CompiledName "UNKNOWN_KEY">] UnknownKey
    /// Invalid email used for signing
    | [<CompiledName "BAD_EMAIL">] BadEmail
    /// Email used for signing unverified on GitHub
    | [<CompiledName "UNVERIFIED_EMAIL">] UnverifiedEmail
    /// Email used for signing not known to GitHub
    | [<CompiledName "NO_USER">] NoUser
    /// Unknown signature type
    | [<CompiledName "UNKNOWN_SIG_TYPE">] UnknownSigType
    /// Unsigned
    | [<CompiledName "UNSIGNED">] Unsigned
    /// Internal error - the GPG verification service is unavailable at the moment
    | [<CompiledName "GPGVERIFY_UNAVAILABLE">] GpgverifyUnavailable
    /// Internal error - the GPG verification service misbehaved
    | [<CompiledName "GPGVERIFY_ERROR">] GpgverifyError
    /// The usage flags for the key that signed this don't allow signing
    | [<CompiledName "NOT_SIGNING_KEY">] NotSigningKey
    /// Signing key expired
    | [<CompiledName "EXPIRED_KEY">] ExpiredKey
    /// Valid signature, pending certificate revocation checking
    | [<CompiledName "OCSP_PENDING">] OcspPending
    /// Valid signature, though certificate revocation check failed
    | [<CompiledName "OCSP_ERROR">] OcspError
    /// The signing certificate or its chain could not be verified
    | [<CompiledName "BAD_CERT">] BadCert
    /// One or more certificates in chain has been revoked
    | [<CompiledName "OCSP_REVOKED">] OcspRevoked

/// The possible states in which authentication can be configured with an identity provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IdentityProviderConfigurationState =
    /// Authentication with an identity provider is configured and enforced.
    | [<CompiledName "ENFORCED">] Enforced
    /// Authentication with an identity provider is configured but not enforced.
    | [<CompiledName "CONFIGURED">] Configured
    /// Authentication with an identity provider is not configured.
    | [<CompiledName "UNCONFIGURED">] Unconfigured

/// The possible values for the IP allow list enabled setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IpAllowListEnabledSettingValue =
    /// The setting is enabled for the owner.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for the owner.
    | [<CompiledName "DISABLED">] Disabled

/// Properties by which IP allow list entry connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IpAllowListEntryOrderField =
    /// Order IP allow list entries by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order IP allow list entries by the allow list value.
    | [<CompiledName "ALLOW_LIST_VALUE">] AllowListValue

/// The possible values for the IP allow list configuration for installed GitHub Apps setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IpAllowListForInstalledAppsEnabledSettingValue =
    /// The setting is enabled for the owner.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for the owner.
    | [<CompiledName "DISABLED">] Disabled

/// The possible state reasons of a closed issue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueClosedStateReason =
    /// An issue that has been closed as completed
    | [<CompiledName "COMPLETED">] Completed
    /// An issue that has been closed as not planned
    | [<CompiledName "NOT_PLANNED">] NotPlanned
    /// An issue that has been closed as a duplicate
    | [<CompiledName "DUPLICATE">] Duplicate

/// Properties by which issue comment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueCommentOrderField =
    /// Order issue comments by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// Properties by which issue connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueOrderField =
    /// Order issues by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order issues by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order issues by comment count
    | [<CompiledName "COMMENTS">] Comments

/// The possible states of an issue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueState =
    /// An issue that is still open
    | [<CompiledName "OPEN">] Open
    /// An issue that has been closed
    | [<CompiledName "CLOSED">] Closed

/// The possible state reasons of an issue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueStateReason =
    /// An issue that has been reopened
    | [<CompiledName "REOPENED">] Reopened
    /// An issue that has been closed as not planned
    | [<CompiledName "NOT_PLANNED">] NotPlanned
    /// An issue that has been closed as completed
    | [<CompiledName "COMPLETED">] Completed
    /// An issue that has been closed as a duplicate.
    | [<CompiledName "DUPLICATE">] Duplicate

/// The possible item types found in a timeline.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueTimelineItemsItemType =
    /// Represents a comment on an Issue.
    | [<CompiledName "ISSUE_COMMENT">] IssueComment
    /// Represents a mention made by one issue or pull request to another.
    | [<CompiledName "CROSS_REFERENCED_EVENT">] CrossReferencedEvent
    /// Represents a 'added_to_project' event on a given issue or pull request.
    | [<CompiledName "ADDED_TO_PROJECT_EVENT">] AddedToProjectEvent
    /// Represents an 'assigned' event on any assignable object.
    | [<CompiledName "ASSIGNED_EVENT">] AssignedEvent
    /// Represents a 'closed' event on any `Closable`.
    | [<CompiledName "CLOSED_EVENT">] ClosedEvent
    /// Represents a 'comment_deleted' event on a given issue or pull request.
    | [<CompiledName "COMMENT_DELETED_EVENT">] CommentDeletedEvent
    /// Represents a 'connected' event on a given issue or pull request.
    | [<CompiledName "CONNECTED_EVENT">] ConnectedEvent
    /// Represents a 'converted_note_to_issue' event on a given issue or pull request.
    | [<CompiledName "CONVERTED_NOTE_TO_ISSUE_EVENT">] ConvertedNoteToIssueEvent
    /// Represents a 'converted_to_discussion' event on a given issue.
    | [<CompiledName "CONVERTED_TO_DISCUSSION_EVENT">] ConvertedToDiscussionEvent
    /// Represents a 'demilestoned' event on a given issue or pull request.
    | [<CompiledName "DEMILESTONED_EVENT">] DemilestonedEvent
    /// Represents a 'disconnected' event on a given issue or pull request.
    | [<CompiledName "DISCONNECTED_EVENT">] DisconnectedEvent
    /// Represents a 'labeled' event on a given issue or pull request.
    | [<CompiledName "LABELED_EVENT">] LabeledEvent
    /// Represents a 'locked' event on a given issue or pull request.
    | [<CompiledName "LOCKED_EVENT">] LockedEvent
    /// Represents a 'marked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "MARKED_AS_DUPLICATE_EVENT">] MarkedAsDuplicateEvent
    /// Represents a 'mentioned' event on a given issue or pull request.
    | [<CompiledName "MENTIONED_EVENT">] MentionedEvent
    /// Represents a 'milestoned' event on a given issue or pull request.
    | [<CompiledName "MILESTONED_EVENT">] MilestonedEvent
    /// Represents a 'moved_columns_in_project' event on a given issue or pull request.
    | [<CompiledName "MOVED_COLUMNS_IN_PROJECT_EVENT">] MovedColumnsInProjectEvent
    /// Represents a 'pinned' event on a given issue or pull request.
    | [<CompiledName "PINNED_EVENT">] PinnedEvent
    /// Represents a 'referenced' event on a given `ReferencedSubject`.
    | [<CompiledName "REFERENCED_EVENT">] ReferencedEvent
    /// Represents a 'removed_from_project' event on a given issue or pull request.
    | [<CompiledName "REMOVED_FROM_PROJECT_EVENT">] RemovedFromProjectEvent
    /// Represents a 'renamed' event on a given issue or pull request
    | [<CompiledName "RENAMED_TITLE_EVENT">] RenamedTitleEvent
    /// Represents a 'reopened' event on any `Closable`.
    | [<CompiledName "REOPENED_EVENT">] ReopenedEvent
    /// Represents a 'subscribed' event on a given `Subscribable`.
    | [<CompiledName "SUBSCRIBED_EVENT">] SubscribedEvent
    /// Represents a 'transferred' event on a given issue or pull request.
    | [<CompiledName "TRANSFERRED_EVENT">] TransferredEvent
    /// Represents an 'unassigned' event on any assignable object.
    | [<CompiledName "UNASSIGNED_EVENT">] UnassignedEvent
    /// Represents an 'unlabeled' event on a given issue or pull request.
    | [<CompiledName "UNLABELED_EVENT">] UnlabeledEvent
    /// Represents an 'unlocked' event on a given issue or pull request.
    | [<CompiledName "UNLOCKED_EVENT">] UnlockedEvent
    /// Represents a 'user_blocked' event on a given user.
    | [<CompiledName "USER_BLOCKED_EVENT">] UserBlockedEvent
    /// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "UNMARKED_AS_DUPLICATE_EVENT">] UnmarkedAsDuplicateEvent
    /// Represents an 'unpinned' event on a given issue or pull request.
    | [<CompiledName "UNPINNED_EVENT">] UnpinnedEvent
    /// Represents an 'unsubscribed' event on a given `Subscribable`.
    | [<CompiledName "UNSUBSCRIBED_EVENT">] UnsubscribedEvent
    /// Represents a 'issue_type_added' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_ADDED_EVENT">] IssueTypeAddedEvent
    /// Represents a 'issue_type_removed' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_REMOVED_EVENT">] IssueTypeRemovedEvent
    /// Represents a 'issue_type_changed' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_CHANGED_EVENT">] IssueTypeChangedEvent
    /// Represents a 'sub_issue_added' event on a given issue.
    | [<CompiledName "SUB_ISSUE_ADDED_EVENT">] SubIssueAddedEvent
    /// Represents a 'sub_issue_removed' event on a given issue.
    | [<CompiledName "SUB_ISSUE_REMOVED_EVENT">] SubIssueRemovedEvent
    /// Represents a 'parent_issue_added' event on a given issue.
    | [<CompiledName "PARENT_ISSUE_ADDED_EVENT">] ParentIssueAddedEvent
    /// Represents a 'parent_issue_removed' event on a given issue.
    | [<CompiledName "PARENT_ISSUE_REMOVED_EVENT">] ParentIssueRemovedEvent

/// The possible color for an issue type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueTypeColor =
    /// gray
    | [<CompiledName "GRAY">] Gray
    /// blue
    | [<CompiledName "BLUE">] Blue
    /// green
    | [<CompiledName "GREEN">] Green
    /// yellow
    | [<CompiledName "YELLOW">] Yellow
    /// orange
    | [<CompiledName "ORANGE">] Orange
    /// red
    | [<CompiledName "RED">] Red
    /// pink
    | [<CompiledName "PINK">] Pink
    /// purple
    | [<CompiledName "PURPLE">] Purple

/// Properties by which issue type connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueTypeOrderField =
    /// Order issue types by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order issue types by name
    | [<CompiledName "NAME">] Name

/// Properties by which label connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LabelOrderField =
    /// Order labels by name
    | [<CompiledName "NAME">] Name
    /// Order labels by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order labels by issue count
    | [<CompiledName "ISSUE_COUNT">] IssueCount

/// Properties by which language connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LanguageOrderField =
    /// Order languages by the size of all files containing the language
    | [<CompiledName "SIZE">] Size

/// The possible reasons that an issue or pull request was locked.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LockReason =
    /// The issue or pull request was locked because the conversation was off-topic.
    | [<CompiledName "OFF_TOPIC">] OffTopic
    /// The issue or pull request was locked because the conversation was too heated.
    | [<CompiledName "TOO_HEATED">] TooHeated
    /// The issue or pull request was locked because the conversation was resolved.
    | [<CompiledName "RESOLVED">] Resolved
    /// The issue or pull request was locked because the conversation was spam.
    | [<CompiledName "SPAM">] Spam

/// Properties by which mannequins can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MannequinOrderField =
    /// Order mannequins alphabetically by their source login.
    | [<CompiledName "LOGIN">] Login
    /// Order mannequins why when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible default commit messages for merges.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeCommitMessage =
    /// Default to the pull request's title.
    | [<CompiledName "PR_TITLE">] PrTitle
    /// Default to the pull request's body.
    | [<CompiledName "PR_BODY">] PrBody
    /// Default to a blank commit message.
    | [<CompiledName "BLANK">] Blank

/// The possible default commit titles for merges.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeCommitTitle =
    /// Default to the pull request's title.
    | [<CompiledName "PR_TITLE">] PrTitle
    /// Default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    | [<CompiledName "MERGE_MESSAGE">] MergeMessage

/// The possible states for a merge queue entry.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeQueueEntryState =
    /// The entry is currently queued.
    | [<CompiledName "QUEUED">] Queued
    /// The entry is currently waiting for checks to pass.
    | [<CompiledName "AWAITING_CHECKS">] AwaitingChecks
    /// The entry is currently mergeable.
    | [<CompiledName "MERGEABLE">] Mergeable
    /// The entry is currently unmergeable.
    | [<CompiledName "UNMERGEABLE">] Unmergeable
    /// The entry is currently locked.
    | [<CompiledName "LOCKED">] Locked

/// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeQueueGroupingStrategy =
    /// The merge commit created by merge queue for each PR in the group must pass all required checks to merge
    | [<CompiledName "ALLGREEN">] Allgreen
    /// Only the commit at the head of the merge group must pass its required checks to merge.
    | [<CompiledName "HEADGREEN">] Headgreen

/// Method to use when merging changes from queued pull requests.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeQueueMergeMethod =
    /// Merge commit
    | [<CompiledName "MERGE">] Merge
    /// Squash and merge
    | [<CompiledName "SQUASH">] Squash
    /// Rebase and merge
    | [<CompiledName "REBASE">] Rebase

/// The possible merging strategies for a merge queue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeQueueMergingStrategy =
    /// Entries only allowed to merge if they are passing.
    | [<CompiledName "ALLGREEN">] Allgreen
    /// Failing Entires are allowed to merge if they are with a passing entry.
    | [<CompiledName "HEADGREEN">] Headgreen

/// Detailed status information about a pull request merge.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeStateStatus =
    /// The merge commit cannot be cleanly created.
    | [<CompiledName "DIRTY">] Dirty
    /// The state cannot currently be determined.
    | [<CompiledName "UNKNOWN">] Unknown
    /// The merge is blocked.
    | [<CompiledName "BLOCKED">] Blocked
    /// The head ref is out of date.
    | [<CompiledName "BEHIND">] Behind
    /// Mergeable with non-passing commit status.
    | [<CompiledName "UNSTABLE">] Unstable
    /// Mergeable with passing commit status and pre-receive hooks.
    | [<CompiledName "HAS_HOOKS">] HasHooks
    /// Mergeable and passing commit status.
    | [<CompiledName "CLEAN">] Clean

/// Whether or not a PullRequest can be merged.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeableState =
    /// The pull request can be merged.
    | [<CompiledName "MERGEABLE">] Mergeable
    /// The pull request cannot be merged due to merge conflicts.
    | [<CompiledName "CONFLICTING">] Conflicting
    /// The mergeability of the pull request is still being calculated.
    | [<CompiledName "UNKNOWN">] Unknown

/// Represents the different GitHub Enterprise Importer (GEI) migration sources.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MigrationSourceType =
    /// An Azure DevOps migration source.
    | [<CompiledName "AZURE_DEVOPS">] AzureDevops
    /// A Bitbucket Server migration source.
    | [<CompiledName "BITBUCKET_SERVER">] BitbucketServer
    /// A GitHub Migration API source.
    | [<CompiledName "GITHUB_ARCHIVE">] GithubArchive

/// The GitHub Enterprise Importer (GEI) migration state.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MigrationState =
    /// The migration has not started.
    | [<CompiledName "NOT_STARTED">] NotStarted
    /// The migration has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The migration is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The migration has succeeded.
    | [<CompiledName "SUCCEEDED">] Succeeded
    /// The migration has failed.
    | [<CompiledName "FAILED">] Failed
    /// The migration needs to have its credentials validated.
    | [<CompiledName "PENDING_VALIDATION">] PendingValidation
    /// The migration has invalid credentials.
    | [<CompiledName "FAILED_VALIDATION">] FailedValidation

/// Properties by which milestone connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneOrderField =
    /// Order milestones by when they are due.
    | [<CompiledName "DUE_DATE">] DueDate
    /// Order milestones by when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order milestones by when they were last updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order milestones by their number.
    | [<CompiledName "NUMBER">] Number

/// The possible states of a milestone.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneState =
    /// A milestone that is still open.
    | [<CompiledName "OPEN">] Open
    /// A milestone that has been closed.
    | [<CompiledName "CLOSED">] Closed

/// The possible values for the notification restriction setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NotificationRestrictionSettingValue =
    /// The setting is enabled for the owner.
    | [<CompiledName "ENABLED">] Enabled
    /// The setting is disabled for the owner.
    | [<CompiledName "DISABLED">] Disabled

/// The OIDC identity provider type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OIDCProviderType =
    /// Azure Active Directory
    | [<CompiledName "AAD">] Aad

/// The state of an OAuth application when it was created.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OauthApplicationCreateAuditEntryState =
    /// The OAuth application was active and allowed to have OAuth Accesses.
    | [<CompiledName "ACTIVE">] Active
    /// The OAuth application was suspended from generating OAuth Accesses due to abuse or security concerns.
    | [<CompiledName "SUSPENDED">] Suspended
    /// The OAuth application was in the process of being deleted.
    | [<CompiledName "PENDING_DELETION">] PendingDeletion

/// The corresponding operation type for the action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OperationType =
    /// An existing resource was accessed
    | [<CompiledName "ACCESS">] Access
    /// A resource performed an authentication event
    | [<CompiledName "AUTHENTICATION">] Authentication
    /// A new resource was created
    | [<CompiledName "CREATE">] Create
    /// An existing resource was modified
    | [<CompiledName "MODIFY">] Modify
    /// An existing resource was removed
    | [<CompiledName "REMOVE">] Remove
    /// An existing resource was restored
    | [<CompiledName "RESTORE">] Restore
    /// An existing resource was transferred between multiple resources
    | [<CompiledName "TRANSFER">] Transfer

/// Possible directions in which to order a list of items when provided an `orderBy` argument.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrderDirection =
    /// Specifies an ascending order for a given `orderBy` argument.
    | [<CompiledName "ASC">] Asc
    /// Specifies a descending order for a given `orderBy` argument.
    | [<CompiledName "DESC">] Desc

/// The permissions available to members on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgAddMemberAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin

/// The billing plans available for organizations.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgCreateAuditEntryBillingPlan =
    /// Free Plan
    | [<CompiledName "FREE">] Free
    /// Team Plan
    | [<CompiledName "BUSINESS">] Business
    /// Enterprise Cloud Plan
    | [<CompiledName "BUSINESS_PLUS">] BusinessPlus
    /// Legacy Unlimited Plan
    | [<CompiledName "UNLIMITED">] Unlimited
    /// Tiered Per Seat Plan
    | [<CompiledName "TIERED_PER_SEAT">] TieredPerSeat

/// Properties by which enterprise owners can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgEnterpriseOwnerOrderField =
    /// Order enterprise owners by login.
    | [<CompiledName "LOGIN">] Login

/// The reason a billing manager was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveBillingManagerAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing
    /// SAML SSO enforcement requires an external identity
    | [<CompiledName "SAML_SSO_ENFORCEMENT_REQUIRES_EXTERNAL_IDENTITY">] SamlSsoEnforcementRequiresExternalIdentity

/// The type of membership a user has with an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveMemberAuditEntryMembershipType =
    /// A suspended member.
    | [<CompiledName "SUSPENDED">] Suspended
    /// A direct member is a user that is a member of the Organization.
    | [<CompiledName "DIRECT_MEMBER">] DirectMember
    /// Organization owners have full access and can change several settings, including the names of repositories that belong to the Organization and Owners team membership. In addition, organization owners can delete the organization and all of its repositories.
    | [<CompiledName "ADMIN">] Admin
    /// A billing manager is a user who manages the billing settings for the Organization, such as updating payment information.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// An unaffiliated collaborator is a person who is not a member of the Organization and does not have access to any repositories in the Organization.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated
    /// An outside collaborator is a person who isn't explicitly a member of the Organization, but who has Read, Write, or Admin permissions to one or more repositories in the organization.
    | [<CompiledName "OUTSIDE_COLLABORATOR">] OutsideCollaborator

/// The reason a member was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveMemberAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing
    /// SAML SSO enforcement requires an external identity
    | [<CompiledName "SAML_SSO_ENFORCEMENT_REQUIRES_EXTERNAL_IDENTITY">] SamlSsoEnforcementRequiresExternalIdentity
    /// User account has been deleted
    | [<CompiledName "USER_ACCOUNT_DELETED">] UserAccountDeleted
    /// User was removed from organization during account recovery
    | [<CompiledName "TWO_FACTOR_ACCOUNT_RECOVERY">] TwoFactorAccountRecovery

/// The type of membership a user has with an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveOutsideCollaboratorAuditEntryMembershipType =
    /// An outside collaborator is a person who isn't explicitly a member of the Organization, but who has Read, Write, or Admin permissions to one or more repositories in the organization.
    | [<CompiledName "OUTSIDE_COLLABORATOR">] OutsideCollaborator
    /// An unaffiliated collaborator is a person who is not a member of the Organization and does not have access to any repositories in the organization.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated
    /// A billing manager is a user who manages the billing settings for the Organization, such as updating payment information.
    | [<CompiledName "BILLING_MANAGER">] BillingManager

/// The reason an outside collaborator was removed from an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgRemoveOutsideCollaboratorAuditEntryReason =
    /// The organization required 2FA of its billing managers and this user did not have 2FA enabled.
    | [<CompiledName "TWO_FACTOR_REQUIREMENT_NON_COMPLIANCE">] TwoFactorRequirementNonCompliance
    /// SAML external identity missing
    | [<CompiledName "SAML_EXTERNAL_IDENTITY_MISSING">] SamlExternalIdentityMissing

/// The default permission a repository can have in an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateDefaultRepositoryPermissionAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone and push to repositories.
    | [<CompiledName "WRITE">] Write
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin
    /// No default permission value.
    | [<CompiledName "NONE">] None

/// The permissions available to members on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateMemberAuditEntryPermission =
    /// Can read and clone repositories.
    | [<CompiledName "READ">] Read
    /// Can read, clone, push, and add collaborators to repositories.
    | [<CompiledName "ADMIN">] Admin

/// The permissions available for repository creation on an Organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrgUpdateMemberRepositoryCreationPermissionAuditEntryVisibility =
    /// All organization members are restricted from creating any repositories.
    | [<CompiledName "ALL">] All
    /// All organization members are restricted from creating public repositories.
    | [<CompiledName "PUBLIC">] Public
    /// All organization members are allowed to create any repositories.
    | [<CompiledName "NONE">] None
    /// All organization members are restricted from creating private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// All organization members are restricted from creating internal repositories.
    | [<CompiledName "INTERNAL">] Internal
    /// All organization members are restricted from creating public or internal repositories.
    | [<CompiledName "PUBLIC_INTERNAL">] PublicInternal
    /// All organization members are restricted from creating private or internal repositories.
    | [<CompiledName "PRIVATE_INTERNAL">] PrivateInternal
    /// All organization members are restricted from creating public or private repositories.
    | [<CompiledName "PUBLIC_PRIVATE">] PublicPrivate

/// The possible organization invitation roles.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationInvitationRole =
    /// The user is invited to be a direct member of the organization.
    | [<CompiledName "DIRECT_MEMBER">] DirectMember
    /// The user is invited to be an admin of the organization.
    | [<CompiledName "ADMIN">] Admin
    /// The user is invited to be a billing manager of the organization.
    | [<CompiledName "BILLING_MANAGER">] BillingManager
    /// The user's previous role will be reinstated.
    | [<CompiledName "REINSTATE">] Reinstate

/// The possible organization invitation sources.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationInvitationSource =
    /// The invitation was sent before this feature was added
    | [<CompiledName "UNKNOWN">] Unknown
    /// The invitation was created from the web interface or from API
    | [<CompiledName "MEMBER">] Member
    /// The invitation was created from SCIM
    | [<CompiledName "SCIM">] Scim

/// The possible organization invitation types.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationInvitationType =
    /// The invitation was to an existing user.
    | [<CompiledName "USER">] User
    /// The invitation was to an email address.
    | [<CompiledName "EMAIL">] Email

/// The possible roles within an organization for its members.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationMemberRole =
    /// The user is a member of the organization.
    | [<CompiledName "MEMBER">] Member
    /// The user is an administrator of the organization.
    | [<CompiledName "ADMIN">] Admin

/// The possible values for the members can create repositories setting on an organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationMembersCanCreateRepositoriesSettingValue =
    /// Members will be able to create public and private repositories.
    | [<CompiledName "ALL">] All
    /// Members will be able to create only private repositories.
    | [<CompiledName "PRIVATE">] Private
    /// Members will be able to create only internal repositories.
    | [<CompiledName "INTERNAL">] Internal
    /// Members will not be able to create public or private repositories.
    | [<CompiledName "DISABLED">] Disabled

/// The Octoshift Organization migration state.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationMigrationState =
    /// The Octoshift migration has not started.
    | [<CompiledName "NOT_STARTED">] NotStarted
    /// The Octoshift migration has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The Octoshift migration is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The Octoshift migration is performing pre repository migrations.
    | [<CompiledName "PRE_REPO_MIGRATION">] PreRepoMigration
    /// The Octoshift org migration is performing repository migrations.
    | [<CompiledName "REPO_MIGRATION">] RepoMigration
    /// The Octoshift migration is performing post repository migrations.
    | [<CompiledName "POST_REPO_MIGRATION">] PostRepoMigration
    /// The Octoshift migration has succeeded.
    | [<CompiledName "SUCCEEDED">] Succeeded
    /// The Octoshift migration has failed.
    | [<CompiledName "FAILED">] Failed
    /// The Octoshift migration needs to have its credentials validated.
    | [<CompiledName "PENDING_VALIDATION">] PendingValidation
    /// The Octoshift migration has invalid credentials.
    | [<CompiledName "FAILED_VALIDATION">] FailedValidation

/// Properties by which organization connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationOrderField =
    /// Order organizations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order organizations by login
    | [<CompiledName "LOGIN">] Login

/// Properties by which package file connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageFileOrderField =
    /// Order package files by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which package connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageOrderField =
    /// Order packages by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible types of a package.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageType =
    /// A debian package.
    | [<CompiledName "DEBIAN">] Debian
    /// A python package.
    | [<CompiledName "PYPI">] Pypi

/// Properties by which package version connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageVersionOrderField =
    /// Order package versions by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible types of patch statuses.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PatchStatus =
    /// The file was added. Git status 'A'.
    | [<CompiledName "ADDED">] Added
    /// The file was deleted. Git status 'D'.
    | [<CompiledName "DELETED">] Deleted
    /// The file was renamed. Git status 'R'.
    | [<CompiledName "RENAMED">] Renamed
    /// The file was copied. Git status 'C'.
    | [<CompiledName "COPIED">] Copied
    /// The file's contents were changed. Git status 'M'.
    | [<CompiledName "MODIFIED">] Modified
    /// The file's type was changed. Git status 'T'.
    | [<CompiledName "CHANGED">] Changed

/// Represents items that can be pinned to a profile page or dashboard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PinnableItemType =
    /// A repository.
    | [<CompiledName "REPOSITORY">] Repository
    /// A gist.
    | [<CompiledName "GIST">] Gist
    /// An issue.
    | [<CompiledName "ISSUE">] Issue
    /// A project.
    | [<CompiledName "PROJECT">] Project
    /// A pull request.
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// A user.
    | [<CompiledName "USER">] User
    /// An organization.
    | [<CompiledName "ORGANIZATION">] Organization
    /// A team.
    | [<CompiledName "TEAM">] Team

/// Preconfigured gradients that may be used to style discussions pinned within a repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PinnedDiscussionGradient =
    /// A gradient of red to orange
    | [<CompiledName "RED_ORANGE">] RedOrange
    /// A gradient of blue to mint
    | [<CompiledName "BLUE_MINT">] BlueMint
    /// A gradient of blue to purple
    | [<CompiledName "BLUE_PURPLE">] BluePurple
    /// A gradient of pink to blue
    | [<CompiledName "PINK_BLUE">] PinkBlue
    /// A gradient of purple to coral
    | [<CompiledName "PURPLE_CORAL">] PurpleCoral

/// Preconfigured background patterns that may be used to style discussions pinned within a repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PinnedDiscussionPattern =
    /// A solid dot pattern
    | [<CompiledName "DOT_FILL">] DotFill
    /// A plus sign pattern
    | [<CompiledName "PLUS">] Plus
    /// A lightning bolt pattern
    | [<CompiledName "ZAP">] Zap
    /// An upward-facing chevron pattern
    | [<CompiledName "CHEVRON_UP">] ChevronUp
    /// A hollow dot pattern
    | [<CompiledName "DOT">] Dot
    /// A heart pattern
    | [<CompiledName "HEART_FILL">] HeartFill

/// Properties by which pinned environments connections can be ordered
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PinnedEnvironmentOrderField =
    /// Order pinned environments by position
    | [<CompiledName "POSITION">] Position

/// Various content states of a ProjectCard
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectCardState =
    /// The card has content only.
    | [<CompiledName "CONTENT_ONLY">] ContentOnly
    /// The card has a note only.
    | [<CompiledName "NOTE_ONLY">] NoteOnly
    /// The card is redacted.
    | [<CompiledName "REDACTED">] Redacted

/// The semantic purpose of the column - todo, in progress, or done.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectColumnPurpose =
    /// The column contains cards still to be worked on
    | [<CompiledName "TODO">] Todo
    /// The column contains cards which are currently being worked on
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The column contains cards which are complete
    | [<CompiledName "DONE">] Done

/// Properties by which project connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectOrderField =
    /// Order projects by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order projects by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order projects by name
    | [<CompiledName "NAME">] Name

/// State of the project; either 'open' or 'closed'
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectState =
    /// The project is open.
    | [<CompiledName "OPEN">] Open
    /// The project is closed.
    | [<CompiledName "CLOSED">] Closed

/// GitHub-provided templates for Projects
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectTemplate =
    /// Create a board with columns for To do, In progress and Done.
    | [<CompiledName "BASIC_KANBAN">] BasicKanban
    /// Create a board with v2 triggers to automatically move cards across To do, In progress and Done columns.
    | [<CompiledName "AUTOMATED_KANBAN_V2">] AutomatedKanbanV2
    /// Create a board with triggers to automatically move cards across columns with review automation.
    | [<CompiledName "AUTOMATED_REVIEWS_KANBAN">] AutomatedReviewsKanban
    /// Create a board to triage and prioritize bugs with To do, priority, and Done columns.
    | [<CompiledName "BUG_TRIAGE">] BugTriage

/// The type of a project field.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2CustomFieldType =
    /// Text
    | [<CompiledName "TEXT">] Text
    /// Single Select
    | [<CompiledName "SINGLE_SELECT">] SingleSelect
    /// Number
    | [<CompiledName "NUMBER">] Number
    /// Date
    | [<CompiledName "DATE">] Date
    /// Iteration
    | [<CompiledName "ITERATION">] Iteration

/// Properties by which project v2 field connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2FieldOrderField =
    /// Order project v2 fields by position
    | [<CompiledName "POSITION">] Position
    /// Order project v2 fields by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order project v2 fields by name
    | [<CompiledName "NAME">] Name

/// The type of a project field.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2FieldType =
    /// Assignees
    | [<CompiledName "ASSIGNEES">] Assignees
    /// Linked Pull Requests
    | [<CompiledName "LINKED_PULL_REQUESTS">] LinkedPullRequests
    /// Reviewers
    | [<CompiledName "REVIEWERS">] Reviewers
    /// Labels
    | [<CompiledName "LABELS">] Labels
    /// Milestone
    | [<CompiledName "MILESTONE">] Milestone
    /// Repository
    | [<CompiledName "REPOSITORY">] Repository
    /// Title
    | [<CompiledName "TITLE">] Title
    /// Text
    | [<CompiledName "TEXT">] Text
    /// Single Select
    | [<CompiledName "SINGLE_SELECT">] SingleSelect
    /// Number
    | [<CompiledName "NUMBER">] Number
    /// Date
    | [<CompiledName "DATE">] Date
    /// Iteration
    | [<CompiledName "ITERATION">] Iteration
    /// Tracks
    | [<CompiledName "TRACKS">] Tracks
    /// Tracked by
    | [<CompiledName "TRACKED_BY">] TrackedBy
    /// Issue type
    | [<CompiledName "ISSUE_TYPE">] IssueType
    /// Parent issue
    | [<CompiledName "PARENT_ISSUE">] ParentIssue
    /// Sub-issues progress
    | [<CompiledName "SUB_ISSUES_PROGRESS">] SubIssuesProgress

/// Properties by which project v2 item field value connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2ItemFieldValueOrderField =
    /// Order project v2 item field values by the their position in the project
    | [<CompiledName "POSITION">] Position

/// Properties by which project v2 item connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2ItemOrderField =
    /// Order project v2 items by the their position in the project
    | [<CompiledName "POSITION">] Position

/// The type of a project item.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2ItemType =
    /// Issue
    | [<CompiledName "ISSUE">] Issue
    /// Pull Request
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// Draft Issue
    | [<CompiledName "DRAFT_ISSUE">] DraftIssue
    /// Redacted Item
    | [<CompiledName "REDACTED">] Redacted

/// Properties by which projects can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2OrderField =
    /// The project's title
    | [<CompiledName "TITLE">] Title
    /// The project's number
    | [<CompiledName "NUMBER">] Number
    /// The project's date and time of update
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// The project's date and time of creation
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible roles of a collaborator on a project.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2PermissionLevel =
    /// The collaborator can view the project
    | [<CompiledName "READ">] Read
    /// The collaborator can view and edit the project
    | [<CompiledName "WRITE">] Write
    /// The collaborator can view, edit, and maange the settings of the project
    | [<CompiledName "ADMIN">] Admin

/// The possible roles of a collaborator on a project.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2Roles =
    /// The collaborator has no direct access to the project
    | [<CompiledName "NONE">] None
    /// The collaborator can view the project
    | [<CompiledName "READER">] Reader
    /// The collaborator can view and edit the project
    | [<CompiledName "WRITER">] Writer
    /// The collaborator can view, edit, and maange the settings of the project
    | [<CompiledName "ADMIN">] Admin

/// The display color of a single-select field option.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2SingleSelectFieldOptionColor =
    /// GRAY
    | [<CompiledName "GRAY">] Gray
    /// BLUE
    | [<CompiledName "BLUE">] Blue
    /// GREEN
    | [<CompiledName "GREEN">] Green
    /// YELLOW
    | [<CompiledName "YELLOW">] Yellow
    /// ORANGE
    | [<CompiledName "ORANGE">] Orange
    /// RED
    | [<CompiledName "RED">] Red
    /// PINK
    | [<CompiledName "PINK">] Pink
    /// PURPLE
    | [<CompiledName "PURPLE">] Purple

/// The possible states of a project v2.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2State =
    /// A project v2 that is still open
    | [<CompiledName "OPEN">] Open
    /// A project v2 that has been closed
    | [<CompiledName "CLOSED">] Closed

/// Properties by which project v2 status updates can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2StatusUpdateOrderField =
    /// Allows chronological ordering of project v2 status updates.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible statuses of a project v2.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2StatusUpdateStatus =
    /// A project v2 that is inactive.
    | [<CompiledName "INACTIVE">] Inactive
    /// A project v2 that is on track with no risks.
    | [<CompiledName "ON_TRACK">] OnTrack
    /// A project v2 that is at risk and encountering some challenges.
    | [<CompiledName "AT_RISK">] AtRisk
    /// A project v2 that is off track and needs attention.
    | [<CompiledName "OFF_TRACK">] OffTrack
    /// A project v2 that is complete.
    | [<CompiledName "COMPLETE">] Complete

/// The layout of a project v2 view.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2ViewLayout =
    /// Board layout
    | [<CompiledName "BOARD_LAYOUT">] BoardLayout
    /// Table layout
    | [<CompiledName "TABLE_LAYOUT">] TableLayout
    /// Roadmap layout
    | [<CompiledName "ROADMAP_LAYOUT">] RoadmapLayout

/// Properties by which project v2 view connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2ViewOrderField =
    /// Order project v2 views by position
    | [<CompiledName "POSITION">] Position
    /// Order project v2 views by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order project v2 views by name
    | [<CompiledName "NAME">] Name

/// Properties by which project workflows can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectV2WorkflowsOrderField =
    /// The name of the workflow
    | [<CompiledName "NAME">] Name
    /// The number of the workflow
    | [<CompiledName "NUMBER">] Number
    /// The date and time of the workflow update
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// The date and time of the workflow creation
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestAllowedMergeMethods =
    /// Add all commits from the head branch to the base branch with a merge commit.
    | [<CompiledName "MERGE">] Merge
    /// Combine all commits from the head branch into a single commit in the base branch.
    | [<CompiledName "SQUASH">] Squash
    /// Add all commits from the head branch onto the base branch individually.
    | [<CompiledName "REBASE">] Rebase

/// The possible methods for updating a pull request's head branch with the base branch.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestBranchUpdateMethod =
    /// Update branch via merge
    | [<CompiledName "MERGE">] Merge
    /// Update branch via rebase
    | [<CompiledName "REBASE">] Rebase

/// Represents available types of methods to use when merging a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestMergeMethod =
    /// Add all commits from the head branch to the base branch with a merge commit.
    | [<CompiledName "MERGE">] Merge
    /// Combine all commits from the head branch into a single commit in the base branch.
    | [<CompiledName "SQUASH">] Squash
    /// Add all commits from the head branch onto the base branch individually.
    | [<CompiledName "REBASE">] Rebase

/// Properties by which pull_requests connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestOrderField =
    /// Order pull_requests by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order pull_requests by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// The possible states of a pull request review comment.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewCommentState =
    /// A comment that is part of a pending review
    | [<CompiledName "PENDING">] Pending
    /// A comment that is part of a submitted review
    | [<CompiledName "SUBMITTED">] Submitted

/// The review status of a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewDecision =
    /// Changes have been requested on the pull request.
    | [<CompiledName "CHANGES_REQUESTED">] ChangesRequested
    /// The pull request has received an approving review.
    | [<CompiledName "APPROVED">] Approved
    /// A review is required before the pull request can be merged.
    | [<CompiledName "REVIEW_REQUIRED">] ReviewRequired

/// The possible events to perform on a pull request review.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewEvent =
    /// Submit general feedback without explicit approval.
    | [<CompiledName "COMMENT">] Comment
    /// Submit feedback and approve merging these changes.
    | [<CompiledName "APPROVE">] Approve
    /// Submit feedback that must be addressed before merging.
    | [<CompiledName "REQUEST_CHANGES">] RequestChanges
    /// Dismiss review so it now longer effects merging.
    | [<CompiledName "DISMISS">] Dismiss

/// The possible states of a pull request review.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewState =
    /// A review that has not yet been submitted.
    | [<CompiledName "PENDING">] Pending
    /// An informational review.
    | [<CompiledName "COMMENTED">] Commented
    /// A review allowing the pull request to merge.
    | [<CompiledName "APPROVED">] Approved
    /// A review blocking the pull request from merging.
    | [<CompiledName "CHANGES_REQUESTED">] ChangesRequested
    /// A review that has been dismissed.
    | [<CompiledName "DISMISSED">] Dismissed

/// The possible subject types of a pull request review comment.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestReviewThreadSubjectType =
    /// A comment that has been made against the line of a pull request
    | [<CompiledName "LINE">] Line
    /// A comment that has been made against the file of a pull request
    | [<CompiledName "FILE">] File

/// The possible states of a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestState =
    /// A pull request that is still open.
    | [<CompiledName "OPEN">] Open
    /// A pull request that has been closed without being merged.
    | [<CompiledName "CLOSED">] Closed
    /// A pull request that has been closed by being merged.
    | [<CompiledName "MERGED">] Merged

/// The possible item types found in a timeline.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestTimelineItemsItemType =
    /// Represents a Git commit part of a pull request.
    | [<CompiledName "PULL_REQUEST_COMMIT">] PullRequestCommit
    /// Represents a commit comment thread part of a pull request.
    | [<CompiledName "PULL_REQUEST_COMMIT_COMMENT_THREAD">] PullRequestCommitCommentThread
    /// A review object for a given pull request.
    | [<CompiledName "PULL_REQUEST_REVIEW">] PullRequestReview
    /// A threaded list of comments for a given pull request.
    | [<CompiledName "PULL_REQUEST_REVIEW_THREAD">] PullRequestReviewThread
    /// Represents the latest point in the pull request timeline for which the viewer has seen the pull request's commits.
    | [<CompiledName "PULL_REQUEST_REVISION_MARKER">] PullRequestRevisionMarker
    /// Represents an 'added_to_merge_queue' event on a given pull request.
    | [<CompiledName "ADDED_TO_MERGE_QUEUE_EVENT">] AddedToMergeQueueEvent
    /// Represents a 'automatic_base_change_failed' event on a given pull request.
    | [<CompiledName "AUTOMATIC_BASE_CHANGE_FAILED_EVENT">] AutomaticBaseChangeFailedEvent
    /// Represents a 'automatic_base_change_succeeded' event on a given pull request.
    | [<CompiledName "AUTOMATIC_BASE_CHANGE_SUCCEEDED_EVENT">] AutomaticBaseChangeSucceededEvent
    /// Represents a 'auto_merge_disabled' event on a given pull request.
    | [<CompiledName "AUTO_MERGE_DISABLED_EVENT">] AutoMergeDisabledEvent
    /// Represents a 'auto_merge_enabled' event on a given pull request.
    | [<CompiledName "AUTO_MERGE_ENABLED_EVENT">] AutoMergeEnabledEvent
    /// Represents a 'auto_rebase_enabled' event on a given pull request.
    | [<CompiledName "AUTO_REBASE_ENABLED_EVENT">] AutoRebaseEnabledEvent
    /// Represents a 'auto_squash_enabled' event on a given pull request.
    | [<CompiledName "AUTO_SQUASH_ENABLED_EVENT">] AutoSquashEnabledEvent
    /// Represents a 'base_ref_changed' event on a given issue or pull request.
    | [<CompiledName "BASE_REF_CHANGED_EVENT">] BaseRefChangedEvent
    /// Represents a 'base_ref_force_pushed' event on a given pull request.
    | [<CompiledName "BASE_REF_FORCE_PUSHED_EVENT">] BaseRefForcePushedEvent
    /// Represents a 'base_ref_deleted' event on a given pull request.
    | [<CompiledName "BASE_REF_DELETED_EVENT">] BaseRefDeletedEvent
    /// Represents a 'convert_to_draft' event on a given pull request.
    | [<CompiledName "CONVERT_TO_DRAFT_EVENT">] ConvertToDraftEvent
    /// Represents a 'deployed' event on a given pull request.
    | [<CompiledName "DEPLOYED_EVENT">] DeployedEvent
    /// Represents a 'deployment_environment_changed' event on a given pull request.
    | [<CompiledName "DEPLOYMENT_ENVIRONMENT_CHANGED_EVENT">] DeploymentEnvironmentChangedEvent
    /// Represents a 'head_ref_deleted' event on a given pull request.
    | [<CompiledName "HEAD_REF_DELETED_EVENT">] HeadRefDeletedEvent
    /// Represents a 'head_ref_force_pushed' event on a given pull request.
    | [<CompiledName "HEAD_REF_FORCE_PUSHED_EVENT">] HeadRefForcePushedEvent
    /// Represents a 'head_ref_restored' event on a given pull request.
    | [<CompiledName "HEAD_REF_RESTORED_EVENT">] HeadRefRestoredEvent
    /// Represents a 'merged' event on a given pull request.
    | [<CompiledName "MERGED_EVENT">] MergedEvent
    /// Represents a 'ready_for_review' event on a given pull request.
    | [<CompiledName "READY_FOR_REVIEW_EVENT">] ReadyForReviewEvent
    /// Represents a 'removed_from_merge_queue' event on a given pull request.
    | [<CompiledName "REMOVED_FROM_MERGE_QUEUE_EVENT">] RemovedFromMergeQueueEvent
    /// Represents a 'review_dismissed' event on a given issue or pull request.
    | [<CompiledName "REVIEW_DISMISSED_EVENT">] ReviewDismissedEvent
    /// Represents an 'review_requested' event on a given pull request.
    | [<CompiledName "REVIEW_REQUESTED_EVENT">] ReviewRequestedEvent
    /// Represents an 'review_request_removed' event on a given pull request.
    | [<CompiledName "REVIEW_REQUEST_REMOVED_EVENT">] ReviewRequestRemovedEvent
    /// Represents a comment on an Issue.
    | [<CompiledName "ISSUE_COMMENT">] IssueComment
    /// Represents a mention made by one issue or pull request to another.
    | [<CompiledName "CROSS_REFERENCED_EVENT">] CrossReferencedEvent
    /// Represents a 'added_to_project' event on a given issue or pull request.
    | [<CompiledName "ADDED_TO_PROJECT_EVENT">] AddedToProjectEvent
    /// Represents an 'assigned' event on any assignable object.
    | [<CompiledName "ASSIGNED_EVENT">] AssignedEvent
    /// Represents a 'closed' event on any `Closable`.
    | [<CompiledName "CLOSED_EVENT">] ClosedEvent
    /// Represents a 'comment_deleted' event on a given issue or pull request.
    | [<CompiledName "COMMENT_DELETED_EVENT">] CommentDeletedEvent
    /// Represents a 'connected' event on a given issue or pull request.
    | [<CompiledName "CONNECTED_EVENT">] ConnectedEvent
    /// Represents a 'converted_note_to_issue' event on a given issue or pull request.
    | [<CompiledName "CONVERTED_NOTE_TO_ISSUE_EVENT">] ConvertedNoteToIssueEvent
    /// Represents a 'converted_to_discussion' event on a given issue.
    | [<CompiledName "CONVERTED_TO_DISCUSSION_EVENT">] ConvertedToDiscussionEvent
    /// Represents a 'demilestoned' event on a given issue or pull request.
    | [<CompiledName "DEMILESTONED_EVENT">] DemilestonedEvent
    /// Represents a 'disconnected' event on a given issue or pull request.
    | [<CompiledName "DISCONNECTED_EVENT">] DisconnectedEvent
    /// Represents a 'labeled' event on a given issue or pull request.
    | [<CompiledName "LABELED_EVENT">] LabeledEvent
    /// Represents a 'locked' event on a given issue or pull request.
    | [<CompiledName "LOCKED_EVENT">] LockedEvent
    /// Represents a 'marked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "MARKED_AS_DUPLICATE_EVENT">] MarkedAsDuplicateEvent
    /// Represents a 'mentioned' event on a given issue or pull request.
    | [<CompiledName "MENTIONED_EVENT">] MentionedEvent
    /// Represents a 'milestoned' event on a given issue or pull request.
    | [<CompiledName "MILESTONED_EVENT">] MilestonedEvent
    /// Represents a 'moved_columns_in_project' event on a given issue or pull request.
    | [<CompiledName "MOVED_COLUMNS_IN_PROJECT_EVENT">] MovedColumnsInProjectEvent
    /// Represents a 'pinned' event on a given issue or pull request.
    | [<CompiledName "PINNED_EVENT">] PinnedEvent
    /// Represents a 'referenced' event on a given `ReferencedSubject`.
    | [<CompiledName "REFERENCED_EVENT">] ReferencedEvent
    /// Represents a 'removed_from_project' event on a given issue or pull request.
    | [<CompiledName "REMOVED_FROM_PROJECT_EVENT">] RemovedFromProjectEvent
    /// Represents a 'renamed' event on a given issue or pull request
    | [<CompiledName "RENAMED_TITLE_EVENT">] RenamedTitleEvent
    /// Represents a 'reopened' event on any `Closable`.
    | [<CompiledName "REOPENED_EVENT">] ReopenedEvent
    /// Represents a 'subscribed' event on a given `Subscribable`.
    | [<CompiledName "SUBSCRIBED_EVENT">] SubscribedEvent
    /// Represents a 'transferred' event on a given issue or pull request.
    | [<CompiledName "TRANSFERRED_EVENT">] TransferredEvent
    /// Represents an 'unassigned' event on any assignable object.
    | [<CompiledName "UNASSIGNED_EVENT">] UnassignedEvent
    /// Represents an 'unlabeled' event on a given issue or pull request.
    | [<CompiledName "UNLABELED_EVENT">] UnlabeledEvent
    /// Represents an 'unlocked' event on a given issue or pull request.
    | [<CompiledName "UNLOCKED_EVENT">] UnlockedEvent
    /// Represents a 'user_blocked' event on a given user.
    | [<CompiledName "USER_BLOCKED_EVENT">] UserBlockedEvent
    /// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
    | [<CompiledName "UNMARKED_AS_DUPLICATE_EVENT">] UnmarkedAsDuplicateEvent
    /// Represents an 'unpinned' event on a given issue or pull request.
    | [<CompiledName "UNPINNED_EVENT">] UnpinnedEvent
    /// Represents an 'unsubscribed' event on a given `Subscribable`.
    | [<CompiledName "UNSUBSCRIBED_EVENT">] UnsubscribedEvent
    /// Represents a 'issue_type_added' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_ADDED_EVENT">] IssueTypeAddedEvent
    /// Represents a 'issue_type_removed' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_REMOVED_EVENT">] IssueTypeRemovedEvent
    /// Represents a 'issue_type_changed' event on a given issue.
    | [<CompiledName "ISSUE_TYPE_CHANGED_EVENT">] IssueTypeChangedEvent
    /// Represents a 'sub_issue_added' event on a given issue.
    | [<CompiledName "SUB_ISSUE_ADDED_EVENT">] SubIssueAddedEvent
    /// Represents a 'sub_issue_removed' event on a given issue.
    | [<CompiledName "SUB_ISSUE_REMOVED_EVENT">] SubIssueRemovedEvent
    /// Represents a 'parent_issue_added' event on a given issue.
    | [<CompiledName "PARENT_ISSUE_ADDED_EVENT">] ParentIssueAddedEvent
    /// Represents a 'parent_issue_removed' event on a given issue.
    | [<CompiledName "PARENT_ISSUE_REMOVED_EVENT">] ParentIssueRemovedEvent

/// The possible target states when updating a pull request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PullRequestUpdateState =
    /// A pull request that is still open.
    | [<CompiledName "OPEN">] Open
    /// A pull request that has been closed without being merged.
    | [<CompiledName "CLOSED">] Closed

/// Emojis that can be attached to Issues, Pull Requests and Comments.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReactionContent =
    /// Represents the `:+1:` emoji.
    | [<CompiledName "THUMBS_UP">] ThumbsUp
    /// Represents the `:-1:` emoji.
    | [<CompiledName "THUMBS_DOWN">] ThumbsDown
    /// Represents the `:laugh:` emoji.
    | [<CompiledName "LAUGH">] Laugh
    /// Represents the `:hooray:` emoji.
    | [<CompiledName "HOORAY">] Hooray
    /// Represents the `:confused:` emoji.
    | [<CompiledName "CONFUSED">] Confused
    /// Represents the `:heart:` emoji.
    | [<CompiledName "HEART">] Heart
    /// Represents the `:rocket:` emoji.
    | [<CompiledName "ROCKET">] Rocket
    /// Represents the `:eyes:` emoji.
    | [<CompiledName "EYES">] Eyes

/// A list of fields that reactions can be ordered by.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReactionOrderField =
    /// Allows ordering a list of reactions by when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which ref connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RefOrderField =
    /// Order refs by underlying commit date if the ref prefix is refs/tags/
    | [<CompiledName "TAG_COMMIT_DATE">] TagCommitDate
    /// Order refs by their alphanumeric name
    | [<CompiledName "ALPHABETICAL">] Alphabetical

/// Properties by which release connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReleaseOrderField =
    /// Order releases by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order releases alphabetically by name
    | [<CompiledName "NAME">] Name

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoAccessAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoAddMemberAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoArchivedAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The merge options available for pull requests to this repository.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoChangeMergeSettingAuditEntryMergeType =
    /// The pull request is added to the base branch in a merge commit.
    | [<CompiledName "MERGE">] Merge
    /// Commits from the pull request are added onto the base branch individually without a merge commit.
    | [<CompiledName "REBASE">] Rebase
    /// The pull request's commits are squashed into a single commit before they are merged to the base branch.
    | [<CompiledName "SQUASH">] Squash

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoCreateAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoDestroyAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepoRemoveMemberAuditEntryVisibility =
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public

/// The reasons a piece of content can be reported or minimized.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReportedContentClassifiers =
    /// A spammy piece of content
    | [<CompiledName "SPAM">] Spam
    /// An abusive or harassing piece of content
    | [<CompiledName "ABUSE">] Abuse
    /// An irrelevant piece of content
    | [<CompiledName "OFF_TOPIC">] OffTopic
    /// An outdated piece of content
    | [<CompiledName "OUTDATED">] Outdated
    /// A duplicated piece of content
    | [<CompiledName "DUPLICATE">] Duplicate
    /// The content has been resolved
    | [<CompiledName "RESOLVED">] Resolved

/// The affiliation of a user to a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryAffiliation =
    /// Repositories that are owned by the authenticated user.
    | [<CompiledName "OWNER">] Owner
    /// Repositories that the user has been added to as a collaborator.
    | [<CompiledName "COLLABORATOR">] Collaborator
    /// Repositories that the user has access to through being a member of an organization. This includes every repository on every team that the user is on.
    | [<CompiledName "ORGANIZATION_MEMBER">] OrganizationMember

/// The reason a repository is listed as 'contributed'.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryContributionType =
    /// Created a commit
    | [<CompiledName "COMMIT">] Commit
    /// Created an issue
    | [<CompiledName "ISSUE">] Issue
    /// Created a pull request
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// Created the repository
    | [<CompiledName "REPOSITORY">] Repository
    /// Reviewed a pull request
    | [<CompiledName "PULL_REQUEST_REVIEW">] PullRequestReview

/// A repository interaction limit.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimit =
    /// Users that have recently created their account will be unable to interact with the repository.
    | [<CompiledName "EXISTING_USERS">] ExistingUsers
    /// Users that have not previously committed to a repository’s default branch will be unable to interact with the repository.
    | [<CompiledName "CONTRIBUTORS_ONLY">] ContributorsOnly
    /// Users that are not collaborators will not be able to interact with the repository.
    | [<CompiledName "COLLABORATORS_ONLY">] CollaboratorsOnly
    /// No interaction limits are enabled.
    | [<CompiledName "NO_LIMIT">] NoLimit

/// The length for a repository interaction limit to be enabled for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimitExpiry =
    /// The interaction limit will expire after 1 day.
    | [<CompiledName "ONE_DAY">] OneDay
    /// The interaction limit will expire after 3 days.
    | [<CompiledName "THREE_DAYS">] ThreeDays
    /// The interaction limit will expire after 1 week.
    | [<CompiledName "ONE_WEEK">] OneWeek
    /// The interaction limit will expire after 1 month.
    | [<CompiledName "ONE_MONTH">] OneMonth
    /// The interaction limit will expire after 6 months.
    | [<CompiledName "SIX_MONTHS">] SixMonths

/// Indicates where an interaction limit is configured.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInteractionLimitOrigin =
    /// A limit that is configured at the repository level.
    | [<CompiledName "REPOSITORY">] Repository
    /// A limit that is configured at the organization level.
    | [<CompiledName "ORGANIZATION">] Organization
    /// A limit that is configured at the user-wide level.
    | [<CompiledName "USER">] User

/// Properties by which repository invitation connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryInvitationOrderField =
    /// Order repository invitations by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible reasons a given repository could be in a locked state.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryLockReason =
    /// The repository is locked due to a move.
    | [<CompiledName "MOVING">] Moving
    /// The repository is locked due to a billing related reason.
    | [<CompiledName "BILLING">] Billing
    /// The repository is locked due to a rename.
    | [<CompiledName "RENAME">] Rename
    /// The repository is locked due to a migration.
    | [<CompiledName "MIGRATING">] Migrating
    /// The repository is locked due to a trade controls related reason.
    | [<CompiledName "TRADE_RESTRICTION">] TradeRestriction
    /// The repository is locked due to an ownership transfer.
    | [<CompiledName "TRANSFERRING_OWNERSHIP">] TransferringOwnership

/// Possible directions in which to order a list of repository migrations when provided an `orderBy` argument.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryMigrationOrderDirection =
    /// Specifies an ascending order for a given `orderBy` argument.
    | [<CompiledName "ASC">] Asc
    /// Specifies a descending order for a given `orderBy` argument.
    | [<CompiledName "DESC">] Desc

/// Properties by which repository migrations can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryMigrationOrderField =
    /// Order mannequins why when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which repository connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryOrderField =
    /// Order repositories by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order repositories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order repositories by push time
    | [<CompiledName "PUSHED_AT">] PushedAt
    /// Order repositories by name
    | [<CompiledName "NAME">] Name
    /// Order repositories by number of stargazers
    | [<CompiledName "STARGAZERS">] Stargazers

/// The access level to a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryPermission =
    /// Can read, clone, and push to this repository. Can also manage issues, pull requests, and repository settings, including adding collaborators
    | [<CompiledName "ADMIN">] Admin
    /// Can read, clone, and push to this repository. They can also manage issues, pull requests, and some repository settings
    | [<CompiledName "MAINTAIN">] Maintain
    /// Can read, clone, and push to this repository. Can also manage issues and pull requests
    | [<CompiledName "WRITE">] Write
    /// Can read and clone this repository. Can also manage issues and pull requests
    | [<CompiledName "TRIAGE">] Triage
    /// Can read and clone this repository. Can also open and comment on issues and pull requests
    | [<CompiledName "READ">] Read

/// The privacy of a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Private
    | [<CompiledName "PRIVATE">] Private

/// Properties by which repository rule connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryRuleOrderField =
    /// Order repository rules by updated time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order repository rules by created time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order repository rules by type
    | [<CompiledName "TYPE">] Type

/// The rule types supported in rulesets
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryRuleType =
    /// Only allow users with bypass permission to create matching refs.
    | [<CompiledName "CREATION">] Creation
    /// Only allow users with bypass permission to update matching refs.
    | [<CompiledName "UPDATE">] Update
    /// Only allow users with bypass permissions to delete matching refs.
    | [<CompiledName "DELETION">] Deletion
    /// Prevent merge commits from being pushed to matching refs.
    | [<CompiledName "REQUIRED_LINEAR_HISTORY">] RequiredLinearHistory
    /// Merges must be performed via a merge queue.
    | [<CompiledName "MERGE_QUEUE">] MergeQueue
    /// When enabled, all conversations on code must be resolved before a pull request can be merged into a branch that matches this rule.
    | [<CompiledName "REQUIRED_REVIEW_THREAD_RESOLUTION">] RequiredReviewThreadResolution
    /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
    | [<CompiledName "REQUIRED_DEPLOYMENTS">] RequiredDeployments
    /// Commits pushed to matching refs must have verified signatures.
    | [<CompiledName "REQUIRED_SIGNATURES">] RequiredSignatures
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    | [<CompiledName "PULL_REQUEST">] PullRequest
    /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
    | [<CompiledName "REQUIRED_STATUS_CHECKS">] RequiredStatusChecks
    /// Require all commits be made to a non-target branch and submitted via a pull request and required workflow checks to pass before they can be merged.
    | [<CompiledName "REQUIRED_WORKFLOW_STATUS_CHECKS">] RequiredWorkflowStatusChecks
    /// Prevent users with push access from force pushing to refs.
    | [<CompiledName "NON_FAST_FORWARD">] NonFastForward
    /// Authorization
    | [<CompiledName "AUTHORIZATION">] Authorization
    /// Tag
    | [<CompiledName "TAG">] Tag
    /// Merge queue locked ref
    | [<CompiledName "MERGE_QUEUE_LOCKED_REF">] MergeQueueLockedRef
    /// Branch is read-only. Users cannot push to the branch.
    | [<CompiledName "LOCK_BRANCH">] LockBranch
    /// Max ref updates
    | [<CompiledName "MAX_REF_UPDATES">] MaxRefUpdates
    /// Commit message pattern
    | [<CompiledName "COMMIT_MESSAGE_PATTERN">] CommitMessagePattern
    /// Commit author email pattern
    | [<CompiledName "COMMIT_AUTHOR_EMAIL_PATTERN">] CommitAuthorEmailPattern
    /// Committer email pattern
    | [<CompiledName "COMMITTER_EMAIL_PATTERN">] CommitterEmailPattern
    /// Branch name pattern
    | [<CompiledName "BRANCH_NAME_PATTERN">] BranchNamePattern
    /// Tag name pattern
    | [<CompiledName "TAG_NAME_PATTERN">] TagNamePattern
    /// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
    | [<CompiledName "FILE_PATH_RESTRICTION">] FilePathRestriction
    /// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
    | [<CompiledName "MAX_FILE_PATH_LENGTH">] MaxFilePathLength
    /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
    | [<CompiledName "FILE_EXTENSION_RESTRICTION">] FileExtensionRestriction
    /// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
    | [<CompiledName "MAX_FILE_SIZE">] MaxFileSize
    /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
    | [<CompiledName "WORKFLOWS">] Workflows
    /// Secret scanning
    | [<CompiledName "SECRET_SCANNING">] SecretScanning
    /// Workflow files cannot be modified.
    | [<CompiledName "WORKFLOW_UPDATES">] WorkflowUpdates
    /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
    | [<CompiledName "CODE_SCANNING">] CodeScanning

/// The bypass mode for a specific actor on a ruleset.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryRulesetBypassActorBypassMode =
    /// The actor can always bypass rules
    | [<CompiledName "ALWAYS">] Always
    /// The actor can only bypass rules via a pull request
    | [<CompiledName "PULL_REQUEST">] PullRequest

/// The targets supported for rulesets.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryRulesetTarget =
    /// Branch
    | [<CompiledName "BRANCH">] Branch
    /// Tag
    | [<CompiledName "TAG">] Tag
    /// Push
    | [<CompiledName "PUSH">] Push
    /// repository
    | [<CompiledName "REPOSITORY">] Repository

/// The possible filters for suggested actors in a repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositorySuggestedActorFilter =
    /// Actors that can be assigned to issues and pull requests
    | [<CompiledName "CAN_BE_ASSIGNED">] CanBeAssigned
    /// Actors that can be the author of issues and pull requests
    | [<CompiledName "CAN_BE_AUTHOR">] CanBeAuthor

/// The repository's visibility level.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryVisibility =
    /// The repository is visible only to those with explicit access.
    | [<CompiledName "PRIVATE">] Private
    /// The repository is visible to everyone.
    | [<CompiledName "PUBLIC">] Public
    /// The repository is visible only to users in the same enterprise.
    | [<CompiledName "INTERNAL">] Internal

/// The possible relationships of an alert's dependency.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryVulnerabilityAlertDependencyRelationship =
    /// The relationship is unknown
    | [<CompiledName "UNKNOWN">] Unknown
    /// A direct dependency of your project
    | [<CompiledName "DIRECT">] Direct
    /// A transitive dependency of your project
    | [<CompiledName "TRANSITIVE">] Transitive

/// The possible scopes of an alert's dependency.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryVulnerabilityAlertDependencyScope =
    /// A dependency that is leveraged during application runtime
    | [<CompiledName "RUNTIME">] Runtime
    /// A dependency that is only used in development
    | [<CompiledName "DEVELOPMENT">] Development

/// The possible states of an alert
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RepositoryVulnerabilityAlertState =
    /// An alert that is still open.
    | [<CompiledName "OPEN">] Open
    /// An alert that has been resolved by a code change.
    | [<CompiledName "FIXED">] Fixed
    /// An alert that has been manually closed by a user.
    | [<CompiledName "DISMISSED">] Dismissed
    /// An alert that has been automatically closed by Dependabot.
    | [<CompiledName "AUTO_DISMISSED">] AutoDismissed

/// The possible states that can be requested when creating a check run.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RequestableCheckStatusState =
    /// The check suite or run has been queued.
    | [<CompiledName "QUEUED">] Queued
    /// The check suite or run is in progress.
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The check suite or run has been completed.
    | [<CompiledName "COMPLETED">] Completed
    /// The check suite or run is in waiting state.
    | [<CompiledName "WAITING">] Waiting
    /// The check suite or run is in pending state.
    | [<CompiledName "PENDING">] Pending

/// Possible roles a user may have in relation to an organization.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RoleInOrganization =
    /// A user with full administrative access to the organization.
    | [<CompiledName "OWNER">] Owner
    /// A user who is a direct member of the organization.
    | [<CompiledName "DIRECT_MEMBER">] DirectMember
    /// A user who is unaffiliated with the organization.
    | [<CompiledName "UNAFFILIATED">] Unaffiliated

/// The level of enforcement for a rule or ruleset.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RuleEnforcement =
    /// Do not evaluate or enforce rules
    | [<CompiledName "DISABLED">] Disabled
    /// Rules will be enforced
    | [<CompiledName "ACTIVE">] Active
    /// Allow admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    | [<CompiledName "EVALUATE">] Evaluate

/// The possible digest algorithms used to sign SAML requests for an identity provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SamlDigestAlgorithm =
    /// SHA1
    | [<CompiledName "SHA1">] Sha1
    /// SHA256
    | [<CompiledName "SHA256">] Sha256
    /// SHA384
    | [<CompiledName "SHA384">] Sha384
    /// SHA512
    | [<CompiledName "SHA512">] Sha512

/// The possible signature algorithms used to sign SAML requests for a Identity Provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SamlSignatureAlgorithm =
    /// RSA-SHA1
    | [<CompiledName "RSA_SHA1">] RsaSha1
    /// RSA-SHA256
    | [<CompiledName "RSA_SHA256">] RsaSha256
    /// RSA-SHA384
    | [<CompiledName "RSA_SHA384">] RsaSha384
    /// RSA-SHA512
    | [<CompiledName "RSA_SHA512">] RsaSha512

/// Properties by which saved reply connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SavedReplyOrderField =
    /// Order saved reply by when they were updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// Represents the individual results of a search.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SearchType =
    /// Returns results matching issues in repositories.
    | [<CompiledName "ISSUE">] Issue
    /// Returns results matching repositories.
    | [<CompiledName "REPOSITORY">] Repository
    /// Returns results matching users and organizations on GitHub.
    | [<CompiledName "USER">] User
    /// Returns matching discussions in repositories.
    | [<CompiledName "DISCUSSION">] Discussion

/// Classification of the advisory.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryClassification =
    /// Classification of general advisories.
    | [<CompiledName "GENERAL">] General
    /// Classification of malware advisories.
    | [<CompiledName "MALWARE">] Malware

/// The possible ecosystems of a security vulnerability's package.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryEcosystem =
    /// PHP packages hosted at packagist.org
    | [<CompiledName "COMPOSER">] Composer
    /// Erlang/Elixir packages hosted at hex.pm
    | [<CompiledName "ERLANG">] Erlang
    /// GitHub Actions
    | [<CompiledName "ACTIONS">] Actions
    /// Go modules
    | [<CompiledName "GO">] Go
    /// Java artifacts hosted at the Maven central repository
    | [<CompiledName "MAVEN">] Maven
    /// JavaScript packages hosted at npmjs.com
    | [<CompiledName "NPM">] Npm
    /// .NET packages hosted at the NuGet Gallery
    | [<CompiledName "NUGET">] Nuget
    /// Python packages hosted at PyPI.org
    | [<CompiledName "PIP">] Pip
    /// Dart packages hosted at pub.dev
    | [<CompiledName "PUB">] Pub
    /// Ruby gems hosted at RubyGems.org
    | [<CompiledName "RUBYGEMS">] Rubygems
    /// Rust crates
    | [<CompiledName "RUST">] Rust
    /// Swift packages
    | [<CompiledName "SWIFT">] Swift

/// Identifier formats available for advisories.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryIdentifierType =
    /// Common Vulnerabilities and Exposures Identifier.
    | [<CompiledName "CVE">] Cve
    /// GitHub Security Advisory ID.
    | [<CompiledName "GHSA">] Ghsa

/// Properties by which security advisory connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisoryOrderField =
    /// Order advisories by publication time
    | [<CompiledName "PUBLISHED_AT">] PublishedAt
    /// Order advisories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order advisories by EPSS percentage
    | [<CompiledName "EPSS_PERCENTAGE">] EpssPercentage
    /// Order advisories by EPSS percentile
    | [<CompiledName "EPSS_PERCENTILE">] EpssPercentile

/// Severity of the vulnerability.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAdvisorySeverity =
    /// Low.
    | [<CompiledName "LOW">] Low
    /// Moderate.
    | [<CompiledName "MODERATE">] Moderate
    /// High.
    | [<CompiledName "HIGH">] High
    /// Critical.
    | [<CompiledName "CRITICAL">] Critical

/// Properties by which security vulnerability connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityVulnerabilityOrderField =
    /// Order vulnerability by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// Software or company that hosts social media accounts.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SocialAccountProvider =
    /// Catch-all for social media providers that do not yet have specific handling.
    | [<CompiledName "GENERIC">] Generic
    /// Social media and networking website.
    | [<CompiledName "FACEBOOK">] Facebook
    /// Fork of Mastodon with a greater focus on local posting.
    | [<CompiledName "HOMETOWN">] Hometown
    /// Social media website with a focus on photo and video sharing.
    | [<CompiledName "INSTAGRAM">] Instagram
    /// Professional networking website.
    | [<CompiledName "LINKEDIN">] Linkedin
    /// Open-source federated microblogging service.
    | [<CompiledName "MASTODON">] Mastodon
    /// Social news aggregation and discussion website.
    | [<CompiledName "REDDIT">] Reddit
    /// Live-streaming service.
    | [<CompiledName "TWITCH">] Twitch
    /// Microblogging website.
    | [<CompiledName "TWITTER">] Twitter
    /// Online video platform.
    | [<CompiledName "YOUTUBE">] Youtube
    /// Decentralized microblogging social platform.
    | [<CompiledName "BLUESKY">] Bluesky
    /// JavaScript package registry.
    | [<CompiledName "NPM">] Npm

/// Properties by which sponsor and lifetime value connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorAndLifetimeValueOrderField =
    /// Order results by the sponsor's login (username).
    | [<CompiledName "SPONSOR_LOGIN">] SponsorLogin
    /// Order results by the sponsor's relevance to the viewer.
    | [<CompiledName "SPONSOR_RELEVANCE">] SponsorRelevance
    /// Order results by how much money the sponsor has paid in total.
    | [<CompiledName "LIFETIME_VALUE">] LifetimeValue

/// Properties by which sponsor connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorOrderField =
    /// Order sponsorable entities by login (username).
    | [<CompiledName "LOGIN">] Login
    /// Order sponsors by their relevance to the viewer.
    | [<CompiledName "RELEVANCE">] Relevance

/// Properties by which sponsorable connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorableOrderField =
    /// Order sponsorable entities by login (username).
    | [<CompiledName "LOGIN">] Login

/// The possible actions that GitHub Sponsors activities can represent.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsActivityAction =
    /// The activity was starting a sponsorship.
    | [<CompiledName "NEW_SPONSORSHIP">] NewSponsorship
    /// The activity was cancelling a sponsorship.
    | [<CompiledName "CANCELLED_SPONSORSHIP">] CancelledSponsorship
    /// The activity was changing the sponsorship tier, either directly by the sponsor or by a scheduled/pending change.
    | [<CompiledName "TIER_CHANGE">] TierChange
    /// The activity was funds being refunded to the sponsor or GitHub.
    | [<CompiledName "REFUND">] Refund
    /// The activity was scheduling a downgrade or cancellation.
    | [<CompiledName "PENDING_CHANGE">] PendingChange
    /// The activity was disabling matching for a previously matched sponsorship.
    | [<CompiledName "SPONSOR_MATCH_DISABLED">] SponsorMatchDisabled

/// Properties by which GitHub Sponsors activity connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsActivityOrderField =
    /// Order activities by when they happened.
    | [<CompiledName "TIMESTAMP">] Timestamp

/// The possible time periods for which Sponsors activities can be requested.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsActivityPeriod =
    /// The previous calendar day.
    | [<CompiledName "DAY">] Day
    /// The previous seven days.
    | [<CompiledName "WEEK">] Week
    /// The previous thirty days.
    | [<CompiledName "MONTH">] Month
    /// Don't restrict the activity to any date range, include all activity.
    | [<CompiledName "ALL">] All

/// Represents countries or regions for billing and residence for a GitHub Sponsors profile.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsCountryOrRegionCode =
    /// Afghanistan
    | [<CompiledName "AF">] Af
    /// Åland
    | [<CompiledName "AX">] Ax
    /// Albania
    | [<CompiledName "AL">] Al
    /// Algeria
    | [<CompiledName "DZ">] Dz
    /// American Samoa
    | [<CompiledName "AS">] As
    /// Andorra
    | [<CompiledName "AD">] Ad
    /// Angola
    | [<CompiledName "AO">] Ao
    /// Anguilla
    | [<CompiledName "AI">] Ai
    /// Antarctica
    | [<CompiledName "AQ">] Aq
    /// Antigua and Barbuda
    | [<CompiledName "AG">] Ag
    /// Argentina
    | [<CompiledName "AR">] Ar
    /// Armenia
    | [<CompiledName "AM">] Am
    /// Aruba
    | [<CompiledName "AW">] Aw
    /// Australia
    | [<CompiledName "AU">] Au
    /// Austria
    | [<CompiledName "AT">] At
    /// Azerbaijan
    | [<CompiledName "AZ">] Az
    /// Bahamas
    | [<CompiledName "BS">] Bs
    /// Bahrain
    | [<CompiledName "BH">] Bh
    /// Bangladesh
    | [<CompiledName "BD">] Bd
    /// Barbados
    | [<CompiledName "BB">] Bb
    /// Belarus
    | [<CompiledName "BY">] By
    /// Belgium
    | [<CompiledName "BE">] Be
    /// Belize
    | [<CompiledName "BZ">] Bz
    /// Benin
    | [<CompiledName "BJ">] Bj
    /// Bermuda
    | [<CompiledName "BM">] Bm
    /// Bhutan
    | [<CompiledName "BT">] Bt
    /// Bolivia
    | [<CompiledName "BO">] Bo
    /// Bonaire, Sint Eustatius and Saba
    | [<CompiledName "BQ">] Bq
    /// Bosnia and Herzegovina
    | [<CompiledName "BA">] Ba
    /// Botswana
    | [<CompiledName "BW">] Bw
    /// Bouvet Island
    | [<CompiledName "BV">] Bv
    /// Brazil
    | [<CompiledName "BR">] Br
    /// British Indian Ocean Territory
    | [<CompiledName "IO">] Io
    /// Brunei Darussalam
    | [<CompiledName "BN">] Bn
    /// Bulgaria
    | [<CompiledName "BG">] Bg
    /// Burkina Faso
    | [<CompiledName "BF">] Bf
    /// Burundi
    | [<CompiledName "BI">] Bi
    /// Cambodia
    | [<CompiledName "KH">] Kh
    /// Cameroon
    | [<CompiledName "CM">] Cm
    /// Canada
    | [<CompiledName "CA">] Ca
    /// Cape Verde
    | [<CompiledName "CV">] Cv
    /// Cayman Islands
    | [<CompiledName "KY">] Ky
    /// Central African Republic
    | [<CompiledName "CF">] Cf
    /// Chad
    | [<CompiledName "TD">] Td
    /// Chile
    | [<CompiledName "CL">] Cl
    /// China
    | [<CompiledName "CN">] Cn
    /// Christmas Island
    | [<CompiledName "CX">] Cx
    /// Cocos (Keeling) Islands
    | [<CompiledName "CC">] Cc
    /// Colombia
    | [<CompiledName "CO">] Co
    /// Comoros
    | [<CompiledName "KM">] Km
    /// Congo (Brazzaville)
    | [<CompiledName "CG">] Cg
    /// Congo (Kinshasa)
    | [<CompiledName "CD">] Cd
    /// Cook Islands
    | [<CompiledName "CK">] Ck
    /// Costa Rica
    | [<CompiledName "CR">] Cr
    /// Côte d'Ivoire
    | [<CompiledName "CI">] Ci
    /// Croatia
    | [<CompiledName "HR">] Hr
    /// Curaçao
    | [<CompiledName "CW">] Cw
    /// Cyprus
    | [<CompiledName "CY">] Cy
    /// Czech Republic
    | [<CompiledName "CZ">] Cz
    /// Denmark
    | [<CompiledName "DK">] Dk
    /// Djibouti
    | [<CompiledName "DJ">] Dj
    /// Dominica
    | [<CompiledName "DM">] Dm
    /// Dominican Republic
    | [<CompiledName "DO">] Do
    /// Ecuador
    | [<CompiledName "EC">] Ec
    /// Egypt
    | [<CompiledName "EG">] Eg
    /// El Salvador
    | [<CompiledName "SV">] Sv
    /// Equatorial Guinea
    | [<CompiledName "GQ">] Gq
    /// Eritrea
    | [<CompiledName "ER">] Er
    /// Estonia
    | [<CompiledName "EE">] Ee
    /// Ethiopia
    | [<CompiledName "ET">] Et
    /// Falkland Islands
    | [<CompiledName "FK">] Fk
    /// Faroe Islands
    | [<CompiledName "FO">] Fo
    /// Fiji
    | [<CompiledName "FJ">] Fj
    /// Finland
    | [<CompiledName "FI">] Fi
    /// France
    | [<CompiledName "FR">] Fr
    /// French Guiana
    | [<CompiledName "GF">] Gf
    /// French Polynesia
    | [<CompiledName "PF">] Pf
    /// French Southern Lands
    | [<CompiledName "TF">] Tf
    /// Gabon
    | [<CompiledName "GA">] Ga
    /// Gambia
    | [<CompiledName "GM">] Gm
    /// Georgia
    | [<CompiledName "GE">] Ge
    /// Germany
    | [<CompiledName "DE">] De
    /// Ghana
    | [<CompiledName "GH">] Gh
    /// Gibraltar
    | [<CompiledName "GI">] Gi
    /// Greece
    | [<CompiledName "GR">] Gr
    /// Greenland
    | [<CompiledName "GL">] Gl
    /// Grenada
    | [<CompiledName "GD">] Gd
    /// Guadeloupe
    | [<CompiledName "GP">] Gp
    /// Guam
    | [<CompiledName "GU">] Gu
    /// Guatemala
    | [<CompiledName "GT">] Gt
    /// Guernsey
    | [<CompiledName "GG">] Gg
    /// Guinea
    | [<CompiledName "GN">] Gn
    /// Guinea-Bissau
    | [<CompiledName "GW">] Gw
    /// Guyana
    | [<CompiledName "GY">] Gy
    /// Haiti
    | [<CompiledName "HT">] Ht
    /// Heard and McDonald Islands
    | [<CompiledName "HM">] Hm
    /// Honduras
    | [<CompiledName "HN">] Hn
    /// Hong Kong
    | [<CompiledName "HK">] Hk
    /// Hungary
    | [<CompiledName "HU">] Hu
    /// Iceland
    | [<CompiledName "IS">] Is
    /// India
    | [<CompiledName "IN">] In
    /// Indonesia
    | [<CompiledName "ID">] Id
    /// Iran
    | [<CompiledName "IR">] Ir
    /// Iraq
    | [<CompiledName "IQ">] Iq
    /// Ireland
    | [<CompiledName "IE">] Ie
    /// Isle of Man
    | [<CompiledName "IM">] Im
    /// Israel
    | [<CompiledName "IL">] Il
    /// Italy
    | [<CompiledName "IT">] It
    /// Jamaica
    | [<CompiledName "JM">] Jm
    /// Japan
    | [<CompiledName "JP">] Jp
    /// Jersey
    | [<CompiledName "JE">] Je
    /// Jordan
    | [<CompiledName "JO">] Jo
    /// Kazakhstan
    | [<CompiledName "KZ">] Kz
    /// Kenya
    | [<CompiledName "KE">] Ke
    /// Kiribati
    | [<CompiledName "KI">] Ki
    /// Korea, South
    | [<CompiledName "KR">] Kr
    /// Kuwait
    | [<CompiledName "KW">] Kw
    /// Kyrgyzstan
    | [<CompiledName "KG">] Kg
    /// Laos
    | [<CompiledName "LA">] La
    /// Latvia
    | [<CompiledName "LV">] Lv
    /// Lebanon
    | [<CompiledName "LB">] Lb
    /// Lesotho
    | [<CompiledName "LS">] Ls
    /// Liberia
    | [<CompiledName "LR">] Lr
    /// Libya
    | [<CompiledName "LY">] Ly
    /// Liechtenstein
    | [<CompiledName "LI">] Li
    /// Lithuania
    | [<CompiledName "LT">] Lt
    /// Luxembourg
    | [<CompiledName "LU">] Lu
    /// Macau
    | [<CompiledName "MO">] Mo
    /// Macedonia
    | [<CompiledName "MK">] Mk
    /// Madagascar
    | [<CompiledName "MG">] Mg
    /// Malawi
    | [<CompiledName "MW">] Mw
    /// Malaysia
    | [<CompiledName "MY">] My
    /// Maldives
    | [<CompiledName "MV">] Mv
    /// Mali
    | [<CompiledName "ML">] Ml
    /// Malta
    | [<CompiledName "MT">] Mt
    /// Marshall Islands
    | [<CompiledName "MH">] Mh
    /// Martinique
    | [<CompiledName "MQ">] Mq
    /// Mauritania
    | [<CompiledName "MR">] Mr
    /// Mauritius
    | [<CompiledName "MU">] Mu
    /// Mayotte
    | [<CompiledName "YT">] Yt
    /// Mexico
    | [<CompiledName "MX">] Mx
    /// Micronesia
    | [<CompiledName "FM">] Fm
    /// Moldova
    | [<CompiledName "MD">] Md
    /// Monaco
    | [<CompiledName "MC">] Mc
    /// Mongolia
    | [<CompiledName "MN">] Mn
    /// Montenegro
    | [<CompiledName "ME">] Me
    /// Montserrat
    | [<CompiledName "MS">] Ms
    /// Morocco
    | [<CompiledName "MA">] Ma
    /// Mozambique
    | [<CompiledName "MZ">] Mz
    /// Myanmar
    | [<CompiledName "MM">] Mm
    /// Namibia
    | [<CompiledName "NA">] Na
    /// Nauru
    | [<CompiledName "NR">] Nr
    /// Nepal
    | [<CompiledName "NP">] Np
    /// Netherlands
    | [<CompiledName "NL">] Nl
    /// New Caledonia
    | [<CompiledName "NC">] Nc
    /// New Zealand
    | [<CompiledName "NZ">] Nz
    /// Nicaragua
    | [<CompiledName "NI">] Ni
    /// Niger
    | [<CompiledName "NE">] Ne
    /// Nigeria
    | [<CompiledName "NG">] Ng
    /// Niue
    | [<CompiledName "NU">] Nu
    /// Norfolk Island
    | [<CompiledName "NF">] Nf
    /// Northern Mariana Islands
    | [<CompiledName "MP">] Mp
    /// Norway
    | [<CompiledName "NO">] No
    /// Oman
    | [<CompiledName "OM">] Om
    /// Pakistan
    | [<CompiledName "PK">] Pk
    /// Palau
    | [<CompiledName "PW">] Pw
    /// Palestine
    | [<CompiledName "PS">] Ps
    /// Panama
    | [<CompiledName "PA">] Pa
    /// Papua New Guinea
    | [<CompiledName "PG">] Pg
    /// Paraguay
    | [<CompiledName "PY">] Py
    /// Peru
    | [<CompiledName "PE">] Pe
    /// Philippines
    | [<CompiledName "PH">] Ph
    /// Pitcairn
    | [<CompiledName "PN">] Pn
    /// Poland
    | [<CompiledName "PL">] Pl
    /// Portugal
    | [<CompiledName "PT">] Pt
    /// Puerto Rico
    | [<CompiledName "PR">] Pr
    /// Qatar
    | [<CompiledName "QA">] Qa
    /// Reunion
    | [<CompiledName "RE">] Re
    /// Romania
    | [<CompiledName "RO">] Ro
    /// Russian Federation
    | [<CompiledName "RU">] Ru
    /// Rwanda
    | [<CompiledName "RW">] Rw
    /// Saint Barthélemy
    | [<CompiledName "BL">] Bl
    /// Saint Helena
    | [<CompiledName "SH">] Sh
    /// Saint Kitts and Nevis
    | [<CompiledName "KN">] Kn
    /// Saint Lucia
    | [<CompiledName "LC">] Lc
    /// Saint Martin (French part)
    | [<CompiledName "MF">] Mf
    /// Saint Pierre and Miquelon
    | [<CompiledName "PM">] Pm
    /// Saint Vincent and the Grenadines
    | [<CompiledName "VC">] Vc
    /// Samoa
    | [<CompiledName "WS">] Ws
    /// San Marino
    | [<CompiledName "SM">] Sm
    /// Sao Tome and Principe
    | [<CompiledName "ST">] St
    /// Saudi Arabia
    | [<CompiledName "SA">] Sa
    /// Senegal
    | [<CompiledName "SN">] Sn
    /// Serbia
    | [<CompiledName "RS">] Rs
    /// Seychelles
    | [<CompiledName "SC">] Sc
    /// Sierra Leone
    | [<CompiledName "SL">] Sl
    /// Singapore
    | [<CompiledName "SG">] Sg
    /// Sint Maarten (Dutch part)
    | [<CompiledName "SX">] Sx
    /// Slovakia
    | [<CompiledName "SK">] Sk
    /// Slovenia
    | [<CompiledName "SI">] Si
    /// Solomon Islands
    | [<CompiledName "SB">] Sb
    /// Somalia
    | [<CompiledName "SO">] So
    /// South Africa
    | [<CompiledName "ZA">] Za
    /// South Georgia and South Sandwich Islands
    | [<CompiledName "GS">] Gs
    /// South Sudan
    | [<CompiledName "SS">] Ss
    /// Spain
    | [<CompiledName "ES">] Es
    /// Sri Lanka
    | [<CompiledName "LK">] Lk
    /// Sudan
    | [<CompiledName "SD">] Sd
    /// Suriname
    | [<CompiledName "SR">] Sr
    /// Svalbard and Jan Mayen Islands
    | [<CompiledName "SJ">] Sj
    /// Swaziland
    | [<CompiledName "SZ">] Sz
    /// Sweden
    | [<CompiledName "SE">] Se
    /// Switzerland
    | [<CompiledName "CH">] Ch
    /// Taiwan
    | [<CompiledName "TW">] Tw
    /// Tajikistan
    | [<CompiledName "TJ">] Tj
    /// Tanzania
    | [<CompiledName "TZ">] Tz
    /// Thailand
    | [<CompiledName "TH">] Th
    /// Timor-Leste
    | [<CompiledName "TL">] Tl
    /// Togo
    | [<CompiledName "TG">] Tg
    /// Tokelau
    | [<CompiledName "TK">] Tk
    /// Tonga
    | [<CompiledName "TO">] To
    /// Trinidad and Tobago
    | [<CompiledName "TT">] Tt
    /// Tunisia
    | [<CompiledName "TN">] Tn
    /// Türkiye
    | [<CompiledName "TR">] Tr
    /// Turkmenistan
    | [<CompiledName "TM">] Tm
    /// Turks and Caicos Islands
    | [<CompiledName "TC">] Tc
    /// Tuvalu
    | [<CompiledName "TV">] Tv
    /// Uganda
    | [<CompiledName "UG">] Ug
    /// Ukraine
    | [<CompiledName "UA">] Ua
    /// United Arab Emirates
    | [<CompiledName "AE">] Ae
    /// United Kingdom
    | [<CompiledName "GB">] Gb
    /// United States Minor Outlying Islands
    | [<CompiledName "UM">] Um
    /// United States of America
    | [<CompiledName "US">] Us
    /// Uruguay
    | [<CompiledName "UY">] Uy
    /// Uzbekistan
    | [<CompiledName "UZ">] Uz
    /// Vanuatu
    | [<CompiledName "VU">] Vu
    /// Vatican City
    | [<CompiledName "VA">] Va
    /// Venezuela
    | [<CompiledName "VE">] Ve
    /// Vietnam
    | [<CompiledName "VN">] Vn
    /// Virgin Islands, British
    | [<CompiledName "VG">] Vg
    /// Virgin Islands, U.S.
    | [<CompiledName "VI">] Vi
    /// Wallis and Futuna Islands
    | [<CompiledName "WF">] Wf
    /// Western Sahara
    | [<CompiledName "EH">] Eh
    /// Yemen
    | [<CompiledName "YE">] Ye
    /// Zambia
    | [<CompiledName "ZM">] Zm
    /// Zimbabwe
    | [<CompiledName "ZW">] Zw

/// The different kinds of goals a GitHub Sponsors member can have.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsGoalKind =
    /// The goal is about reaching a certain number of sponsors.
    | [<CompiledName "TOTAL_SPONSORS_COUNT">] TotalSponsorsCount
    /// The goal is about getting a certain amount in USD from sponsorships each month.
    | [<CompiledName "MONTHLY_SPONSORSHIP_AMOUNT">] MonthlySponsorshipAmount

/// The different kinds of records that can be featured on a GitHub Sponsors profile page.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsListingFeaturedItemFeatureableType =
    /// A repository owned by the user or organization with the GitHub Sponsors profile.
    | [<CompiledName "REPOSITORY">] Repository
    /// A user who belongs to the organization with the GitHub Sponsors profile.
    | [<CompiledName "USER">] User

/// Properties by which Sponsors tiers connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorsTierOrderField =
    /// Order tiers by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order tiers by their monthly price in cents
    | [<CompiledName "MONTHLY_PRICE_IN_CENTS">] MonthlyPriceInCents

/// Properties by which sponsorship update connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipNewsletterOrderField =
    /// Order sponsorship newsletters by when they were created.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which sponsorship connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipOrderField =
    /// Order sponsorship by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// How payment was made for funding a GitHub Sponsors sponsorship.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipPaymentSource =
    /// Payment was made through GitHub.
    | [<CompiledName "GITHUB">] Github
    /// Payment was made through Patreon.
    | [<CompiledName "PATREON">] Patreon

/// The privacy of a sponsorship
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SponsorshipPrivacy =
    /// Public
    | [<CompiledName "PUBLIC">] Public
    /// Private
    | [<CompiledName "PRIVATE">] Private

/// The possible default commit messages for squash merges.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SquashMergeCommitMessage =
    /// Default to the pull request's body.
    | [<CompiledName "PR_BODY">] PrBody
    /// Default to the branch's commit messages.
    | [<CompiledName "COMMIT_MESSAGES">] CommitMessages
    /// Default to a blank commit message.
    | [<CompiledName "BLANK">] Blank

/// The possible default commit titles for squash merges.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SquashMergeCommitTitle =
    /// Default to the pull request's title.
    | [<CompiledName "PR_TITLE">] PrTitle
    /// Default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    | [<CompiledName "COMMIT_OR_PR_TITLE">] CommitOrPrTitle

/// Properties by which star connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type StarOrderField =
    /// Allows ordering a list of stars by when they were created.
    | [<CompiledName "STARRED_AT">] StarredAt

/// The possible commit status states.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type StatusState =
    /// Status is expected.
    | [<CompiledName "EXPECTED">] Expected
    /// Status is errored.
    | [<CompiledName "ERROR">] Error
    /// Status is failing.
    | [<CompiledName "FAILURE">] Failure
    /// Status is pending.
    | [<CompiledName "PENDING">] Pending
    /// Status is successful.
    | [<CompiledName "SUCCESS">] Success

/// The possible states of a subscription.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SubscriptionState =
    /// The User is only notified when participating or @mentioned.
    | [<CompiledName "UNSUBSCRIBED">] Unsubscribed
    /// The User is notified of all conversations.
    | [<CompiledName "SUBSCRIBED">] Subscribed
    /// The User is never notified.
    | [<CompiledName "IGNORED">] Ignored

/// Properties by which team discussion comment connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamDiscussionCommentOrderField =
    /// Allows sequential ordering of team discussion comments (which is equivalent to chronological ordering).
    | [<CompiledName "NUMBER">] Number

/// Properties by which team discussion connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamDiscussionOrderField =
    /// Allows chronological ordering of team discussions.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which team member connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMemberOrderField =
    /// Order team members by login
    | [<CompiledName "LOGIN">] Login
    /// Order team members by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible team member roles; either 'maintainer' or 'member'.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMemberRole =
    /// A team maintainer has permission to add and remove team members.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// A team member has no administrative permissions on the team.
    | [<CompiledName "MEMBER">] Member

/// Defines which types of team members are included in the returned list. Can be one of IMMEDIATE, CHILD_TEAM or ALL.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamMembershipType =
    /// Includes only immediate members of the team.
    | [<CompiledName "IMMEDIATE">] Immediate
    /// Includes only child team members for the team.
    | [<CompiledName "CHILD_TEAM">] ChildTeam
    /// Includes immediate and child team members for the team.
    | [<CompiledName "ALL">] All

/// The possible team notification values.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamNotificationSetting =
    /// Everyone will receive notifications when the team is @mentioned.
    | [<CompiledName "NOTIFICATIONS_ENABLED">] NotificationsEnabled
    /// No one will receive notifications.
    | [<CompiledName "NOTIFICATIONS_DISABLED">] NotificationsDisabled

/// Properties by which team connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamOrderField =
    /// Allows ordering a list of teams by name.
    | [<CompiledName "NAME">] Name

/// The possible team privacy values.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamPrivacy =
    /// A secret team can only be seen by its members.
    | [<CompiledName "SECRET">] Secret
    /// A visible team can be seen and @mentioned by every member of the organization.
    | [<CompiledName "VISIBLE">] Visible

/// Properties by which team repository connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamRepositoryOrderField =
    /// Order repositories by creation time
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Order repositories by update time
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Order repositories by push time
    | [<CompiledName "PUSHED_AT">] PushedAt
    /// Order repositories by name
    | [<CompiledName "NAME">] Name
    /// Order repositories by permission
    | [<CompiledName "PERMISSION">] Permission
    /// Order repositories by number of stargazers
    | [<CompiledName "STARGAZERS">] Stargazers

/// The possible team review assignment algorithms
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamReviewAssignmentAlgorithm =
    /// Alternate reviews between each team member
    | [<CompiledName "ROUND_ROBIN">] RoundRobin
    /// Balance review load across the entire team
    | [<CompiledName "LOAD_BALANCE">] LoadBalance

/// The role of a user on a team.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TeamRole =
    /// User has admin rights on the team.
    | [<CompiledName "ADMIN">] Admin
    /// User is a member of the team.
    | [<CompiledName "MEMBER">] Member

/// The possible states of a thread subscription form action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ThreadSubscriptionFormAction =
    /// The User cannot subscribe or unsubscribe to the thread
    | [<CompiledName "NONE">] None
    /// The User can subscribe to the thread
    | [<CompiledName "SUBSCRIBE">] Subscribe
    /// The User can unsubscribe to the thread
    | [<CompiledName "UNSUBSCRIBE">] Unsubscribe

/// The possible states of a subscription.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ThreadSubscriptionState =
    /// The subscription status is currently unavailable.
    | [<CompiledName "UNAVAILABLE">] Unavailable
    /// The subscription status is currently disabled.
    | [<CompiledName "DISABLED">] Disabled
    /// The User is never notified because they are ignoring the list
    | [<CompiledName "IGNORING_LIST">] IgnoringList
    /// The User is notified because they chose custom settings for this thread.
    | [<CompiledName "SUBSCRIBED_TO_THREAD_EVENTS">] SubscribedToThreadEvents
    /// The User is never notified because they are ignoring the thread
    | [<CompiledName "IGNORING_THREAD">] IgnoringThread
    /// The User is notified becuase they are watching the list
    | [<CompiledName "SUBSCRIBED_TO_LIST">] SubscribedToList
    /// The User is notified because they chose custom settings for this thread.
    | [<CompiledName "SUBSCRIBED_TO_THREAD_TYPE">] SubscribedToThreadType
    /// The User is notified because they are subscribed to the thread
    | [<CompiledName "SUBSCRIBED_TO_THREAD">] SubscribedToThread
    /// The User is not recieving notifications from this thread
    | [<CompiledName "NONE">] None

/// The possible states of a tracked issue.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TrackedIssueStates =
    /// The tracked issue is open
    | [<CompiledName "OPEN">] Open
    /// The tracked issue is closed
    | [<CompiledName "CLOSED">] Closed

/// Filters by whether or not 2FA is enabled and if the method configured is considered secure or insecure.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TwoFactorCredentialSecurityType =
    /// Has only secure methods of two-factor authentication.
    | [<CompiledName "SECURE">] Secure
    /// Has an insecure method of two-factor authentication. GitHub currently defines this as SMS two-factor authentication.
    | [<CompiledName "INSECURE">] Insecure
    /// No method of two-factor authentication.
    | [<CompiledName "DISABLED">] Disabled

/// The possible durations that a user can be blocked for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserBlockDuration =
    /// The user was blocked for 1 day
    | [<CompiledName "ONE_DAY">] OneDay
    /// The user was blocked for 3 days
    | [<CompiledName "THREE_DAYS">] ThreeDays
    /// The user was blocked for 7 days
    | [<CompiledName "ONE_WEEK">] OneWeek
    /// The user was blocked for 30 days
    | [<CompiledName "ONE_MONTH">] OneMonth
    /// The user was blocked permanently
    | [<CompiledName "PERMANENT">] Permanent

/// Properties by which user status connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserStatusOrderField =
    /// Order user statuses by when they were updated.
    | [<CompiledName "UPDATED_AT">] UpdatedAt

/// Whether a user being viewed contains public or private information.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserViewType =
    /// A user that is publicly visible.
    | [<CompiledName "PUBLIC">] Public
    /// A user containing information only visible to the authenticated user.
    | [<CompiledName "PRIVATE">] Private

/// Properties by which verifiable domain connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VerifiableDomainOrderField =
    /// Order verifiable domains by the domain name.
    | [<CompiledName "DOMAIN">] Domain
    /// Order verifiable domains by their creation date.
    | [<CompiledName "CREATED_AT">] CreatedAt

/// Properties by which workflow run connections can be ordered.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkflowRunOrderField =
    /// Order workflow runs by most recently created
    | [<CompiledName "CREATED_AT">] CreatedAt

/// The possible states for a workflow.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkflowState =
    /// The workflow is active.
    | [<CompiledName "ACTIVE">] Active
    /// The workflow was deleted from the git repository.
    | [<CompiledName "DELETED">] Deleted
    /// The workflow was disabled by default on a fork.
    | [<CompiledName "DISABLED_FORK">] DisabledFork
    /// The workflow was disabled for inactivity in the repository.
    | [<CompiledName "DISABLED_INACTIVITY">] DisabledInactivity
    /// The workflow was disabled manually.
    | [<CompiledName "DISABLED_MANUALLY">] DisabledManually

/// Autogenerated input type of AbortQueuedMigrations
type AbortQueuedMigrationsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization that is running the migrations.
        ownerId: string
    }

/// Autogenerated input type of AbortRepositoryMigration
type AbortRepositoryMigrationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the migration to be aborted.
        migrationId: string
    }

/// Autogenerated input type of AcceptEnterpriseAdministratorInvitation
type AcceptEnterpriseAdministratorInvitationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the invitation being accepted
        invitationId: string
    }

/// Autogenerated input type of AcceptEnterpriseMemberInvitation
type AcceptEnterpriseMemberInvitationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the invitation being accepted
        invitationId: string
    }

/// Autogenerated input type of AcceptTopicSuggestion
type AcceptTopicSuggestionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.**Upcoming Change on 2024-04-01 UTC****Description:** `repositoryId` will be removed.**Reason:** Suggested topics are no longer supported
        repositoryId: Option<string>
        /// The name of the suggested topic.**Upcoming Change on 2024-04-01 UTC****Description:** `name` will be removed.**Reason:** Suggested topics are no longer supported
        name: Option<string>
    }

/// Autogenerated input type of AccessUserNamespaceRepository
type AccessUserNamespaceRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise owning the user namespace repository.
        enterpriseId: string
        /// The ID of the user namespace repository to access.
        repositoryId: string
    }

/// Autogenerated input type of AddAssigneesToAssignable
type AddAssigneesToAssignableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the assignable object to add assignees to.
        assignableId: string
        /// The id of users to add as assignees.
        assigneeIds: list<string>
    }

/// Autogenerated input type of AddComment
type AddCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subject to modify.
        subjectId: string
        /// The contents of the comment.
        body: string
    }

/// Autogenerated input type of AddDiscussionComment
type AddDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion to comment on.
        discussionId: string
        /// The Node ID of the discussion comment within this discussion to reply to.
        replyToId: Option<string>
        /// The contents of the comment.
        body: string
    }

/// Autogenerated input type of AddDiscussionPollVote
type AddDiscussionPollVoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion poll option to vote for.
        pollOptionId: string
    }

/// Autogenerated input type of AddEnterpriseOrganizationMember
type AddEnterpriseOrganizationMemberInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise which owns the organization.
        enterpriseId: string
        /// The ID of the organization the users will be added to.
        organizationId: string
        /// The IDs of the enterprise members to add.
        userIds: list<string>
        /// The role to assign the users in the organization
        role: Option<OrganizationMemberRole>
    }

/// Autogenerated input type of AddEnterpriseSupportEntitlement
type AddEnterpriseSupportEntitlementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Enterprise which the admin belongs to.
        enterpriseId: string
        /// The login of a member who will receive the support entitlement.
        login: string
    }

/// Autogenerated input type of AddLabelsToLabelable
type AddLabelsToLabelableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the labelable object to add labels to.
        labelableId: string
        /// The ids of the labels to add.
        labelIds: list<string>
    }

/// Autogenerated input type of AddProjectCard
type AddProjectCardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the ProjectColumn.
        projectColumnId: string
        /// The content of the card. Must be a member of the ProjectCardItem union
        contentId: Option<string>
        /// The note on the card.
        note: Option<string>
    }

/// Autogenerated input type of AddProjectColumn
type AddProjectColumnInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the project.
        projectId: string
        /// The name of the column.
        name: string
    }

/// Autogenerated input type of AddProjectV2DraftIssue
type AddProjectV2DraftIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to add the draft issue to.
        projectId: string
        /// The title of the draft issue. A project item can also be created by providing the URL of an Issue or Pull Request if you have access.
        title: string
        /// The body of the draft issue.
        body: Option<string>
        /// The IDs of the assignees of the draft issue.
        assigneeIds: Option<list<string>>
    }

/// Autogenerated input type of AddProjectV2ItemById
type AddProjectV2ItemByIdInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to add the item to.
        projectId: string
        /// The id of the Issue or Pull Request to add.
        contentId: string
    }

/// Autogenerated input type of AddPullRequestReviewComment
type AddPullRequestReviewCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the pull request reviewing**Upcoming Change on 2023-10-01 UTC****Description:** `pullRequestId` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        pullRequestId: Option<string>
        /// The Node ID of the review to modify.**Upcoming Change on 2023-10-01 UTC****Description:** `pullRequestReviewId` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        pullRequestReviewId: Option<string>
        /// The SHA of the commit to comment on.**Upcoming Change on 2023-10-01 UTC****Description:** `commitOID` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        commitOID: Option<string>
        /// The text of the comment. This field is required**Upcoming Change on 2023-10-01 UTC****Description:** `body` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        body: Option<string>
        /// The relative path of the file to comment on.**Upcoming Change on 2023-10-01 UTC****Description:** `path` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        path: Option<string>
        /// The line index in the diff to comment on.**Upcoming Change on 2023-10-01 UTC****Description:** `position` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        position: Option<int>
        /// The comment id to reply to.**Upcoming Change on 2023-10-01 UTC****Description:** `inReplyTo` will be removed. use addPullRequestReviewThread or addPullRequestReviewThreadReply instead**Reason:** We are deprecating the addPullRequestReviewComment mutation
        inReplyTo: Option<string>
    }

/// Autogenerated input type of AddPullRequestReview
type AddPullRequestReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request to modify.
        pullRequestId: string
        /// The commit OID the review pertains to.
        commitOID: Option<string>
        /// The contents of the review body comment.
        body: Option<string>
        /// The event to perform on the pull request review.
        ``event``: Option<PullRequestReviewEvent>
        /// The review line comments.**Upcoming Change on 2023-10-01 UTC****Description:** `comments` will be removed. use the `threads` argument instead**Reason:** We are deprecating comment fields that use diff-relative positioning
        comments: Option<list<Option<DraftPullRequestReviewComment>>>
        /// The review line comment threads.
        threads: Option<list<Option<DraftPullRequestReviewThread>>>
    }

/// Autogenerated input type of AddPullRequestReviewThread
type AddPullRequestReviewThreadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Path to the file being commented on.
        path: Option<string>
        /// Body of the thread's first comment.
        body: string
        /// The node ID of the pull request reviewing
        pullRequestId: Option<string>
        /// The Node ID of the review to modify.
        pullRequestReviewId: Option<string>
        /// The line of the blob to which the thread refers, required for line-level threads. The end of the line range for multi-line comments.
        line: Option<int>
        /// The side of the diff on which the line resides. For multi-line comments, this is the side for the end of the line range.
        side: Option<DiffSide>
        /// The first line of the range to which the comment refers.
        startLine: Option<int>
        /// The side of the diff on which the start line resides.
        startSide: Option<DiffSide>
        /// The level at which the comments in the corresponding thread are targeted, can be a diff line or a file
        subjectType: Option<PullRequestReviewThreadSubjectType>
    }

/// Autogenerated input type of AddPullRequestReviewThreadReply
type AddPullRequestReviewThreadReplyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pending review to which the reply will belong.
        pullRequestReviewId: Option<string>
        /// The Node ID of the thread to which this reply is being written.
        pullRequestReviewThreadId: string
        /// The text of the reply.
        body: string
    }

/// Autogenerated input type of AddReaction
type AddReactionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subject to modify.
        subjectId: string
        /// The name of the emoji to react with.
        content: ReactionContent
    }

/// Autogenerated input type of AddStar
type AddStarInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Starrable ID to star.
        starrableId: string
    }

/// Autogenerated input type of AddSubIssue
type AddSubIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the issue.
        issueId: string
        /// The id of the sub-issue.
        subIssueId: Option<string>
        /// The url of the sub-issue.
        subIssueUrl: Option<string>
        /// Option to replace parent issue if one already exists
        replaceParent: Option<bool>
    }

/// Autogenerated input type of AddUpvote
type AddUpvoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion or comment to upvote.
        subjectId: string
    }

/// Autogenerated input type of AddVerifiableDomain
type AddVerifiableDomainInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the owner to add the domain to
        ownerId: string
        /// The URL of the domain
        domain: string
    }

/// Autogenerated input type of ApproveDeployments
type ApproveDeploymentsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the workflow run containing the pending deployments.
        workflowRunId: string
        /// The ids of environments to reject deployments
        environmentIds: list<string>
        /// Optional comment for approving deployments
        comment: Option<string>
    }

/// Autogenerated input type of ApproveVerifiableDomain
type ApproveVerifiableDomainInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the verifiable domain to approve.
        id: string
    }

/// Autogenerated input type of ArchiveProjectV2Item
type ArchiveProjectV2ItemInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to archive the item from.
        projectId: string
        /// The ID of the ProjectV2Item to archive.
        itemId: string
    }

/// Autogenerated input type of ArchiveRepository
type ArchiveRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the repository to mark as archived.
        repositoryId: string
    }

/// Ordering options for Audit Log connections.
type AuditLogOrder =
    {
        /// The field to order Audit Logs by.
        field: Option<AuditLogOrderField>
        /// The ordering direction.
        direction: Option<OrderDirection>
    }

/// Parameters to be used for the branch_name_pattern rule
type BranchNamePatternParametersInput =
    {
        /// How this rule will appear to users.
        name: Option<string>
        /// If true, the rule will fail if the pattern matches.
        negate: Option<bool>
        /// The operator to use for matching.
        operator: string
        /// The pattern to match with.
        pattern: string
    }

/// Information about a sponsorship to make for a user or organization with a GitHub Sponsors profile, as part of sponsoring many users or organizations at once.
type BulkSponsorship =
    {
        /// The ID of the user or organization who is receiving the sponsorship. Required if sponsorableLogin is not given.
        sponsorableId: Option<string>
        /// The username of the user or organization who is receiving the sponsorship. Required if sponsorableId is not given.
        sponsorableLogin: Option<string>
        /// The amount to pay to the sponsorable in US dollars. Valid values: 1-12000.
        amount: int
    }

/// Autogenerated input type of CancelEnterpriseAdminInvitation
type CancelEnterpriseAdminInvitationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pending enterprise administrator invitation.
        invitationId: string
    }

/// Autogenerated input type of CancelEnterpriseMemberInvitation
type CancelEnterpriseMemberInvitationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pending enterprise member invitation.
        invitationId: string
    }

/// Autogenerated input type of CancelSponsorship
type CancelSponsorshipInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorLogin is not given.
        sponsorId: Option<string>
        /// The username of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorId is not given.
        sponsorLogin: Option<string>
        /// The ID of the user or organization who is receiving the sponsorship. Required if sponsorableLogin is not given.
        sponsorableId: Option<string>
        /// The username of the user or organization who is receiving the sponsorship. Required if sponsorableId is not given.
        sponsorableLogin: Option<string>
    }

/// Autogenerated input type of ChangeUserStatus
type ChangeUserStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The emoji to represent your status. Can either be a native Unicode emoji or an emoji name with colons, e.g., :grinning:.
        emoji: Option<string>
        /// A short description of your current status.
        message: Option<string>
        /// The ID of the organization whose members will be allowed to see the status. If omitted, the status will be publicly visible.
        organizationId: Option<string>
        /// Whether this status should indicate you are not fully available on GitHub, e.g., you are away.
        limitedAvailability: Option<bool>
        /// If set, the user status will not be shown after this date.
        expiresAt: Option<System.DateTime>
    }

/// Information from a check run analysis to specific lines of code.
type CheckAnnotationData =
    {
        /// The path of the file to add an annotation to.
        path: string
        /// The location of the annotation
        location: CheckAnnotationRange
        /// Represents an annotation's information level
        annotationLevel: CheckAnnotationLevel
        /// A short description of the feedback for these lines of code.
        message: string
        /// The title that represents the annotation.
        title: Option<string>
        /// Details about this annotation.
        rawDetails: Option<string>
    }

/// Information from a check run analysis to specific lines of code.
type CheckAnnotationRange =
    {
        /// The starting line of the range.
        startLine: int
        /// The starting column of the range.
        startColumn: Option<int>
        /// The ending line of the range.
        endLine: int
        /// The ending column of the range.
        endColumn: Option<int>
    }

/// Possible further actions the integrator can perform.
type CheckRunAction =
    {
        /// The text to be displayed on a button in the web UI.
        label: string
        /// A short explanation of what this action would do.
        description: string
        /// A reference for the action on the integrator's system.
        identifier: string
    }

/// The filters that are available when fetching check runs.
type CheckRunFilter =
    {
        /// Filters the check runs by this type.
        checkType: Option<CheckRunType>
        /// Filters the check runs created by this application ID.
        appId: Option<int>
        /// Filters the check runs by this name.
        checkName: Option<string>
        /// Filters the check runs by this status. Superceded by statuses.
        status: Option<CheckStatusState>
        /// Filters the check runs by this status. Overrides status.
        statuses: Option<list<CheckStatusState>>
        /// Filters the check runs by these conclusions.
        conclusions: Option<list<CheckConclusionState>>
    }

/// Descriptive details about the check run.
type CheckRunOutput =
    {
        /// A title to provide for this check run.
        title: string
        /// The summary of the check run (supports Commonmark).
        summary: string
        /// The details of the check run (supports Commonmark).
        text: Option<string>
        /// The annotations that are made as part of the check run.
        annotations: Option<list<CheckAnnotationData>>
        /// Images attached to the check run output displayed in the GitHub pull request UI.
        images: Option<list<CheckRunOutputImage>>
    }

/// Images attached to the check run output displayed in the GitHub pull request UI.
type CheckRunOutputImage =
    {
        /// The alternative text for the image.
        alt: string
        /// The full URL of the image.
        imageUrl: string
        /// A short image description.
        caption: Option<string>
    }

/// The auto-trigger preferences that are available for check suites.
type CheckSuiteAutoTriggerPreference =
    {
        /// The node ID of the application that owns the check suite.
        appId: string
        /// Set to `true` to enable automatic creation of CheckSuite events upon pushes to the repository.
        setting: bool
    }

/// The filters that are available when fetching check suites.
type CheckSuiteFilter =
    {
        /// Filters the check suites created by this application ID.
        appId: Option<int>
        /// Filters the check suites by this name.
        checkName: Option<string>
    }

/// Autogenerated input type of ClearLabelsFromLabelable
type ClearLabelsFromLabelableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the labelable object to clear the labels from.
        labelableId: string
    }

/// Autogenerated input type of ClearProjectV2ItemFieldValue
type ClearProjectV2ItemFieldValueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project.
        projectId: string
        /// The ID of the item to be cleared.
        itemId: string
        /// The ID of the field to be cleared.
        fieldId: string
    }

/// Autogenerated input type of CloneProject
type CloneProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The owner ID to create the project under.
        targetOwnerId: string
        /// The source project to clone.
        sourceId: string
        /// Whether or not to clone the source project's workflows.
        includeWorkflows: bool
        /// The name of the project.
        name: string
        /// The description of the project.
        body: Option<string>
        /// The visibility of the project, defaults to false (private).
        ``public``: Option<bool>
    }

/// Autogenerated input type of CloneTemplateRepository
type CloneTemplateRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the template repository.
        repositoryId: string
        /// The name of the new repository.
        name: string
        /// The ID of the owner for the new repository.
        ownerId: string
        /// A short description of the new repository.
        description: Option<string>
        /// Indicates the repository's visibility level.
        visibility: RepositoryVisibility
        /// Whether to copy all branches from the template to the new repository. Defaults to copying only the default branch of the template.
        includeAllBranches: Option<bool>
    }

/// Autogenerated input type of CloseDiscussion
type CloseDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the discussion to be closed.
        discussionId: string
        /// The reason why the discussion is being closed.
        reason: Option<DiscussionCloseReason>
    }

/// Autogenerated input type of CloseIssue
type CloseIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the issue to be closed.
        issueId: string
        /// The reason the issue is to be closed.
        stateReason: Option<IssueClosedStateReason>
        /// ID of the issue that this is a duplicate of.
        duplicateIssueId: Option<string>
    }

/// Autogenerated input type of ClosePullRequest
type ClosePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to be closed.
        pullRequestId: string
    }

/// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
type CodeScanningParametersInput =
    {
        /// Tools that must provide code scanning results for this rule to pass.
        codeScanningTools: list<CodeScanningToolInput>
    }

/// A tool that must provide code scanning results for this rule to pass.
type CodeScanningToolInput =
    {
        /// The severity level at which code scanning results that raise alerts block a reference update. For more information on alert severity levels, see "[About code scanning alerts](${externalDocsUrl}/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        alertsThreshold: string
        /// The severity level at which code scanning results that raise security alerts block a reference update. For more information on security severity levels, see "[About code scanning alerts](${externalDocsUrl}/code-security/code-scanning/managing-code-scanning-alerts/about-code-scanning-alerts#about-alert-severity-and-security-severity-levels)."
        securityAlertsThreshold: string
        /// The name of a code scanning tool
        tool: string
    }

/// Specifies an author for filtering Git commits.
type CommitAuthor =
    {
        /// ID of a User to filter by. If non-null, only commits authored by this user will be returned. This field takes precedence over emails.
        id: Option<string>
        /// Email addresses to filter by. Commits authored by any of the specified email addresses will be returned.
        emails: Option<list<string>>
    }

/// Parameters to be used for the commit_author_email_pattern rule
type CommitAuthorEmailPatternParametersInput =
    {
        /// How this rule will appear to users.
        name: Option<string>
        /// If true, the rule will fail if the pattern matches.
        negate: Option<bool>
        /// The operator to use for matching.
        operator: string
        /// The pattern to match with.
        pattern: string
    }

/// Ordering options for commit contribution connections.
type CommitContributionOrder =
    {
        /// The field by which to order commit contributions.
        field: CommitContributionOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// A message to include with a new commit
type CommitMessage =
    {
        /// The headline of the message.
        headline: string
        /// The body of the message.
        body: Option<string>
    }

/// Parameters to be used for the commit_message_pattern rule
type CommitMessagePatternParametersInput =
    {
        /// How this rule will appear to users.
        name: Option<string>
        /// If true, the rule will fail if the pattern matches.
        negate: Option<bool>
        /// The operator to use for matching.
        operator: string
        /// The pattern to match with.
        pattern: string
    }

/// A git ref for a commit to be appended to.The ref must be a branch, i.e. its fully qualified name must startwith `refs/heads/` (although the input is not required to be fullyqualified).The Ref may be specified by its global node ID or by the`repositoryNameWithOwner` and `branchName`.### ExamplesSpecify a branch using a global node ID:    { "id": "MDM6UmVmMTpyZWZzL2hlYWRzL21haW4=" }Specify a branch using `repositoryNameWithOwner` and `branchName`:    {      "repositoryNameWithOwner": "github/graphql-client",      "branchName": "main"    }
type CommittableBranch =
    {
        /// The Node ID of the Ref to be updated.
        id: Option<string>
        /// The nameWithOwner of the repository to commit to.
        repositoryNameWithOwner: Option<string>
        /// The unqualified name of the branch to append the commit to.
        branchName: Option<string>
    }

/// Parameters to be used for the committer_email_pattern rule
type CommitterEmailPatternParametersInput =
    {
        /// How this rule will appear to users.
        name: Option<string>
        /// If true, the rule will fail if the pattern matches.
        negate: Option<bool>
        /// The operator to use for matching.
        operator: string
        /// The pattern to match with.
        pattern: string
    }

/// Ordering options for contribution connections.
type ContributionOrder =
    {
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of ConvertProjectCardNoteToIssue
type ConvertProjectCardNoteToIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ProjectCard ID to convert.
        projectCardId: string
        /// The ID of the repository to create the issue in.
        repositoryId: string
        /// The title of the newly created issue. Defaults to the card's note text.
        title: Option<string>
        /// The body of the newly created issue.
        body: Option<string>
    }

/// Autogenerated input type of ConvertProjectV2DraftIssueItemToIssue
type ConvertProjectV2DraftIssueItemToIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the draft issue ProjectV2Item to convert.
        itemId: string
        /// The ID of the repository to create the issue in.
        repositoryId: string
    }

/// Autogenerated input type of ConvertPullRequestToDraft
type ConvertPullRequestToDraftInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to convert to draft
        pullRequestId: string
    }

/// Autogenerated input type of CopyProjectV2
type CopyProjectV2Input =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the source Project to copy.
        projectId: string
        /// The owner ID of the new project.
        ownerId: string
        /// The title of the project.
        title: string
        /// Include draft issues in the new project
        includeDraftIssues: Option<bool>
    }

/// Autogenerated input type of CreateAttributionInvitation
type CreateAttributionInvitationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the owner scoping the reattributable data.
        ownerId: string
        /// The Node ID of the account owning the data to reattribute.
        sourceId: string
        /// The Node ID of the account which may claim the data.
        targetId: string
    }

/// Autogenerated input type of CreateBranchProtectionRule
type CreateBranchProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the repository in which a new branch protection rule should be created in.
        repositoryId: string
        /// The glob-like pattern used to determine matching branches.
        pattern: string
        /// Are approving reviews required to update matching branches.
        requiresApprovingReviews: Option<bool>
        /// Number of approving reviews required to update matching branches.
        requiredApprovingReviewCount: Option<int>
        /// Are commits required to be signed.
        requiresCommitSignatures: Option<bool>
        /// Are merge commits prohibited from being pushed to this branch.
        requiresLinearHistory: Option<bool>
        /// Is branch creation a protected operation.
        blocksCreations: Option<bool>
        /// Are force pushes allowed on this branch.
        allowsForcePushes: Option<bool>
        /// Can this branch be deleted.
        allowsDeletions: Option<bool>
        /// Can admins override branch protection.
        isAdminEnforced: Option<bool>
        /// Are status checks required to update matching branches.
        requiresStatusChecks: Option<bool>
        /// Are branches required to be up to date before merging.
        requiresStrictStatusChecks: Option<bool>
        /// Are reviews from code owners required to update matching branches.
        requiresCodeOwnerReviews: Option<bool>
        /// Will new commits pushed to matching branches dismiss pull request review approvals.
        dismissesStaleReviews: Option<bool>
        /// Is dismissal of pull request reviews restricted.
        restrictsReviewDismissals: Option<bool>
        /// A list of User, Team, or App IDs allowed to dismiss reviews on pull requests targeting matching branches.
        reviewDismissalActorIds: Option<list<string>>
        /// A list of User, Team, or App IDs allowed to bypass pull requests targeting matching branches.
        bypassPullRequestActorIds: Option<list<string>>
        /// A list of User, Team, or App IDs allowed to bypass force push targeting matching branches.
        bypassForcePushActorIds: Option<list<string>>
        /// Is pushing to matching branches restricted.
        restrictsPushes: Option<bool>
        /// A list of User, Team, or App IDs allowed to push to matching branches.
        pushActorIds: Option<list<string>>
        /// List of required status check contexts that must pass for commits to be accepted to matching branches.
        requiredStatusCheckContexts: Option<list<string>>
        /// The list of required status checks
        requiredStatusChecks: Option<list<RequiredStatusCheckInput>>
        /// Are successful deployments required before merging.
        requiresDeployments: Option<bool>
        /// The list of required deployment environments
        requiredDeploymentEnvironments: Option<list<string>>
        /// Are conversations required to be resolved before merging.
        requiresConversationResolution: Option<bool>
        /// Whether the most recent push must be approved by someone other than the person who pushed it
        requireLastPushApproval: Option<bool>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        lockBranch: Option<bool>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        lockAllowsFetchAndMerge: Option<bool>
    }

/// Autogenerated input type of CreateCheckRun
type CreateCheckRunInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the repository.
        repositoryId: string
        /// The name of the check.
        name: string
        /// The SHA of the head commit.
        headSha: string
        /// The URL of the integrator's site that has the full details of the check.
        detailsUrl: Option<string>
        /// A reference for the run on the integrator's system.
        externalId: Option<string>
        /// The current status.
        status: Option<RequestableCheckStatusState>
        /// The time that the check run began.
        startedAt: Option<System.DateTimeOffset>
        /// The final conclusion of the check.
        conclusion: Option<CheckConclusionState>
        /// The time that the check run finished.
        completedAt: Option<System.DateTimeOffset>
        /// Descriptive details about the run.
        output: Option<CheckRunOutput>
        /// Possible further actions the integrator can perform, which a user may trigger.
        actions: Option<list<CheckRunAction>>
    }

/// Autogenerated input type of CreateCheckSuite
type CreateCheckSuiteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// The SHA of the head commit.
        headSha: string
    }

/// Autogenerated input type of CreateCommitOnBranch
type CreateCommitOnBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Ref to be updated.  Must be a branch.
        branch: CommittableBranch
        /// A description of changes to files in this commit.
        fileChanges: Option<FileChanges>
        /// The commit message the be included with the commit.
        message: CommitMessage
        /// The git commit oid expected at the head of the branch prior to the commit
        expectedHeadOid: string
    }

/// Autogenerated input type of CreateDeployment
type CreateDeploymentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the repository.
        repositoryId: string
        /// The node ID of the ref to be deployed.
        refId: string
        /// Attempt to automatically merge the default branch into the requested ref, defaults to true.
        autoMerge: Option<bool>
        /// The status contexts to verify against commit status checks. To bypass required contexts, pass an empty array. Defaults to all unique contexts.
        requiredContexts: Option<list<string>>
        /// Short description of the deployment.
        description: Option<string>
        /// Name for the target deployment environment.
        environment: Option<string>
        /// Specifies a task to execute.
        task: Option<string>
        /// JSON payload with extra information about the deployment.
        payload: Option<string>
    }

/// Autogenerated input type of CreateDeploymentStatus
type CreateDeploymentStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the deployment.
        deploymentId: string
        /// The state of the deployment.
        state: DeploymentStatusState
        /// A short description of the status. Maximum length of 140 characters.
        description: Option<string>
        /// If provided, updates the environment of the deploy. Otherwise, does not modify the environment.
        environment: Option<string>
        /// Sets the URL for accessing your environment.
        environmentUrl: Option<string>
        /// Adds a new inactive status to all non-transient, non-production environment deployments with the same repository and environment name as the created status's deployment.
        autoInactive: Option<bool>
        /// The log URL to associate with this status.       This URL should contain output to keep the user updated while the task is running       or serve as historical information for what happened in the deployment.
        logUrl: Option<string>
    }

/// Autogenerated input type of CreateDiscussion
type CreateDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the repository on which to create the discussion.
        repositoryId: string
        /// The title of the discussion.
        title: string
        /// The body of the discussion.
        body: string
        /// The id of the discussion category to associate with this discussion.
        categoryId: string
    }

/// Autogenerated input type of CreateEnterpriseOrganization
type CreateEnterpriseOrganizationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise owning the new organization.
        enterpriseId: string
        /// The login of the new organization.
        login: string
        /// The profile name of the new organization.
        profileName: string
        /// The email used for sending billing receipts.
        billingEmail: string
        /// The logins for the administrators of the new organization.
        adminLogins: list<string>
    }

/// Autogenerated input type of CreateEnvironment
type CreateEnvironmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the repository.
        repositoryId: string
        /// The name of the environment.
        name: string
    }

/// Autogenerated input type of CreateIpAllowListEntry
type CreateIpAllowListEntryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the owner for which to create the new IP allow list entry.
        ownerId: string
        /// An IP address or range of addresses in CIDR notation.
        allowListValue: string
        /// An optional name for the IP allow list entry.
        name: Option<string>
        /// Whether the IP allow list entry is active when an IP allow list is enabled.
        isActive: bool
    }

/// Autogenerated input type of CreateIssue
type CreateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// The title for the issue.
        title: string
        /// The body for the issue description.
        body: Option<string>
        /// The Node ID of assignees for this issue.
        assigneeIds: Option<list<string>>
        /// The Node ID of the milestone for this issue.
        milestoneId: Option<string>
        /// An array of Node IDs of labels for this issue.
        labelIds: Option<list<string>>
        /// An array of Node IDs for projects associated with this issue.
        projectIds: Option<list<string>>
        /// The name of an issue template in the repository, assigns labels and assignees from the template to the issue
        issueTemplate: Option<string>
        /// The Node ID of the issue type for this issue
        issueTypeId: Option<string>
        /// The Node ID of the parent issue to add this new issue to
        parentIssueId: Option<string>
    }

/// Autogenerated input type of CreateIssueType
type CreateIssueTypeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID for the organization on which the issue type is created
        ownerId: string
        /// Whether or not the issue type is enabled on the org level
        isEnabled: bool
        /// Name of the new issue type
        name: string
        /// Description of the new issue type
        description: Option<string>
        /// Color for the issue type
        color: Option<IssueTypeColor>
    }

/// Autogenerated input type of CreateLabel
type CreateLabelInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// A 6 character hex code, without the leading #, identifying the color of the label.
        color: string
        /// The name of the label.
        name: string
        /// A brief description of the label, such as its purpose.
        description: Option<string>
    }

/// Autogenerated input type of CreateLinkedBranch
type CreateLinkedBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the issue to link to.
        issueId: string
        /// The commit SHA to base the new branch on.
        oid: string
        /// The name of the new branch. Defaults to issue number and title.
        name: Option<string>
        /// ID of the repository to create the branch in. Defaults to the issue repository.
        repositoryId: Option<string>
    }

/// Autogenerated input type of CreateMigrationSource
type CreateMigrationSourceInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The migration source name.
        name: string
        /// The migration source URL, for example `https://github.com` or `https://monalisa.ghe.com`.
        url: Option<string>
        /// The migration source access token.
        accessToken: Option<string>
        /// The migration source type.
        ``type``: MigrationSourceType
        /// The ID of the organization that will own the migration source.
        ownerId: string
        /// The GitHub personal access token of the user importing to the target repository.
        githubPat: Option<string>
    }

/// Autogenerated input type of CreateProject
type CreateProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The owner ID to create the project under.
        ownerId: string
        /// The name of project.
        name: string
        /// The description of project.
        body: Option<string>
        /// The name of the GitHub-provided template.
        template: Option<ProjectTemplate>
        /// A list of repository IDs to create as linked repositories for the project
        repositoryIds: Option<list<string>>
    }

/// Autogenerated input type of CreateProjectV2Field
type CreateProjectV2FieldInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to create the field in.
        projectId: string
        /// The data type of the field.
        dataType: ProjectV2CustomFieldType
        /// The name of the field.
        name: string
        /// Options for a single select field. At least one value is required if data_type is SINGLE_SELECT
        singleSelectOptions: Option<list<ProjectV2SingleSelectFieldOptionInput>>
        /// Configuration for an iteration field.
        iterationConfiguration: Option<ProjectV2IterationFieldConfigurationInput>
    }

/// Autogenerated input type of CreateProjectV2
type CreateProjectV2Input =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The owner ID to create the project under.
        ownerId: string
        /// The title of the project.
        title: string
        /// The repository to link the project to.
        repositoryId: Option<string>
        /// The team to link the project to. The team will be granted read permissions.
        teamId: Option<string>
    }

/// Autogenerated input type of CreateProjectV2StatusUpdate
type CreateProjectV2StatusUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to create the status update in.
        projectId: string
        /// The start date of the status update.
        startDate: Option<string>
        /// The target date of the status update.
        targetDate: Option<string>
        /// The status of the status update.
        status: Option<ProjectV2StatusUpdateStatus>
        /// The body of the status update.
        body: Option<string>
    }

/// Autogenerated input type of CreatePullRequest
type CreatePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// The name of the branch you want your changes pulled into. This should be an existing branchon the current repository. You cannot update the base branch on a pull request to pointto another repository.
        baseRefName: string
        /// The name of the branch where your changes are implemented. For cross-repository pull requestsin the same network, namespace `head_ref_name` with a user like this: `username:branch`.
        headRefName: string
        /// The Node ID of the head repository.
        headRepositoryId: Option<string>
        /// The title of the pull request.
        title: string
        /// The contents of the pull request.
        body: Option<string>
        /// Indicates whether maintainers can modify the pull request.
        maintainerCanModify: Option<bool>
        /// Indicates whether this pull request should be a draft.
        draft: Option<bool>
    }

/// Autogenerated input type of CreateRef
type CreateRefInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the Repository to create the Ref in.
        repositoryId: string
        /// The fully qualified name of the new Ref (ie: `refs/heads/my_new_branch`).
        name: string
        /// The GitObjectID that the new Ref shall target. Must point to a commit.
        oid: string
    }

/// Autogenerated input type of CreateRepository
type CreateRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The name of the new repository.
        name: string
        /// The ID of the owner for the new repository.
        ownerId: Option<string>
        /// A short description of the new repository.
        description: Option<string>
        /// Indicates the repository's visibility level.
        visibility: RepositoryVisibility
        /// Whether this repository should be marked as a template such that anyone who can access it can create new repositories with the same files and directory structure.
        template: Option<bool>
        /// The URL for a web page about this repository.
        homepageUrl: Option<string>
        /// Indicates if the repository should have the wiki feature enabled.
        hasWikiEnabled: Option<bool>
        /// Indicates if the repository should have the issues feature enabled.
        hasIssuesEnabled: Option<bool>
        /// When an organization is specified as the owner, this ID identifies the team that should be granted access to the new repository.
        teamId: Option<string>
    }

/// Autogenerated input type of CreateRepositoryRuleset
type CreateRepositoryRulesetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the source in which a new ruleset should be created in.
        sourceId: string
        /// The name of the ruleset.
        name: string
        /// The target of the ruleset.
        target: Option<RepositoryRulesetTarget>
        /// The list of rules for this ruleset
        rules: Option<list<RepositoryRuleInput>>
        /// The set of conditions for this ruleset
        conditions: RepositoryRuleConditionsInput
        /// The enforcement level for this ruleset
        enforcement: RuleEnforcement
        /// A list of actors that are allowed to bypass rules in this ruleset.
        bypassActors: Option<list<RepositoryRulesetBypassActorInput>>
    }

/// Autogenerated input type of CreateSponsorsListing
type CreateSponsorsListingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The username of the organization to create a GitHub Sponsors profile for, if desired. Defaults to creating a GitHub Sponsors profile for the authenticated user if omitted.
        sponsorableLogin: Option<string>
        /// The username of the supported fiscal host's GitHub organization, if you want to receive sponsorship payouts through a fiscal host rather than directly to a bank account. For example, 'Open-Source-Collective' for Open Source Collective or 'numfocus' for numFOCUS. Case insensitive. See https://docs.github.com/sponsors/receiving-sponsorships-through-github-sponsors/using-a-fiscal-host-to-receive-github-sponsors-payouts for more information.
        fiscalHostLogin: Option<string>
        /// The URL for your profile page on the fiscal host's website, e.g., https://opencollective.com/babel or https://numfocus.org/project/bokeh. Required if fiscalHostLogin is specified.
        fiscallyHostedProjectProfileUrl: Option<string>
        /// The country or region where the sponsorable's bank account is located. Required if fiscalHostLogin is not specified, ignored when fiscalHostLogin is specified.
        billingCountryOrRegionCode: Option<SponsorsCountryOrRegionCode>
        /// The country or region where the sponsorable resides. This is for tax purposes. Required if the sponsorable is yourself, ignored when sponsorableLogin specifies an organization.
        residenceCountryOrRegionCode: Option<SponsorsCountryOrRegionCode>
        /// The email address we should use to contact you about the GitHub Sponsors profile being created. This will not be shared publicly. Must be a verified email address already on your GitHub account. Only relevant when the sponsorable is yourself. Defaults to your primary email address on file if omitted.
        contactEmail: Option<string>
        /// Provide an introduction to serve as the main focus that appears on your GitHub Sponsors profile. It's a great opportunity to help potential sponsors learn more about you, your work, and why their sponsorship is important to you. GitHub-flavored Markdown is supported.
        fullDescription: Option<string>
    }

/// Autogenerated input type of CreateSponsorsTier
type CreateSponsorsTierInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the user or organization who owns the GitHub Sponsors profile. Defaults to the current user if omitted and sponsorableLogin is not given.
        sponsorableId: Option<string>
        /// The username of the user or organization who owns the GitHub Sponsors profile. Defaults to the current user if omitted and sponsorableId is not given.
        sponsorableLogin: Option<string>
        /// The value of the new tier in US dollars. Valid values: 1-12000.
        amount: int
        /// Whether sponsorships using this tier should happen monthly/yearly or just once.
        isRecurring: Option<bool>
        /// Optional ID of the private repository that sponsors at this tier should gain read-only access to. Must be owned by an organization.
        repositoryId: Option<string>
        /// Optional login of the organization owner of the private repository that sponsors at this tier should gain read-only access to. Necessary if repositoryName is given. Will be ignored if repositoryId is given.
        repositoryOwnerLogin: Option<string>
        /// Optional name of the private repository that sponsors at this tier should gain read-only access to. Must be owned by an organization. Necessary if repositoryOwnerLogin is given. Will be ignored if repositoryId is given.
        repositoryName: Option<string>
        /// Optional message new sponsors at this tier will receive.
        welcomeMessage: Option<string>
        /// A description of what this tier is, what perks sponsors might receive, what a sponsorship at this tier means for you, etc.
        description: string
        /// Whether to make the tier available immediately for sponsors to choose. Defaults to creating a draft tier that will not be publicly visible.
        publish: Option<bool>
    }

/// Autogenerated input type of CreateSponsorship
type CreateSponsorshipInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorLogin is not given.
        sponsorId: Option<string>
        /// The username of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorId is not given.
        sponsorLogin: Option<string>
        /// The ID of the user or organization who is receiving the sponsorship. Required if sponsorableLogin is not given.
        sponsorableId: Option<string>
        /// The username of the user or organization who is receiving the sponsorship. Required if sponsorableId is not given.
        sponsorableLogin: Option<string>
        /// The ID of one of sponsorable's existing tiers to sponsor at. Required if amount is not specified.
        tierId: Option<string>
        /// The amount to pay to the sponsorable in US dollars. Required if a tierId is not specified. Valid values: 1-12000.
        amount: Option<int>
        /// Whether the sponsorship should happen monthly/yearly or just this one time. Required if a tierId is not specified.
        isRecurring: Option<bool>
        /// Whether the sponsor should receive email updates from the sponsorable.
        receiveEmails: Option<bool>
        /// Specify whether others should be able to see that the sponsor is sponsoring the sponsorable. Public visibility still does not reveal which tier is used.
        privacyLevel: Option<SponsorshipPrivacy>
    }

/// Autogenerated input type of CreateSponsorships
type CreateSponsorshipsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The username of the user or organization who is acting as the sponsor, paying for the sponsorships.
        sponsorLogin: string
        /// The list of maintainers to sponsor and for how much apiece.
        sponsorships: list<BulkSponsorship>
        /// Whether the sponsor should receive email updates from the sponsorables.
        receiveEmails: Option<bool>
        /// Specify whether others should be able to see that the sponsor is sponsoring the sponsorables. Public visibility still does not reveal the dollar value of the sponsorship.
        privacyLevel: Option<SponsorshipPrivacy>
        /// Whether the sponsorships created should continue each billing cycle for the sponsor (monthly or annually), versus lasting only a single month. Defaults to one-time sponsorships.
        recurring: Option<bool>
    }

/// Autogenerated input type of CreateTeamDiscussionComment
type CreateTeamDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the discussion to which the comment belongs. This field is required.**Upcoming Change on 2024-07-01 UTC****Description:** `discussionId` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        discussionId: Option<string>
        /// The content of the comment. This field is required.**Upcoming Change on 2024-07-01 UTC****Description:** `body` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        body: Option<string>
    }

/// Autogenerated input type of CreateTeamDiscussion
type CreateTeamDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the team to which the discussion belongs. This field is required.**Upcoming Change on 2024-07-01 UTC****Description:** `teamId` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        teamId: Option<string>
        /// The title of the discussion. This field is required.**Upcoming Change on 2024-07-01 UTC****Description:** `title` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        title: Option<string>
        /// The content of the discussion. This field is required.**Upcoming Change on 2024-07-01 UTC****Description:** `body` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        body: Option<string>
        /// If true, restricts the visibility of this discussion to team members and organization owners. If false or not specified, allows any organization member to view this discussion.**Upcoming Change on 2024-07-01 UTC****Description:** `private` will be removed. Follow the guide at https://github.blog/changelog/2023-02-08-sunset-notice-team-discussions/ to find a suitable replacement.**Reason:** The Team Discussions feature is deprecated in favor of Organization Discussions.
        ``private``: Option<bool>
    }

/// Autogenerated input type of CreateUserList
type CreateUserListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The name of the new list
        name: string
        /// A description of the list
        description: Option<string>
        /// Whether or not the list is private
        isPrivate: Option<bool>
    }

/// Autogenerated input type of DeclineTopicSuggestion
type DeclineTopicSuggestionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.**Upcoming Change on 2024-04-01 UTC****Description:** `repositoryId` will be removed.**Reason:** Suggested topics are no longer supported
        repositoryId: Option<string>
        /// The name of the suggested topic.**Upcoming Change on 2024-04-01 UTC****Description:** `name` will be removed.**Reason:** Suggested topics are no longer supported
        name: Option<string>
    }

/// Autogenerated input type of DeleteBranchProtectionRule
type DeleteBranchProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the branch protection rule to be deleted.
        branchProtectionRuleId: string
    }

/// Autogenerated input type of DeleteDeployment
type DeleteDeploymentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the deployment to be deleted.
        id: string
    }

/// Autogenerated input type of DeleteDiscussionComment
type DeleteDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node id of the discussion comment to delete.
        id: string
    }

/// Autogenerated input type of DeleteDiscussion
type DeleteDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the discussion to delete.
        id: string
    }

/// Autogenerated input type of DeleteEnvironment
type DeleteEnvironmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the environment to be deleted.
        id: string
    }

/// Autogenerated input type of DeleteIpAllowListEntry
type DeleteIpAllowListEntryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the IP allow list entry to delete.
        ipAllowListEntryId: string
    }

/// Autogenerated input type of DeleteIssueComment
type DeleteIssueCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the comment to delete.
        id: string
    }

/// Autogenerated input type of DeleteIssue
type DeleteIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue to delete.
        issueId: string
    }

/// Autogenerated input type of DeleteIssueType
type DeleteIssueTypeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue type to delete
        issueTypeId: string
    }

/// Autogenerated input type of DeleteLabel
type DeleteLabelInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the label to be deleted.
        id: string
    }

/// Autogenerated input type of DeleteLinkedBranch
type DeleteLinkedBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the linked branch
        linkedBranchId: string
    }

/// Autogenerated input type of DeletePackageVersion
type DeletePackageVersionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the package version to be deleted.
        packageVersionId: string
    }

/// Autogenerated input type of DeleteProjectCard
type DeleteProjectCardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the card to delete.
        cardId: string
    }

/// Autogenerated input type of DeleteProjectColumn
type DeleteProjectColumnInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the column to delete.
        columnId: string
    }

/// Autogenerated input type of DeleteProject
type DeleteProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Project ID to update.
        projectId: string
    }

/// Autogenerated input type of DeleteProjectV2Field
type DeleteProjectV2FieldInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the field to delete.
        fieldId: string
    }

/// Autogenerated input type of DeleteProjectV2
type DeleteProjectV2Input =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to delete.
        projectId: string
    }

/// Autogenerated input type of DeleteProjectV2Item
type DeleteProjectV2ItemInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project from which the item should be removed.
        projectId: string
        /// The ID of the item to be removed.
        itemId: string
    }

/// Autogenerated input type of DeleteProjectV2StatusUpdate
type DeleteProjectV2StatusUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the status update to be removed.
        statusUpdateId: string
    }

/// Autogenerated input type of DeleteProjectV2Workflow
type DeleteProjectV2WorkflowInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the workflow to be removed.
        workflowId: string
    }

/// Autogenerated input type of DeletePullRequestReviewComment
type DeletePullRequestReviewCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the comment to delete.
        id: string
    }

/// Autogenerated input type of DeletePullRequestReview
type DeletePullRequestReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request review to delete.
        pullRequestReviewId: string
    }

/// Autogenerated input type of DeleteRef
type DeleteRefInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the Ref to be deleted.
        refId: string
    }

/// Autogenerated input type of DeleteRepositoryRuleset
type DeleteRepositoryRulesetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the repository ruleset to be deleted.
        repositoryRulesetId: string
    }

/// Autogenerated input type of DeleteTeamDiscussionComment
type DeleteTeamDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the comment to delete.
        id: string
    }

/// Autogenerated input type of DeleteTeamDiscussion
type DeleteTeamDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The discussion ID to delete.
        id: string
    }

/// Autogenerated input type of DeleteUserList
type DeleteUserListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the list to delete.
        listId: string
    }

/// Autogenerated input type of DeleteVerifiableDomain
type DeleteVerifiableDomainInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the verifiable domain to delete.
        id: string
    }

/// Ordering options for deployment connections
type DeploymentOrder =
    {
        /// The field to order deployments by.
        field: DeploymentOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of DequeuePullRequest
type DequeuePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the pull request to be dequeued.
        id: string
    }

/// Autogenerated input type of DisablePullRequestAutoMerge
type DisablePullRequestAutoMergeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to disable auto merge on.
        pullRequestId: string
    }

/// Ways in which lists of discussions can be ordered upon return.
type DiscussionOrder =
    {
        /// The field by which to order discussions.
        field: DiscussionOrderField
        /// The direction in which to order discussions by the specified field.
        direction: OrderDirection
    }

/// Ordering options for discussion poll option connections.
type DiscussionPollOptionOrder =
    {
        /// The field to order poll options by.
        field: DiscussionPollOptionOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of DismissPullRequestReview
type DismissPullRequestReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request review to modify.
        pullRequestReviewId: string
        /// The contents of the pull request review dismissal message.
        message: string
    }

/// Autogenerated input type of DismissRepositoryVulnerabilityAlert
type DismissRepositoryVulnerabilityAlertInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Dependabot alert ID to dismiss.
        repositoryVulnerabilityAlertId: string
        /// The reason the Dependabot alert is being dismissed.
        dismissReason: DismissReason
    }

/// Specifies a review comment to be left with a Pull Request Review.
type DraftPullRequestReviewComment =
    {
        /// Path to the file being commented on.
        path: string
        /// Position in the file to leave a comment on.
        position: int
        /// Body of the comment to leave.
        body: string
    }

/// Specifies a review comment thread to be left with a Pull Request Review.
type DraftPullRequestReviewThread =
    {
        /// Path to the file being commented on. Required if not using positioning.
        path: Option<string>
        /// The line of the blob to which the thread refers. The end of the line range for multi-line comments. Required if not using positioning.
        line: Option<int>
        /// The side of the diff on which the line resides. For multi-line comments, this is the side for the end of the line range.
        side: Option<DiffSide>
        /// The first line of the range to which the comment refers.
        startLine: Option<int>
        /// The side of the diff on which the start line resides.
        startSide: Option<DiffSide>
        /// Body of the comment to leave.
        body: string
    }

/// Autogenerated input type of EnablePullRequestAutoMerge
type EnablePullRequestAutoMergeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to enable auto-merge on.
        pullRequestId: string
        /// Commit headline to use for the commit when the PR is mergable; if omitted, a default message will be used. NOTE: when merging with a merge queue any input value for commit headline is ignored.
        commitHeadline: Option<string>
        /// Commit body to use for the commit when the PR is mergable; if omitted, a default message will be used. NOTE: when merging with a merge queue any input value for commit message is ignored.
        commitBody: Option<string>
        /// The merge method to use. If omitted, defaults to `MERGE`. NOTE: when merging with a merge queue any input value for merge method is ignored.
        mergeMethod: Option<PullRequestMergeMethod>
        /// The email address to associate with this merge.
        authorEmail: Option<string>
        /// The expected head OID of the pull request.
        expectedHeadOid: Option<string>
    }

/// Autogenerated input type of EnqueuePullRequest
type EnqueuePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the pull request to enqueue.
        pullRequestId: string
        /// Add the pull request to the front of the queue.
        jump: Option<bool>
        /// The expected head OID of the pull request.
        expectedHeadOid: Option<string>
    }

/// Ordering options for enterprise administrator invitation connections
type EnterpriseAdministratorInvitationOrder =
    {
        /// The field to order enterprise administrator invitations by.
        field: EnterpriseAdministratorInvitationOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for enterprise administrator invitation connections
type EnterpriseMemberInvitationOrder =
    {
        /// The field to order enterprise member invitations by.
        field: EnterpriseMemberInvitationOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for enterprise member connections.
type EnterpriseMemberOrder =
    {
        /// The field to order enterprise members by.
        field: EnterpriseMemberOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for enterprises.
type EnterpriseOrder =
    {
        /// The field to order enterprises by.
        field: EnterpriseOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for Enterprise Server installation connections.
type EnterpriseServerInstallationOrder =
    {
        /// The field to order Enterprise Server installations by.
        field: EnterpriseServerInstallationOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for Enterprise Server user account email connections.
type EnterpriseServerUserAccountEmailOrder =
    {
        /// The field to order emails by.
        field: EnterpriseServerUserAccountEmailOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for Enterprise Server user account connections.
type EnterpriseServerUserAccountOrder =
    {
        /// The field to order user accounts by.
        field: EnterpriseServerUserAccountOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for Enterprise Server user accounts upload connections.
type EnterpriseServerUserAccountsUploadOrder =
    {
        /// The field to order user accounts uploads by.
        field: EnterpriseServerUserAccountsUploadOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for environments
type Environments =
    {
        /// The field to order environments by.
        field: EnvironmentOrderField
        /// The direction in which to order environments by the specified field.
        direction: OrderDirection
    }

/// A command to add a file at the given path with the given contents as part of a commit.  Any existing file at that that path will be replaced.
type FileAddition =
    {
        /// The path in the repository where the file will be located
        path: string
        /// The base64 encoded contents of the file
        contents: string
    }

/// A description of a set of changes to a file tree to be made as part ofa git commit, modeled as zero or more file `additions` and zero or morefile `deletions`.Both fields are optional; omitting both will produce a commit with nofile changes.`deletions` and `additions` describe changes to files identifiedby their path in the git tree using unix-style path separators, i.e.`/`.  The root of a git tree is an empty string, so paths are notslash-prefixed.`path` values must be unique across all `additions` and `deletions`provided.  Any duplication will result in a validation error.### EncodingFile contents must be provided in full for each `FileAddition`.The `contents` of a `FileAddition` must be encoded using RFC 4648compliant base64, i.e. correct padding is required and no charactersoutside the standard alphabet may be used.  Invalid base64encoding will be rejected with a validation error.The encoded contents may be binary.For text files, no assumptions are made about the character encoding ofthe file contents (after base64 decoding).  No charset transcoding orline-ending normalization will be performed; it is the client'sresponsibility to manage the character encoding of files they provide.However, for maximum compatibility we recommend using UTF-8 encodingand ensuring that all files in a repository use a consistentline-ending convention (`\n` or `\r\n`), and that all files endwith a newline.### Modeling file changesEach of the the five types of conceptual changes that can be made in agit commit can be described using the `FileChanges` type as follows:1. New file addition: create file `hello world\n` at path `docs/README.txt`:       {         "additions" [           {             "path": "docs/README.txt",             "contents": base64encode("hello world\n")           }         ]       }2. Existing file modification: change existing `docs/README.txt` to have new   content `new content here\n`:       {         "additions" [           {             "path": "docs/README.txt",             "contents": base64encode("new content here\n")           }         ]       }3. Existing file deletion: remove existing file `docs/README.txt`.   Note that the path is required to exist -- specifying a   path that does not exist on the given branch will abort the   commit and return an error.       {         "deletions" [           {             "path": "docs/README.txt"           }         ]       }4. File rename with no changes: rename `docs/README.txt` with   previous content `hello world\n` to the same content at   `newdocs/README.txt`:       {         "deletions" [           {             "path": "docs/README.txt",           }         ],         "additions" [           {             "path": "newdocs/README.txt",             "contents": base64encode("hello world\n")           }         ]       }5. File rename with changes: rename `docs/README.txt` with   previous content `hello world\n` to a file at path   `newdocs/README.txt` with content `new contents\n`:       {         "deletions" [           {             "path": "docs/README.txt",           }         ],         "additions" [           {             "path": "newdocs/README.txt",             "contents": base64encode("new contents\n")           }         ]       }
type FileChanges =
    {
        /// Files to delete.
        deletions: Option<list<FileDeletion>>
        /// File to add or change.
        additions: Option<list<FileAddition>>
    }

/// A command to delete the file at the given path as part of a commit.
type FileDeletion =
    {
        /// The path to delete
        path: string
    }

/// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
type FileExtensionRestrictionParametersInput =
    {
        /// The file extensions that are restricted from being pushed to the commit graph.
        restrictedFileExtensions: list<string>
    }

/// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
type FilePathRestrictionParametersInput =
    {
        /// The file paths that are restricted from being pushed to the commit graph.
        restrictedFilePaths: list<string>
    }

/// Autogenerated input type of FollowOrganization
type FollowOrganizationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the organization to follow.
        organizationId: string
    }

/// Autogenerated input type of FollowUser
type FollowUserInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the user to follow.
        userId: string
    }

/// Ordering options for gist connections
type GistOrder =
    {
        /// The field to order repositories by.
        field: GistOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of GrantEnterpriseOrganizationsMigratorRole
type GrantEnterpriseOrganizationsMigratorRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise to which all organizations managed by it will be granted the migrator role.
        enterpriseId: string
        /// The login of the user to grant the migrator role
        login: string
    }

/// Autogenerated input type of GrantMigratorRole
type GrantMigratorRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization that the user/team belongs to.
        organizationId: string
        /// The user login or Team slug to grant the migrator role.
        actor: string
        /// Specifies the type of the actor, can be either USER or TEAM.
        actorType: ActorType
    }

/// Autogenerated input type of ImportProject
type ImportProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The name of the Organization or User to create the Project under.
        ownerName: string
        /// The name of Project.
        name: string
        /// The description of Project.
        body: Option<string>
        /// Whether the Project is public or not.
        ``public``: Option<bool>
        /// A list of columns containing issues and pull requests.
        columnImports: list<ProjectColumnImport>
    }

/// Autogenerated input type of InviteEnterpriseAdmin
type InviteEnterpriseAdminInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise to which you want to invite an administrator.
        enterpriseId: string
        /// The login of a user to invite as an administrator.
        invitee: Option<string>
        /// The email of the person to invite as an administrator.
        email: Option<string>
        /// The role of the administrator.
        role: Option<EnterpriseAdministratorRole>
    }

/// Autogenerated input type of InviteEnterpriseMember
type InviteEnterpriseMemberInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise to which you want to invite an unaffiliated member.
        enterpriseId: string
        /// The login of a user to invite as an unaffiliated member.
        invitee: Option<string>
        /// The email of the person to invite as an unaffiliated member.
        email: Option<string>
    }

/// Ordering options for IP allow list entry connections.
type IpAllowListEntryOrder =
    {
        /// The field to order IP allow list entries by.
        field: IpAllowListEntryOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ways in which lists of issue comments can be ordered upon return.
type IssueCommentOrder =
    {
        /// The field in which to order issue comments by.
        field: IssueCommentOrderField
        /// The direction in which to order issue comments by the specified field.
        direction: OrderDirection
    }

/// Ways in which to filter lists of issues.
type IssueFilters =
    {
        /// List issues assigned to given name. Pass in `null` for issues with no assigned user, and `*` for issues assigned to any user.
        assignee: Option<string>
        /// List issues created by given name.
        createdBy: Option<string>
        /// List issues where the list of label names exist on the issue.
        labels: Option<list<string>>
        /// List issues where the given name is mentioned in the issue.
        mentioned: Option<string>
        /// List issues by given milestone argument. If an string representation of an integer is passed, it should refer to a milestone by its database ID. Pass in `null` for issues with no milestone, and `*` for issues that are assigned to any milestone.
        milestone: Option<string>
        /// List issues by given milestone argument. If an string representation of an integer is passed, it should refer to a milestone by its number field. Pass in `null` for issues with no milestone, and `*` for issues that are assigned to any milestone.
        milestoneNumber: Option<string>
        /// List issues that have been updated at or after the given date.
        since: Option<System.DateTime>
        /// List issues filtered by the list of states given.
        states: Option<list<IssueState>>
        /// List issues filtered by the type given, only supported by searches on repositories.
        ``type``: Option<string>
        /// List issues subscribed to by viewer.
        viewerSubscribed: Option<bool>
    }

/// Ways in which lists of issues can be ordered upon return.
type IssueOrder =
    {
        /// The field in which to order issues by.
        field: IssueOrderField
        /// The direction in which to order issues by the specified field.
        direction: OrderDirection
    }

/// Ordering options for issue types connections
type IssueTypeOrder =
    {
        /// The field to order issue types by.
        field: IssueTypeOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ways in which lists of labels can be ordered upon return.
type LabelOrder =
    {
        /// The field in which to order labels by.
        field: LabelOrderField
        /// The direction in which to order labels by the specified field.
        direction: OrderDirection
    }

/// Ordering options for language connections.
type LanguageOrder =
    {
        /// The field to order languages by.
        field: LanguageOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of LinkProjectV2ToRepository
type LinkProjectV2ToRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the project to link to the repository.
        projectId: string
        /// The ID of the repository to link to the project.
        repositoryId: string
    }

/// Autogenerated input type of LinkProjectV2ToTeam
type LinkProjectV2ToTeamInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the project to link to the team.
        projectId: string
        /// The ID of the team to link to the project.
        teamId: string
    }

/// Autogenerated input type of LinkRepositoryToProject
type LinkRepositoryToProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to link to a Repository
        projectId: string
        /// The ID of the Repository to link to a Project.
        repositoryId: string
    }

/// Autogenerated input type of LockLockable
type LockLockableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the item to be locked.
        lockableId: string
        /// A reason for why the item will be locked.
        lockReason: Option<LockReason>
    }

/// Ordering options for mannequins.
type MannequinOrder =
    {
        /// The field to order mannequins by.
        field: MannequinOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of MarkDiscussionCommentAsAnswer
type MarkDiscussionCommentAsAnswerInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion comment to mark as an answer.
        id: string
    }

/// Autogenerated input type of MarkFileAsViewed
type MarkFileAsViewedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request.
        pullRequestId: string
        /// The path of the file to mark as viewed
        path: string
    }

/// Autogenerated input type of MarkProjectV2AsTemplate
type MarkProjectV2AsTemplateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to mark as a template.
        projectId: string
    }

/// Autogenerated input type of MarkPullRequestReadyForReview
type MarkPullRequestReadyForReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to be marked as ready for review.
        pullRequestId: string
    }

/// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
type MaxFilePathLengthParametersInput =
    {
        /// The maximum amount of characters allowed in file paths.
        maxFilePathLength: int
    }

/// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
type MaxFileSizeParametersInput =
    {
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        maxFileSize: int
    }

/// Autogenerated input type of MergeBranch
type MergeBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the Repository containing the base branch that will be modified.
        repositoryId: string
        /// The name of the base branch that the provided head will be merged into.
        ``base``: string
        /// The head to merge into the base branch. This can be a branch name or a commit GitObjectID.
        head: string
        /// Message to use for the merge commit. If omitted, a default will be used.
        commitMessage: Option<string>
        /// The email address to associate with this commit.
        authorEmail: Option<string>
    }

/// Autogenerated input type of MergePullRequest
type MergePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to be merged.
        pullRequestId: string
        /// Commit headline to use for the merge commit; if omitted, a default message will be used.
        commitHeadline: Option<string>
        /// Commit body to use for the merge commit; if omitted, a default message will be used
        commitBody: Option<string>
        /// OID that the pull request head ref must match to allow merge; if omitted, no check is performed.
        expectedHeadOid: Option<string>
        /// The merge method to use. If omitted, defaults to 'MERGE'
        mergeMethod: Option<PullRequestMergeMethod>
        /// The email address to associate with this merge.
        authorEmail: Option<string>
    }

/// Merges must be performed via a merge queue.
type MergeQueueParametersInput =
    {
        /// Maximum time for a required status check to report a conclusion. After this much time has elapsed, checks that have not reported a conclusion will be assumed to have failed
        checkResponseTimeoutMinutes: int
        /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
        groupingStrategy: MergeQueueGroupingStrategy
        /// Limit the number of queued pull requests requesting checks and workflow runs at the same time.
        maxEntriesToBuild: int
        /// The maximum number of PRs that will be merged together in a group.
        maxEntriesToMerge: int
        /// Method to use when merging changes from queued pull requests.
        mergeMethod: MergeQueueMergeMethod
        /// The minimum number of PRs that will be merged together in a group.
        minEntriesToMerge: int
        /// The time merge queue should wait after the first PR is added to the queue for the minimum group size to be met. After this time has elapsed, the minimum group size will be ignored and a smaller group will be merged.
        minEntriesToMergeWaitMinutes: int
    }

/// Ordering options for milestone connections.
type MilestoneOrder =
    {
        /// The field to order milestones by.
        field: MilestoneOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of MinimizeComment
type MinimizeCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subject to modify.
        subjectId: string
        /// The classification of comment
        classifier: ReportedContentClassifiers
    }

/// Autogenerated input type of MoveProjectCard
type MoveProjectCardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the card to move.
        cardId: string
        /// The id of the column to move it into.
        columnId: string
        /// Place the new card after the card with this id. Pass null to place it at the top.
        afterCardId: Option<string>
    }

/// Autogenerated input type of MoveProjectColumn
type MoveProjectColumnInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the column to move.
        columnId: string
        /// Place the new column after the column with this id. Pass null to place it at the front.
        afterColumnId: Option<string>
    }

/// Ordering options for an organization's enterprise owner connections.
type OrgEnterpriseOwnerOrder =
    {
        /// The field to order enterprise owners by.
        field: OrgEnterpriseOwnerOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for organization connections.
type OrganizationOrder =
    {
        /// The field to order organizations by.
        field: OrganizationOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ways in which lists of package files can be ordered upon return.
type PackageFileOrder =
    {
        /// The field in which to order package files by.
        field: Option<PackageFileOrderField>
        /// The direction in which to order package files by the specified field.
        direction: Option<OrderDirection>
    }

/// Ways in which lists of packages can be ordered upon return.
type PackageOrder =
    {
        /// The field in which to order packages by.
        field: Option<PackageOrderField>
        /// The direction in which to order packages by the specified field.
        direction: Option<OrderDirection>
    }

/// Ways in which lists of package versions can be ordered upon return.
type PackageVersionOrder =
    {
        /// The field in which to order package versions by.
        field: Option<PackageVersionOrderField>
        /// The direction in which to order package versions by the specified field.
        direction: Option<OrderDirection>
    }

/// Autogenerated input type of PinEnvironment
type PinEnvironmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the environment to modify
        environmentId: string
        /// The desired state of the environment. If true, environment will be pinned. If false, it will be unpinned.
        pinned: bool
    }

/// Autogenerated input type of PinIssue
type PinIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue to be pinned
        issueId: string
    }

/// Ordering options for pinned environments
type PinnedEnvironmentOrder =
    {
        /// The field to order pinned environments by.
        field: PinnedEnvironmentOrderField
        /// The direction in which to order pinned environments by the specified field.
        direction: OrderDirection
    }

/// An issue or PR and its owning repository to be used in a project card.
type ProjectCardImport =
    {
        /// Repository name with owner (owner/repository).
        repository: string
        /// The issue or pull request number.
        number: int
    }

/// A project column and a list of its issues and PRs.
type ProjectColumnImport =
    {
        /// The name of the column.
        columnName: string
        /// The position of the column, starting from 0.
        position: int
        /// A list of issues and pull requests in the column.
        issues: Option<list<ProjectCardImport>>
    }

/// Ways in which lists of projects can be ordered upon return.
type ProjectOrder =
    {
        /// The field in which to order projects by.
        field: ProjectOrderField
        /// The direction in which to order projects by the specified field.
        direction: OrderDirection
    }

/// A collaborator to update on a project. Only one of the userId or teamId should be provided.
type ProjectV2Collaborator =
    {
        /// The ID of the user as a collaborator.
        userId: Option<string>
        /// The ID of the team as a collaborator.
        teamId: Option<string>
        /// The role to grant the collaborator
        role: ProjectV2Roles
    }

/// Ordering options for project v2 field connections
type ProjectV2FieldOrder =
    {
        /// The field to order the project v2 fields by.
        field: ProjectV2FieldOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// The values that can be used to update a field of an item inside a Project. Only 1 value can be updated at a time.
type ProjectV2FieldValue =
    {
        /// The text to set on the field.
        text: Option<string>
        /// The number to set on the field.
        number: Option<float>
        /// The ISO 8601 date to set on the field.
        date: Option<string>
        /// The id of the single select option to set on the field.
        singleSelectOptionId: Option<string>
        /// The id of the iteration to set on the field.
        iterationId: Option<string>
    }

/// Ways in which to filter lists of projects.
type ProjectV2Filters =
    {
        /// List project v2 filtered by the state given.
        state: Option<ProjectV2State>
    }

/// Ordering options for project v2 item field value connections
type ProjectV2ItemFieldValueOrder =
    {
        /// The field to order the project v2 item field values by.
        field: ProjectV2ItemFieldValueOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for project v2 item connections
type ProjectV2ItemOrder =
    {
        /// The field to order the project v2 items by.
        field: ProjectV2ItemOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Represents an iteration
type ProjectV2Iteration =
    {
        /// The start date for the iteration.
        startDate: System.DateTime
        /// The duration of the iteration, in days.
        duration: int
        /// The title for the iteration.
        title: string
    }

/// Represents an iteration field configuration.
type ProjectV2IterationFieldConfigurationInput =
    {
        /// The start date for the first iteration.
        startDate: System.DateTime
        /// The duration of each iteration, in days.
        duration: int
        /// Zero or more iterations for the field.
        iterations: list<ProjectV2Iteration>
    }

/// Ways in which lists of projects can be ordered upon return.
type ProjectV2Order =
    {
        /// The field in which to order projects by.
        field: ProjectV2OrderField
        /// The direction in which to order projects by the specified field.
        direction: OrderDirection
    }

/// Represents a single select field option
type ProjectV2SingleSelectFieldOptionInput =
    {
        /// The name of the option
        name: string
        /// The display color of the option
        color: ProjectV2SingleSelectFieldOptionColor
        /// The description text of the option
        description: string
    }

/// Ways in which project v2 status updates can be ordered.
type ProjectV2StatusOrder =
    {
        /// The field by which to order nodes.
        field: ProjectV2StatusUpdateOrderField
        /// The direction in which to order nodes.
        direction: OrderDirection
    }

/// Ordering options for project v2 view connections
type ProjectV2ViewOrder =
    {
        /// The field to order the project v2 views by.
        field: ProjectV2ViewOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for project v2 workflows connections
type ProjectV2WorkflowOrder =
    {
        /// The field to order the project v2 workflows by.
        field: ProjectV2WorkflowsOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// A property that must match
type PropertyTargetDefinitionInput =
    {
        /// The name of the property
        name: string
        /// The values to match for
        propertyValues: list<string>
        /// The source of the property. Choose 'custom' or 'system'. Defaults to 'custom' if not specified
        source: Option<string>
    }

/// Autogenerated input type of PublishSponsorsTier
type PublishSponsorsTierInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the draft tier to publish.
        tierId: string
    }

/// Ways in which lists of issues can be ordered upon return.
type PullRequestOrder =
    {
        /// The field in which to order pull requests by.
        field: PullRequestOrderField
        /// The direction in which to order pull requests by the specified field.
        direction: OrderDirection
    }

/// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
type PullRequestParametersInput =
    {
        /// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
        allowedMergeMethods: Option<list<PullRequestAllowedMergeMethods>>
        /// Automatically request review from Copilot for new pull requests, if the author has access to Copilot code review.
        automaticCopilotCodeReviewEnabled: Option<bool>
        /// New, reviewable commits pushed will dismiss previous pull request review approvals.
        dismissStaleReviewsOnPush: bool
        /// Require an approving review in pull requests that modify files that have a designated code owner.
        requireCodeOwnerReview: bool
        /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
        requireLastPushApproval: bool
        /// The number of approving reviews that are required before a pull request can be merged.
        requiredApprovingReviewCount: int
        /// All conversations on code must be resolved before a pull request can be merged.
        requiredReviewThreadResolution: bool
    }

/// Ways in which lists of reactions can be ordered upon return.
type ReactionOrder =
    {
        /// The field in which to order reactions by.
        field: ReactionOrderField
        /// The direction in which to order reactions by the specified field.
        direction: OrderDirection
    }

/// Parameters to be used for the ref_name condition
type RefNameConditionTargetInput =
    {
        /// Array of ref names or patterns to exclude. The condition will not pass if any of these patterns match.
        exclude: list<string>
        /// Array of ref names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~DEFAULT_BRANCH` to include the default branch or `~ALL` to include all branches.
        ``include``: list<string>
    }

/// Ways in which lists of git refs can be ordered upon return.
type RefOrder =
    {
        /// The field in which to order refs by.
        field: RefOrderField
        /// The direction in which to order refs by the specified field.
        direction: OrderDirection
    }

/// A ref update
type RefUpdate =
    {
        /// The fully qualified name of the ref to be update. For example `refs/heads/branch-name`
        name: string
        /// The value this ref should be updated to.
        afterOid: string
        /// The value this ref needs to point to before the update.
        beforeOid: Option<string>
        /// Force a non fast-forward update.
        force: Option<bool>
    }

/// Autogenerated input type of RegenerateEnterpriseIdentityProviderRecoveryCodes
type RegenerateEnterpriseIdentityProviderRecoveryCodesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set an identity provider.
        enterpriseId: string
    }

/// Autogenerated input type of RegenerateVerifiableDomainToken
type RegenerateVerifiableDomainTokenInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the verifiable domain to regenerate the verification token of.
        id: string
    }

/// Autogenerated input type of RejectDeployments
type RejectDeploymentsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the workflow run containing the pending deployments.
        workflowRunId: string
        /// The ids of environments to reject deployments
        environmentIds: list<string>
        /// Optional comment for rejecting deployments
        comment: Option<string>
    }

/// Ways in which lists of releases can be ordered upon return.
type ReleaseOrder =
    {
        /// The field in which to order releases by.
        field: ReleaseOrderField
        /// The direction in which to order releases by the specified field.
        direction: OrderDirection
    }

/// Autogenerated input type of RemoveAssigneesFromAssignable
type RemoveAssigneesFromAssignableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the assignable object to remove assignees from.
        assignableId: string
        /// The id of users to remove as assignees.
        assigneeIds: list<string>
    }

/// Autogenerated input type of RemoveEnterpriseAdmin
type RemoveEnterpriseAdminInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Enterprise ID from which to remove the administrator.
        enterpriseId: string
        /// The login of the user to remove as an administrator.
        login: string
    }

/// Autogenerated input type of RemoveEnterpriseIdentityProvider
type RemoveEnterpriseIdentityProviderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise from which to remove the identity provider.
        enterpriseId: string
    }

/// Autogenerated input type of RemoveEnterpriseMember
type RemoveEnterpriseMemberInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise from which the user should be removed.
        enterpriseId: string
        /// The ID of the user to remove from the enterprise.
        userId: string
    }

/// Autogenerated input type of RemoveEnterpriseOrganization
type RemoveEnterpriseOrganizationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise from which the organization should be removed.
        enterpriseId: string
        /// The ID of the organization to remove from the enterprise.
        organizationId: string
    }

/// Autogenerated input type of RemoveEnterpriseSupportEntitlement
type RemoveEnterpriseSupportEntitlementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Enterprise which the admin belongs to.
        enterpriseId: string
        /// The login of a member who will lose the support entitlement.
        login: string
    }

/// Autogenerated input type of RemoveLabelsFromLabelable
type RemoveLabelsFromLabelableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the Labelable to remove labels from.
        labelableId: string
        /// The ids of labels to remove.
        labelIds: list<string>
    }

/// Autogenerated input type of RemoveOutsideCollaborator
type RemoveOutsideCollaboratorInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the outside collaborator to remove.
        userId: string
        /// The ID of the organization to remove the outside collaborator from.
        organizationId: string
    }

/// Autogenerated input type of RemoveReaction
type RemoveReactionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subject to modify.
        subjectId: string
        /// The name of the emoji reaction to remove.
        content: ReactionContent
    }

/// Autogenerated input type of RemoveStar
type RemoveStarInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Starrable ID to unstar.
        starrableId: string
    }

/// Autogenerated input type of RemoveSubIssue
type RemoveSubIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the issue.
        issueId: string
        /// The id of the sub-issue.
        subIssueId: string
    }

/// Autogenerated input type of RemoveUpvote
type RemoveUpvoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion or comment to remove upvote.
        subjectId: string
    }

/// Autogenerated input type of ReopenDiscussion
type ReopenDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the discussion to be reopened.
        discussionId: string
    }

/// Autogenerated input type of ReopenIssue
type ReopenIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the issue to be opened.
        issueId: string
    }

/// Autogenerated input type of ReopenPullRequest
type ReopenPullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pull request to be reopened.
        pullRequestId: string
    }

/// Autogenerated input type of ReorderEnvironment
type ReorderEnvironmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the environment to modify
        environmentId: string
        /// The desired position of the environment
        position: int
    }

/// Autogenerated input type of ReplaceActorsForAssignable
type ReplaceActorsForAssignableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the assignable object to replace the assignees for.
        assignableId: string
        /// The ids of the actors to replace the existing assignees.
        actorIds: list<string>
    }

/// Parameters to be used for the repository_id condition
type RepositoryIdConditionTargetInput =
    {
        /// One of these repo IDs must match the repo.
        repositoryIds: list<string>
    }

/// Ordering options for repository invitation connections.
type RepositoryInvitationOrder =
    {
        /// The field to order repository invitations by.
        field: RepositoryInvitationOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for repository migrations.
type RepositoryMigrationOrder =
    {
        /// The field to order repository migrations by.
        field: RepositoryMigrationOrderField
        /// The ordering direction.
        direction: RepositoryMigrationOrderDirection
    }

/// Parameters to be used for the repository_name condition
type RepositoryNameConditionTargetInput =
    {
        /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
        exclude: list<string>
        /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
        ``include``: list<string>
        /// Target changes that match these patterns will be prevented except by those with bypass permissions.
        ``protected``: Option<bool>
    }

/// Ordering options for repository connections
type RepositoryOrder =
    {
        /// The field to order repositories by.
        field: RepositoryOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Parameters to be used for the repository_property condition
type RepositoryPropertyConditionTargetInput =
    {
        /// Array of repository properties that must not match.
        exclude: list<PropertyTargetDefinitionInput>
        /// Array of repository properties that must match
        ``include``: list<PropertyTargetDefinitionInput>
    }

/// Specifies the conditions required for a ruleset to evaluate
type RepositoryRuleConditionsInput =
    {
        /// Configuration for the ref_name condition
        refName: Option<RefNameConditionTargetInput>
        /// Configuration for the repository_name condition
        repositoryName: Option<RepositoryNameConditionTargetInput>
        /// Configuration for the repository_id condition
        repositoryId: Option<RepositoryIdConditionTargetInput>
        /// Configuration for the repository_property condition
        repositoryProperty: Option<RepositoryPropertyConditionTargetInput>
    }

/// Specifies the attributes for a new or updated rule.
type RepositoryRuleInput =
    {
        /// Optional ID of this rule when updating
        id: Option<string>
        /// The type of rule to create.
        ``type``: RepositoryRuleType
        /// The parameters for the rule.
        parameters: Option<RuleParametersInput>
    }

/// Ordering options for repository rules.
type RepositoryRuleOrder =
    {
        /// The field to order repository rules by.
        field: RepositoryRuleOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Specifies the attributes for a new or updated ruleset bypass actor. Only one of `actor_id`, `repository_role_database_id`, `organization_admin`, or `deploy_key` should be specified.
type RepositoryRulesetBypassActorInput =
    {
        /// For Team and Integration bypasses, the Team or Integration ID
        actorId: Option<string>
        /// For role bypasses, the role database ID
        repositoryRoleDatabaseId: Option<int>
        /// For organization owner bypasses, true
        organizationAdmin: Option<bool>
        /// For enterprise owner bypasses, true
        enterpriseOwner: Option<bool>
        /// For deploy key bypasses, true. Can only use ALWAYS as the bypass mode
        deployKey: Option<bool>
        /// The bypass mode for this actor.
        bypassMode: RepositoryRulesetBypassActorBypassMode
    }

/// Autogenerated input type of ReprioritizeSubIssue
type ReprioritizeSubIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The id of the parent issue.
        issueId: string
        /// The id of the sub-issue to reprioritize.
        subIssueId: string
        /// The id of the sub-issue to be prioritized after (either positional argument after OR before should be specified).
        afterId: Option<string>
        /// The id of the sub-issue to be prioritized before (either positional argument after OR before should be specified).
        beforeId: Option<string>
    }

/// Autogenerated input type of RequestReviews
type RequestReviewsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request to modify.
        pullRequestId: string
        /// The Node IDs of the user to request.
        userIds: Option<list<string>>
        /// The Node IDs of the bot to request.
        botIds: Option<list<string>>
        /// The Node IDs of the team to request.
        teamIds: Option<list<string>>
        /// Add users to the set rather than replace.
        union: Option<bool>
    }

/// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
type RequiredDeploymentsParametersInput =
    {
        /// The environments that must be successfully deployed to before branches can be merged.
        requiredDeploymentEnvironments: list<string>
    }

/// Specifies the attributes for a new or updated required status check.
type RequiredStatusCheckInput =
    {
        /// Status check context that must pass for commits to be accepted to the matching branch.
        context: string
        /// The ID of the App that must set the status in order for it to be accepted. Omit this value to use whichever app has recently been setting this status, or use "any" to allow any app to set the status.
        appId: Option<string>
    }

/// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
type RequiredStatusChecksParametersInput =
    {
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        doNotEnforceOnCreate: Option<bool>
        /// Status checks that are required.
        requiredStatusChecks: list<StatusCheckConfigurationInput>
        /// Whether pull requests targeting a matching branch must be tested with the latest code. This setting will not take effect unless at least one status check is enabled.
        strictRequiredStatusChecksPolicy: bool
    }

/// Autogenerated input type of RerequestCheckSuite
type RerequestCheckSuiteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// The Node ID of the check suite.
        checkSuiteId: string
    }

/// Autogenerated input type of ResolveReviewThread
type ResolveReviewThreadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the thread to resolve
        threadId: string
    }

/// Autogenerated input type of RetireSponsorsTier
type RetireSponsorsTierInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the published tier to retire.
        tierId: string
    }

/// Autogenerated input type of RevertPullRequest
type RevertPullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the pull request to revert.
        pullRequestId: string
        /// The title of the revert pull request.
        title: Option<string>
        /// The description of the revert pull request.
        body: Option<string>
        /// Indicates whether the revert pull request should be a draft.
        draft: Option<bool>
    }

/// Autogenerated input type of RevokeEnterpriseOrganizationsMigratorRole
type RevokeEnterpriseOrganizationsMigratorRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise to which all organizations managed by it will be granted the migrator role.
        enterpriseId: string
        /// The login of the user to revoke the migrator role
        login: string
    }

/// Autogenerated input type of RevokeMigratorRole
type RevokeMigratorRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization that the user/team belongs to.
        organizationId: string
        /// The user login or Team slug to revoke the migrator role from.
        actor: string
        /// Specifies the type of the actor, can be either USER or TEAM.
        actorType: ActorType
    }

/// Specifies the parameters for a `RepositoryRule` object. Only one of the fields should be specified.
type RuleParametersInput =
    {
        /// Parameters used for the `update` rule type
        update: Option<UpdateParametersInput>
        /// Parameters used for the `merge_queue` rule type
        mergeQueue: Option<MergeQueueParametersInput>
        /// Parameters used for the `required_deployments` rule type
        requiredDeployments: Option<RequiredDeploymentsParametersInput>
        /// Parameters used for the `pull_request` rule type
        pullRequest: Option<PullRequestParametersInput>
        /// Parameters used for the `required_status_checks` rule type
        requiredStatusChecks: Option<RequiredStatusChecksParametersInput>
        /// Parameters used for the `commit_message_pattern` rule type
        commitMessagePattern: Option<CommitMessagePatternParametersInput>
        /// Parameters used for the `commit_author_email_pattern` rule type
        commitAuthorEmailPattern: Option<CommitAuthorEmailPatternParametersInput>
        /// Parameters used for the `committer_email_pattern` rule type
        committerEmailPattern: Option<CommitterEmailPatternParametersInput>
        /// Parameters used for the `branch_name_pattern` rule type
        branchNamePattern: Option<BranchNamePatternParametersInput>
        /// Parameters used for the `tag_name_pattern` rule type
        tagNamePattern: Option<TagNamePatternParametersInput>
        /// Parameters used for the `file_path_restriction` rule type
        filePathRestriction: Option<FilePathRestrictionParametersInput>
        /// Parameters used for the `max_file_path_length` rule type
        maxFilePathLength: Option<MaxFilePathLengthParametersInput>
        /// Parameters used for the `file_extension_restriction` rule type
        fileExtensionRestriction: Option<FileExtensionRestrictionParametersInput>
        /// Parameters used for the `max_file_size` rule type
        maxFileSize: Option<MaxFileSizeParametersInput>
        /// Parameters used for the `workflows` rule type
        workflows: Option<WorkflowsParametersInput>
        /// Parameters used for the `code_scanning` rule type
        codeScanning: Option<CodeScanningParametersInput>
    }

/// Ordering options for saved reply connections.
type SavedReplyOrder =
    {
        /// The field to order saved replies by.
        field: SavedReplyOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// An advisory identifier to filter results on.
type SecurityAdvisoryIdentifierFilter =
    {
        /// The identifier type.
        ``type``: SecurityAdvisoryIdentifierType
        /// The identifier string. Supports exact or partial matching.
        value: string
    }

/// Ordering options for security advisory connections
type SecurityAdvisoryOrder =
    {
        /// The field to order security advisories by.
        field: SecurityAdvisoryOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for security vulnerability connections
type SecurityVulnerabilityOrder =
    {
        /// The field to order security vulnerabilities by.
        field: SecurityVulnerabilityOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of SetEnterpriseIdentityProvider
type SetEnterpriseIdentityProviderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set an identity provider.
        enterpriseId: string
        /// The URL endpoint for the identity provider's SAML SSO.
        ssoUrl: string
        /// The Issuer Entity ID for the SAML identity provider
        issuer: Option<string>
        /// The x509 certificate used by the identity provider to sign assertions and responses.
        idpCertificate: string
        /// The signature algorithm used to sign SAML requests for the identity provider.
        signatureMethod: SamlSignatureAlgorithm
        /// The digest algorithm used to sign SAML requests for the identity provider.
        digestMethod: SamlDigestAlgorithm
    }

/// Autogenerated input type of SetOrganizationInteractionLimit
type SetOrganizationInteractionLimitInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization to set a limit for.
        organizationId: string
        /// The limit to set.
        limit: RepositoryInteractionLimit
        /// When this limit should expire.
        expiry: Option<RepositoryInteractionLimitExpiry>
    }

/// Autogenerated input type of SetRepositoryInteractionLimit
type SetRepositoryInteractionLimitInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the repository to set a limit for.
        repositoryId: string
        /// The limit to set.
        limit: RepositoryInteractionLimit
        /// When this limit should expire.
        expiry: Option<RepositoryInteractionLimitExpiry>
    }

/// Autogenerated input type of SetUserInteractionLimit
type SetUserInteractionLimitInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the user to set a limit for.
        userId: string
        /// The limit to set.
        limit: RepositoryInteractionLimit
        /// When this limit should expire.
        expiry: Option<RepositoryInteractionLimitExpiry>
    }

/// Ordering options for connections to get sponsor entities and associated USD amounts for GitHub Sponsors.
type SponsorAndLifetimeValueOrder =
    {
        /// The field to order results by.
        field: SponsorAndLifetimeValueOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for connections to get sponsor entities for GitHub Sponsors.
type SponsorOrder =
    {
        /// The field to order sponsor entities by.
        field: SponsorOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for connections to get sponsorable entities for GitHub Sponsors.
type SponsorableOrder =
    {
        /// The field to order sponsorable entities by.
        field: SponsorableOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for GitHub Sponsors activity connections.
type SponsorsActivityOrder =
    {
        /// The field to order activity by.
        field: SponsorsActivityOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for Sponsors tiers connections.
type SponsorsTierOrder =
    {
        /// The field to order tiers by.
        field: SponsorsTierOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for sponsorship newsletter connections.
type SponsorshipNewsletterOrder =
    {
        /// The field to order sponsorship newsletters by.
        field: SponsorshipNewsletterOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for sponsorship connections.
type SponsorshipOrder =
    {
        /// The field to order sponsorship by.
        field: SponsorshipOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ways in which star connections can be ordered.
type StarOrder =
    {
        /// The field in which to order nodes by.
        field: StarOrderField
        /// The direction in which to order nodes.
        direction: OrderDirection
    }

/// Autogenerated input type of StartOrganizationMigration
type StartOrganizationMigrationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The URL of the organization to migrate.
        sourceOrgUrl: string
        /// The name of the target organization.
        targetOrgName: string
        /// The ID of the enterprise the target organization belongs to.
        targetEnterpriseId: string
        /// The migration source access token.
        sourceAccessToken: string
    }

/// Autogenerated input type of StartRepositoryMigration
type StartRepositoryMigrationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the migration source.
        sourceId: string
        /// The ID of the organization that will own the imported repository.
        ownerId: string
        /// The URL of the source repository.
        sourceRepositoryUrl: string
        /// The name of the imported repository.
        repositoryName: string
        /// Whether to continue the migration on error. Defaults to `true`.
        continueOnError: Option<bool>
        /// The signed URL to access the user-uploaded git archive.
        gitArchiveUrl: Option<string>
        /// The signed URL to access the user-uploaded metadata archive.
        metadataArchiveUrl: Option<string>
        /// The migration source access token.
        accessToken: Option<string>
        /// The GitHub personal access token of the user importing to the target repository.
        githubPat: Option<string>
        /// Whether to skip migrating releases for the repository.
        skipReleases: Option<bool>
        /// The visibility of the imported repository.
        targetRepoVisibility: Option<string>
        /// Whether to lock the source repository.
        lockSource: Option<bool>
    }

/// Required status check
type StatusCheckConfigurationInput =
    {
        /// The status check context name that must be present on the commit.
        context: string
        /// The optional integration ID that this status check must originate from.
        integrationId: Option<int>
    }

/// Autogenerated input type of SubmitPullRequestReview
type SubmitPullRequestReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Pull Request ID to submit any pending reviews.
        pullRequestId: Option<string>
        /// The Pull Request Review ID to submit.
        pullRequestReviewId: Option<string>
        /// The event to send to the Pull Request Review.
        ``event``: PullRequestReviewEvent
        /// The text field to set on the Pull Request Review.
        body: Option<string>
    }

/// Parameters to be used for the tag_name_pattern rule
type TagNamePatternParametersInput =
    {
        /// How this rule will appear to users.
        name: Option<string>
        /// If true, the rule will fail if the pattern matches.
        negate: Option<bool>
        /// The operator to use for matching.
        operator: string
        /// The pattern to match with.
        pattern: string
    }

/// Ways in which team discussion comment connections can be ordered.
type TeamDiscussionCommentOrder =
    {
        /// The field by which to order nodes.
        field: TeamDiscussionCommentOrderField
        /// The direction in which to order nodes.
        direction: OrderDirection
    }

/// Ways in which team discussion connections can be ordered.
type TeamDiscussionOrder =
    {
        /// The field by which to order nodes.
        field: TeamDiscussionOrderField
        /// The direction in which to order nodes.
        direction: OrderDirection
    }

/// Ordering options for team member connections
type TeamMemberOrder =
    {
        /// The field to order team members by.
        field: TeamMemberOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ways in which team connections can be ordered.
type TeamOrder =
    {
        /// The field in which to order nodes by.
        field: TeamOrderField
        /// The direction in which to order nodes.
        direction: OrderDirection
    }

/// Ordering options for team repository connections
type TeamRepositoryOrder =
    {
        /// The field to order repositories by.
        field: TeamRepositoryOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of TransferEnterpriseOrganization
type TransferEnterpriseOrganizationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization to transfer.
        organizationId: string
        /// The ID of the enterprise where the organization should be transferred.
        destinationEnterpriseId: string
    }

/// Autogenerated input type of TransferIssue
type TransferIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the issue to be transferred
        issueId: string
        /// The Node ID of the repository the issue should be transferred to
        repositoryId: string
        /// Whether to create labels if they don't exist in the target repository (matched by name)
        createLabelsIfMissing: Option<bool>
    }

/// Autogenerated input type of UnarchiveProjectV2Item
type UnarchiveProjectV2ItemInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to archive the item from.
        projectId: string
        /// The ID of the ProjectV2Item to unarchive.
        itemId: string
    }

/// Autogenerated input type of UnarchiveRepository
type UnarchiveRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the repository to unarchive.
        repositoryId: string
    }

/// Autogenerated input type of UnfollowOrganization
type UnfollowOrganizationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the organization to unfollow.
        organizationId: string
    }

/// Autogenerated input type of UnfollowUser
type UnfollowUserInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the user to unfollow.
        userId: string
    }

/// Autogenerated input type of UnlinkProjectV2FromRepository
type UnlinkProjectV2FromRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the project to unlink from the repository.
        projectId: string
        /// The ID of the repository to unlink from the project.
        repositoryId: string
    }

/// Autogenerated input type of UnlinkProjectV2FromTeam
type UnlinkProjectV2FromTeamInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the project to unlink from the team.
        projectId: string
        /// The ID of the team to unlink from the project.
        teamId: string
    }

/// Autogenerated input type of UnlinkRepositoryFromProject
type UnlinkRepositoryFromProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project linked to the Repository.
        projectId: string
        /// The ID of the Repository linked to the Project.
        repositoryId: string
    }

/// Autogenerated input type of UnlockLockable
type UnlockLockableInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the item to be unlocked.
        lockableId: string
    }

/// Autogenerated input type of UnmarkDiscussionCommentAsAnswer
type UnmarkDiscussionCommentAsAnswerInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion comment to unmark as an answer.
        id: string
    }

/// Autogenerated input type of UnmarkFileAsViewed
type UnmarkFileAsViewedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request.
        pullRequestId: string
        /// The path of the file to mark as unviewed
        path: string
    }

/// Autogenerated input type of UnmarkIssueAsDuplicate
type UnmarkIssueAsDuplicateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the issue or pull request currently marked as a duplicate.
        duplicateId: string
        /// ID of the issue or pull request currently considered canonical/authoritative/original.
        canonicalId: string
    }

/// Autogenerated input type of UnmarkProjectV2AsTemplate
type UnmarkProjectV2AsTemplateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to unmark as a template.
        projectId: string
    }

/// Autogenerated input type of UnminimizeComment
type UnminimizeCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subject to modify.
        subjectId: string
    }

/// Autogenerated input type of UnpinIssue
type UnpinIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue to be unpinned
        issueId: string
    }

/// Autogenerated input type of UnresolveReviewThread
type UnresolveReviewThreadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the thread to unresolve
        threadId: string
    }

/// Autogenerated input type of UpdateBranchProtectionRule
type UpdateBranchProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the branch protection rule to be updated.
        branchProtectionRuleId: string
        /// The glob-like pattern used to determine matching branches.
        pattern: Option<string>
        /// Are approving reviews required to update matching branches.
        requiresApprovingReviews: Option<bool>
        /// Number of approving reviews required to update matching branches.
        requiredApprovingReviewCount: Option<int>
        /// Are commits required to be signed.
        requiresCommitSignatures: Option<bool>
        /// Are merge commits prohibited from being pushed to this branch.
        requiresLinearHistory: Option<bool>
        /// Is branch creation a protected operation.
        blocksCreations: Option<bool>
        /// Are force pushes allowed on this branch.
        allowsForcePushes: Option<bool>
        /// Can this branch be deleted.
        allowsDeletions: Option<bool>
        /// Can admins override branch protection.
        isAdminEnforced: Option<bool>
        /// Are status checks required to update matching branches.
        requiresStatusChecks: Option<bool>
        /// Are branches required to be up to date before merging.
        requiresStrictStatusChecks: Option<bool>
        /// Are reviews from code owners required to update matching branches.
        requiresCodeOwnerReviews: Option<bool>
        /// Will new commits pushed to matching branches dismiss pull request review approvals.
        dismissesStaleReviews: Option<bool>
        /// Is dismissal of pull request reviews restricted.
        restrictsReviewDismissals: Option<bool>
        /// A list of User, Team, or App IDs allowed to dismiss reviews on pull requests targeting matching branches.
        reviewDismissalActorIds: Option<list<string>>
        /// A list of User, Team, or App IDs allowed to bypass pull requests targeting matching branches.
        bypassPullRequestActorIds: Option<list<string>>
        /// A list of User, Team, or App IDs allowed to bypass force push targeting matching branches.
        bypassForcePushActorIds: Option<list<string>>
        /// Is pushing to matching branches restricted.
        restrictsPushes: Option<bool>
        /// A list of User, Team, or App IDs allowed to push to matching branches.
        pushActorIds: Option<list<string>>
        /// List of required status check contexts that must pass for commits to be accepted to matching branches.
        requiredStatusCheckContexts: Option<list<string>>
        /// The list of required status checks
        requiredStatusChecks: Option<list<RequiredStatusCheckInput>>
        /// Are successful deployments required before merging.
        requiresDeployments: Option<bool>
        /// The list of required deployment environments
        requiredDeploymentEnvironments: Option<list<string>>
        /// Are conversations required to be resolved before merging.
        requiresConversationResolution: Option<bool>
        /// Whether the most recent push must be approved by someone other than the person who pushed it
        requireLastPushApproval: Option<bool>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        lockBranch: Option<bool>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        lockAllowsFetchAndMerge: Option<bool>
    }

/// Autogenerated input type of UpdateCheckRun
type UpdateCheckRunInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the repository.
        repositoryId: string
        /// The node of the check.
        checkRunId: string
        /// The name of the check.
        name: Option<string>
        /// The URL of the integrator's site that has the full details of the check.
        detailsUrl: Option<string>
        /// A reference for the run on the integrator's system.
        externalId: Option<string>
        /// The current status.
        status: Option<RequestableCheckStatusState>
        /// The time that the check run began.
        startedAt: Option<System.DateTimeOffset>
        /// The final conclusion of the check.
        conclusion: Option<CheckConclusionState>
        /// The time that the check run finished.
        completedAt: Option<System.DateTimeOffset>
        /// Descriptive details about the run.
        output: Option<CheckRunOutput>
        /// Possible further actions the integrator can perform, which a user may trigger.
        actions: Option<list<CheckRunAction>>
    }

/// Autogenerated input type of UpdateCheckSuitePreferences
type UpdateCheckSuitePreferencesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// The check suite preferences to modify.
        autoTriggerPreferences: list<CheckSuiteAutoTriggerPreference>
    }

/// Autogenerated input type of UpdateDiscussionComment
type UpdateDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion comment to update.
        commentId: string
        /// The new contents of the comment body.
        body: string
    }

/// Autogenerated input type of UpdateDiscussion
type UpdateDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion to update.
        discussionId: string
        /// The new discussion title.
        title: Option<string>
        /// The new contents of the discussion body.
        body: Option<string>
        /// The Node ID of a discussion category within the same repository to change this discussion to.
        categoryId: Option<string>
    }

/// Autogenerated input type of UpdateEnterpriseAdministratorRole
type UpdateEnterpriseAdministratorRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Enterprise which the admin belongs to.
        enterpriseId: string
        /// The login of a administrator whose role is being changed.
        login: string
        /// The new role for the Enterprise administrator.
        role: EnterpriseAdministratorRole
    }

/// Autogenerated input type of UpdateEnterpriseAllowPrivateRepositoryForkingSetting
type UpdateEnterpriseAllowPrivateRepositoryForkingSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the allow private repository forking setting.
        enterpriseId: string
        /// The value for the allow private repository forking setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
        /// The value for the allow private repository forking policy on the enterprise.
        policyValue: Option<EnterpriseAllowPrivateRepositoryForkingPolicyValue>
    }

/// Autogenerated input type of UpdateEnterpriseDefaultRepositoryPermissionSetting
type UpdateEnterpriseDefaultRepositoryPermissionSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the base repository permission setting.
        enterpriseId: string
        /// The value for the base repository permission setting on the enterprise.
        settingValue: EnterpriseDefaultRepositoryPermissionSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseDeployKeySetting
type UpdateEnterpriseDeployKeySettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the deploy key setting.
        enterpriseId: string
        /// The value for the deploy key setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanChangeRepositoryVisibilitySetting
type UpdateEnterpriseMembersCanChangeRepositoryVisibilitySettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can change repository visibility setting.
        enterpriseId: string
        /// The value for the members can change repository visibility setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanCreateRepositoriesSetting
type UpdateEnterpriseMembersCanCreateRepositoriesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can create repositories setting.
        enterpriseId: string
        /// Value for the members can create repositories setting on the enterprise. This or the granular public/private/internal allowed fields (but not both) must be provided.
        settingValue: Option<EnterpriseMembersCanCreateRepositoriesSettingValue>
        /// When false, allow member organizations to set their own repository creation member privileges.
        membersCanCreateRepositoriesPolicyEnabled: Option<bool>
        /// Allow members to create public repositories. Defaults to current value.
        membersCanCreatePublicRepositories: Option<bool>
        /// Allow members to create private repositories. Defaults to current value.
        membersCanCreatePrivateRepositories: Option<bool>
        /// Allow members to create internal repositories. Defaults to current value.
        membersCanCreateInternalRepositories: Option<bool>
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanDeleteIssuesSetting
type UpdateEnterpriseMembersCanDeleteIssuesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can delete issues setting.
        enterpriseId: string
        /// The value for the members can delete issues setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanDeleteRepositoriesSetting
type UpdateEnterpriseMembersCanDeleteRepositoriesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can delete repositories setting.
        enterpriseId: string
        /// The value for the members can delete repositories setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanInviteCollaboratorsSetting
type UpdateEnterpriseMembersCanInviteCollaboratorsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can invite collaborators setting.
        enterpriseId: string
        /// The value for the members can invite collaborators setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanMakePurchasesSetting
type UpdateEnterpriseMembersCanMakePurchasesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can make purchases setting.
        enterpriseId: string
        /// The value for the members can make purchases setting on the enterprise.
        settingValue: EnterpriseMembersCanMakePurchasesSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanUpdateProtectedBranchesSetting
type UpdateEnterpriseMembersCanUpdateProtectedBranchesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can update protected branches setting.
        enterpriseId: string
        /// The value for the members can update protected branches setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseMembersCanViewDependencyInsightsSetting
type UpdateEnterpriseMembersCanViewDependencyInsightsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the members can view dependency insights setting.
        enterpriseId: string
        /// The value for the members can view dependency insights setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseOrganizationProjectsSetting
type UpdateEnterpriseOrganizationProjectsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the organization projects setting.
        enterpriseId: string
        /// The value for the organization projects setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseOwnerOrganizationRole
type UpdateEnterpriseOwnerOrganizationRoleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Enterprise which the owner belongs to.
        enterpriseId: string
        /// The ID of the organization for membership change.
        organizationId: string
        /// The role to assume in the organization.
        organizationRole: RoleInOrganization
    }

/// Autogenerated input type of UpdateEnterpriseProfile
type UpdateEnterpriseProfileInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Enterprise ID to update.
        enterpriseId: string
        /// The name of the enterprise.
        name: Option<string>
        /// The description of the enterprise.
        description: Option<string>
        /// The URL of the enterprise's website.
        websiteUrl: Option<string>
        /// The location of the enterprise.
        location: Option<string>
    }

/// Autogenerated input type of UpdateEnterpriseRepositoryProjectsSetting
type UpdateEnterpriseRepositoryProjectsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the repository projects setting.
        enterpriseId: string
        /// The value for the repository projects setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseTeamDiscussionsSetting
type UpdateEnterpriseTeamDiscussionsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the team discussions setting.
        enterpriseId: string
        /// The value for the team discussions setting on the enterprise.
        settingValue: EnterpriseEnabledDisabledSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseTwoFactorAuthenticationDisallowedMethodsSetting
type UpdateEnterpriseTwoFactorAuthenticationDisallowedMethodsSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the two-factor authentication disallowed methods setting.
        enterpriseId: string
        /// The value for the two-factor authentication disallowed methods setting on the enterprise.
        settingValue: EnterpriseDisallowedMethodsSettingValue
    }

/// Autogenerated input type of UpdateEnterpriseTwoFactorAuthenticationRequiredSetting
type UpdateEnterpriseTwoFactorAuthenticationRequiredSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the enterprise on which to set the two factor authentication required setting.
        enterpriseId: string
        /// The value for the two factor authentication required setting on the enterprise.
        settingValue: EnterpriseEnabledSettingValue
    }

/// Autogenerated input type of UpdateEnvironment
type UpdateEnvironmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The node ID of the environment.
        environmentId: string
        /// The wait timer in minutes.
        waitTimer: Option<int>
        /// The ids of users or teams that can approve deployments to this environment
        reviewers: Option<list<string>>
        /// Whether deployments to this environment can be approved by the user who created the deployment.
        preventSelfReview: Option<bool>
    }

/// Autogenerated input type of UpdateIpAllowListEnabledSetting
type UpdateIpAllowListEnabledSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the owner on which to set the IP allow list enabled setting.
        ownerId: string
        /// The value for the IP allow list enabled setting.
        settingValue: IpAllowListEnabledSettingValue
    }

/// Autogenerated input type of UpdateIpAllowListEntry
type UpdateIpAllowListEntryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the IP allow list entry to update.
        ipAllowListEntryId: string
        /// An IP address or range of addresses in CIDR notation.
        allowListValue: string
        /// An optional name for the IP allow list entry.
        name: Option<string>
        /// Whether the IP allow list entry is active when an IP allow list is enabled.
        isActive: bool
    }

/// Autogenerated input type of UpdateIpAllowListForInstalledAppsEnabledSetting
type UpdateIpAllowListForInstalledAppsEnabledSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the owner.
        ownerId: string
        /// The value for the IP allow list configuration for installed GitHub Apps setting.
        settingValue: IpAllowListForInstalledAppsEnabledSettingValue
    }

/// Autogenerated input type of UpdateIssueComment
type UpdateIssueCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the IssueComment to modify.
        id: string
        /// The updated text of the comment.
        body: string
    }

/// Autogenerated input type of UpdateIssue
type UpdateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Issue to modify.
        id: string
        /// The title for the issue.
        title: Option<string>
        /// The body for the issue description.
        body: Option<string>
        /// An array of Node IDs of users for this issue.
        assigneeIds: Option<list<string>>
        /// The Node ID of the milestone for this issue.
        milestoneId: Option<string>
        /// An array of Node IDs of labels for this issue.
        labelIds: Option<list<string>>
        /// The desired issue state.
        state: Option<IssueState>
        /// An array of Node IDs for projects associated with this issue.
        projectIds: Option<list<string>>
        /// The ID of the Issue Type for this issue.
        issueTypeId: Option<string>
    }

/// Autogenerated input type of UpdateIssueIssueType
type UpdateIssueIssueTypeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue type to update on the issue
        issueTypeId: Option<string>
        /// The ID of the issue to update
        issueId: string
    }

/// Autogenerated input type of UpdateIssueType
type UpdateIssueTypeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the issue type to update
        issueTypeId: string
        /// Whether or not the issue type is enabled for the organization
        isEnabled: Option<bool>
        /// The name of the issue type
        name: Option<string>
        /// The description of the issue type
        description: Option<string>
        /// Color for the issue type
        color: Option<IssueTypeColor>
    }

/// Autogenerated input type of UpdateLabel
type UpdateLabelInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the label to be updated.
        id: string
        /// A 6 character hex code, without the leading #, identifying the updated color of the label.
        color: Option<string>
        /// A brief description of the label, such as its purpose.
        description: Option<string>
        /// The updated name of the label.
        name: Option<string>
    }

/// Autogenerated input type of UpdateNotificationRestrictionSetting
type UpdateNotificationRestrictionSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the owner on which to set the restrict notifications setting.
        ownerId: string
        /// The value for the restrict notifications setting.
        settingValue: NotificationRestrictionSettingValue
    }

/// Autogenerated input type of UpdateOrganizationAllowPrivateRepositoryForkingSetting
type UpdateOrganizationAllowPrivateRepositoryForkingSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization on which to set the allow private repository forking setting.
        organizationId: string
        /// Enable forking of private repositories in the organization?
        forkingEnabled: bool
    }

/// Autogenerated input type of UpdateOrganizationWebCommitSignoffSetting
type UpdateOrganizationWebCommitSignoffSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the organization on which to set the web commit signoff setting.
        organizationId: string
        /// Enable signoff on web-based commits for repositories in the organization?
        webCommitSignoffRequired: bool
    }

/// Only allow users with bypass permission to update matching refs.
type UpdateParametersInput =
    {
        /// Branch can pull changes from its upstream repository
        updateAllowsFetchAndMerge: bool
    }

/// Autogenerated input type of UpdatePatreonSponsorability
type UpdatePatreonSponsorabilityInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The username of the organization with the GitHub Sponsors profile, if any. Defaults to the GitHub Sponsors profile for the authenticated user if omitted.
        sponsorableLogin: Option<string>
        /// Whether Patreon tiers should be shown on the GitHub Sponsors profile page, allowing potential sponsors to make their payment through Patreon instead of GitHub.
        enablePatreonSponsorships: bool
    }

/// Autogenerated input type of UpdateProjectCard
type UpdateProjectCardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ProjectCard ID to update.
        projectCardId: string
        /// Whether or not the ProjectCard should be archived
        isArchived: Option<bool>
        /// The note of ProjectCard.
        note: Option<string>
    }

/// Autogenerated input type of UpdateProjectColumn
type UpdateProjectColumnInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ProjectColumn ID to update.
        projectColumnId: string
        /// The name of project column.
        name: string
    }

/// Autogenerated input type of UpdateProject
type UpdateProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Project ID to update.
        projectId: string
        /// The name of project.
        name: Option<string>
        /// The description of project.
        body: Option<string>
        /// Whether the project is open or closed.
        state: Option<ProjectState>
        /// Whether the project is public or not.
        ``public``: Option<bool>
    }

/// Autogenerated input type of UpdateProjectV2Collaborators
type UpdateProjectV2CollaboratorsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the project to update the collaborators for.
        projectId: string
        /// The collaborators to update.
        collaborators: list<ProjectV2Collaborator>
    }

/// Autogenerated input type of UpdateProjectV2DraftIssue
type UpdateProjectV2DraftIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the draft issue to update.
        draftIssueId: string
        /// The title of the draft issue.
        title: Option<string>
        /// The body of the draft issue.
        body: Option<string>
        /// The IDs of the assignees of the draft issue.
        assigneeIds: Option<list<string>>
    }

/// Autogenerated input type of UpdateProjectV2Field
type UpdateProjectV2FieldInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the field to update.
        fieldId: string
        /// The name to update.
        name: Option<string>
        /// Options for a field of type SINGLE_SELECT. If empty, no changes will be made to the options. If values are present, they will overwrite the existing options for the field.
        singleSelectOptions: Option<list<ProjectV2SingleSelectFieldOptionInput>>
        /// Configuration for an iteration field.
        iterationConfiguration: Option<ProjectV2IterationFieldConfigurationInput>
    }

/// Autogenerated input type of UpdateProjectV2
type UpdateProjectV2Input =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project to update.
        projectId: string
        /// Set the title of the project.
        title: Option<string>
        /// Set the short description of the project.
        shortDescription: Option<string>
        /// Set the readme description of the project.
        readme: Option<string>
        /// Set the project to closed or open.
        closed: Option<bool>
        /// Set the project to public or private.
        ``public``: Option<bool>
    }

/// Autogenerated input type of UpdateProjectV2ItemFieldValue
type UpdateProjectV2ItemFieldValueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project.
        projectId: string
        /// The ID of the item to be updated.
        itemId: string
        /// The ID of the field to be updated.
        fieldId: string
        /// The value which will be set on the field.
        value: ProjectV2FieldValue
    }

/// Autogenerated input type of UpdateProjectV2ItemPosition
type UpdateProjectV2ItemPositionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the Project.
        projectId: string
        /// The ID of the item to be moved.
        itemId: string
        /// The ID of the item to position this item after. If omitted or set to null the item will be moved to top.
        afterId: Option<string>
    }

/// Autogenerated input type of UpdateProjectV2StatusUpdate
type UpdateProjectV2StatusUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the status update to be updated.
        statusUpdateId: string
        /// The start date of the status update.
        startDate: Option<string>
        /// The target date of the status update.
        targetDate: Option<string>
        /// The status of the status update.
        status: Option<ProjectV2StatusUpdateStatus>
        /// The body of the status update.
        body: Option<string>
    }

/// Autogenerated input type of UpdatePullRequestBranch
type UpdatePullRequestBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request.
        pullRequestId: string
        /// The head ref oid for the upstream branch.
        expectedHeadOid: Option<string>
        /// The update branch method to use. If omitted, defaults to 'MERGE'
        updateMethod: Option<PullRequestBranchUpdateMethod>
    }

/// Autogenerated input type of UpdatePullRequest
type UpdatePullRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request.
        pullRequestId: string
        /// The name of the branch you want your changes pulled into. This should be an existing branchon the current repository.
        baseRefName: Option<string>
        /// The title of the pull request.
        title: Option<string>
        /// The contents of the pull request.
        body: Option<string>
        /// The target state of the pull request.
        state: Option<PullRequestUpdateState>
        /// Indicates whether maintainers can modify the pull request.
        maintainerCanModify: Option<bool>
        /// An array of Node IDs of users for this pull request.
        assigneeIds: Option<list<string>>
        /// The Node ID of the milestone for this pull request.
        milestoneId: Option<string>
        /// An array of Node IDs of labels for this pull request.
        labelIds: Option<list<string>>
        /// An array of Node IDs for projects associated with this pull request.
        projectIds: Option<list<string>>
    }

/// Autogenerated input type of UpdatePullRequestReviewComment
type UpdatePullRequestReviewCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the comment to modify.
        pullRequestReviewCommentId: string
        /// The text of the comment.
        body: string
    }

/// Autogenerated input type of UpdatePullRequestReview
type UpdatePullRequestReviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the pull request review to modify.
        pullRequestReviewId: string
        /// The contents of the pull request review body.
        body: string
    }

/// Autogenerated input type of UpdateRef
type UpdateRefInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the Ref to be updated.
        refId: string
        /// The GitObjectID that the Ref shall be updated to target.
        oid: string
        /// Permit updates of branch Refs that are not fast-forwards?
        force: Option<bool>
    }

/// Autogenerated input type of UpdateRefs
type UpdateRefsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// A list of ref updates.
        refUpdates: list<RefUpdate>
    }

/// Autogenerated input type of UpdateRepository
type UpdateRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the repository to update.
        repositoryId: string
        /// The new name of the repository.
        name: Option<string>
        /// A new description for the repository. Pass an empty string to erase the existing description.
        description: Option<string>
        /// Whether this repository should be marked as a template such that anyone who can access it can create new repositories with the same files and directory structure.
        template: Option<bool>
        /// The URL for a web page about this repository. Pass an empty string to erase the existing URL.
        homepageUrl: Option<string>
        /// Indicates if the repository should have the wiki feature enabled.
        hasWikiEnabled: Option<bool>
        /// Indicates if the repository should have the issues feature enabled.
        hasIssuesEnabled: Option<bool>
        /// Indicates if the repository should have the project boards feature enabled.
        hasProjectsEnabled: Option<bool>
        /// Indicates if the repository should have the discussions feature enabled.
        hasDiscussionsEnabled: Option<bool>
        /// Indicates if the repository displays a Sponsor button for financial contributions.
        hasSponsorshipsEnabled: Option<bool>
    }

/// Autogenerated input type of UpdateRepositoryRuleset
type UpdateRepositoryRulesetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The global relay id of the repository ruleset to be updated.
        repositoryRulesetId: string
        /// The name of the ruleset.
        name: Option<string>
        /// The target of the ruleset.
        target: Option<RepositoryRulesetTarget>
        /// The list of rules for this ruleset
        rules: Option<list<RepositoryRuleInput>>
        /// The list of conditions for this ruleset
        conditions: Option<RepositoryRuleConditionsInput>
        /// The enforcement level for this ruleset
        enforcement: Option<RuleEnforcement>
        /// A list of actors that are allowed to bypass rules in this ruleset.
        bypassActors: Option<list<RepositoryRulesetBypassActorInput>>
    }

/// Autogenerated input type of UpdateRepositoryWebCommitSignoffSetting
type UpdateRepositoryWebCommitSignoffSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the repository to update.
        repositoryId: string
        /// Indicates if the repository should require signoff on web-based commits.
        webCommitSignoffRequired: bool
    }

/// Autogenerated input type of UpdateSponsorshipPreferences
type UpdateSponsorshipPreferencesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorLogin is not given.
        sponsorId: Option<string>
        /// The username of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorId is not given.
        sponsorLogin: Option<string>
        /// The ID of the user or organization who is receiving the sponsorship. Required if sponsorableLogin is not given.
        sponsorableId: Option<string>
        /// The username of the user or organization who is receiving the sponsorship. Required if sponsorableId is not given.
        sponsorableLogin: Option<string>
        /// Whether the sponsor should receive email updates from the sponsorable.
        receiveEmails: Option<bool>
        /// Specify whether others should be able to see that the sponsor is sponsoring the sponsorable. Public visibility still does not reveal which tier is used.
        privacyLevel: Option<SponsorshipPrivacy>
    }

/// Autogenerated input type of UpdateSubscription
type UpdateSubscriptionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the subscribable object to modify.
        subscribableId: string
        /// The new state of the subscription.
        state: SubscriptionState
    }

/// Autogenerated input type of UpdateTeamDiscussionComment
type UpdateTeamDiscussionCommentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the comment to modify.
        id: string
        /// The updated text of the comment.
        body: string
        /// The current version of the body content.
        bodyVersion: Option<string>
    }

/// Autogenerated input type of UpdateTeamDiscussion
type UpdateTeamDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the discussion to modify.
        id: string
        /// The updated title of the discussion.
        title: Option<string>
        /// The updated text of the discussion.
        body: Option<string>
        /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
        bodyVersion: Option<string>
        /// If provided, sets the pinned state of the updated discussion.
        pinned: Option<bool>
    }

/// Autogenerated input type of UpdateTeamReviewAssignment
type UpdateTeamReviewAssignmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the team to update review assignments of
        id: string
        /// Turn on or off review assignment
        enabled: bool
        /// The algorithm to use for review assignment
        algorithm: Option<TeamReviewAssignmentAlgorithm>
        /// The number of team members to assign
        teamMemberCount: Option<int>
        /// Notify the entire team of the PR if it is delegated
        notifyTeam: Option<bool>
        /// Remove the team review request when assigning
        removeTeamRequest: Option<bool>
        /// Include the members of any child teams when assigning
        includeChildTeamMembers: Option<bool>
        /// Count any members whose review has already been requested against the required number of members assigned to review
        countMembersAlreadyRequested: Option<bool>
        /// An array of team member IDs to exclude
        excludedTeamMemberIds: Option<list<string>>
    }

/// Autogenerated input type of UpdateTeamsRepository
type UpdateTeamsRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Repository ID being granted access to.
        repositoryId: string
        /// A list of teams being granted access. Limit: 10
        teamIds: list<string>
        /// Permission that should be granted to the teams.
        permission: RepositoryPermission
    }

/// Autogenerated input type of UpdateTopics
type UpdateTopicsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The Node ID of the repository.
        repositoryId: string
        /// An array of topic names.
        topicNames: list<string>
    }

/// Autogenerated input type of UpdateUserList
type UpdateUserListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the list to update.
        listId: string
        /// The name of the list
        name: Option<string>
        /// A description of the list
        description: Option<string>
        /// Whether or not the list is private
        isPrivate: Option<bool>
    }

/// Autogenerated input type of UpdateUserListsForItem
type UpdateUserListsForItemInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The item to add to the list
        itemId: string
        /// The lists to which this item should belong
        listIds: list<string>
        /// The suggested lists to create and add this item to
        suggestedListIds: Option<list<string>>
    }

/// Ordering options for user status connections.
type UserStatusOrder =
    {
        /// The field to order user statuses by.
        field: UserStatusOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Ordering options for verifiable domain connections.
type VerifiableDomainOrder =
    {
        /// The field to order verifiable domains by.
        field: VerifiableDomainOrderField
        /// The ordering direction.
        direction: OrderDirection
    }

/// Autogenerated input type of VerifyVerifiableDomain
type VerifyVerifiableDomainInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// The ID of the verifiable domain to verify.
        id: string
    }

/// A workflow that must run for this rule to pass
type WorkflowFileReferenceInput =
    {
        /// The path to the workflow file
        path: string
        /// The ref (branch or tag) of the workflow file to use
        ref: Option<string>
        /// The ID of the repository where the workflow is defined
        repositoryId: int
        /// The commit SHA of the workflow file to use
        sha: Option<string>
    }

/// Ways in which lists of workflow runs can be ordered upon return.
type WorkflowRunOrder =
    {
        /// The field by which to order workflows.
        field: WorkflowRunOrderField
        /// The direction in which to order workflow runs by the specified field.
        direction: OrderDirection
    }

/// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
type WorkflowsParametersInput =
    {
        /// Allow repositories and branches to be created if a check would otherwise prohibit it.
        doNotEnforceOnCreate: Option<bool>
        /// Workflows that must pass for this rule to pass.
        workflows: list<WorkflowFileReferenceInput>
    }

/// The error returned by the GraphQL backend
type ErrorType = { message: string }
