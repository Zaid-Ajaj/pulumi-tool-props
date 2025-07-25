[<RequireQualifiedAccess>]
module rec Github.IssueDetails

type InputVariables = { id: string }

/// Represents an 'added_to_merge_queue' event on a given pull request.
type AddedToMergeQueueEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'added_to_project' event on a given issue or pull request.
type AddedToProjectEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub App.
type App =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'assigned' event on any assignable object.
type AssignedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'auto_merge_disabled' event on a given pull request.
type AutoMergeDisabledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'auto_merge_enabled' event on a given pull request.
type AutoMergeEnabledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'auto_rebase_enabled' event on a given pull request.
type AutoRebaseEnabledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'auto_squash_enabled' event on a given pull request.
type AutoSquashEnabledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'automatic_base_change_failed' event on a given pull request.
type AutomaticBaseChangeFailedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'automatic_base_change_succeeded' event on a given pull request.
type AutomaticBaseChangeSucceededEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'base_ref_changed' event on a given issue or pull request.
type BaseRefChangedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'base_ref_deleted' event on a given pull request.
type BaseRefDeletedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'base_ref_force_pushed' event on a given pull request.
type BaseRefForcePushedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Git blob.
type Blob =
    {
        ///The name of the type
        __typename: string
    }

/// A special type of user which takes actions on behalf of GitHub Apps.
type Bot =
    {
        ///The name of the type
        __typename: string
    }

/// A branch protection rule.
type BranchProtectionRule =
    {
        ///The name of the type
        __typename: string
    }

/// A user, team, or app who has the ability to bypass a force push requirement on a protected branch.
type BypassForcePushAllowance =
    {
        ///The name of the type
        __typename: string
    }

/// A user, team, or app who has the ability to bypass a pull request requirement on a protected branch.
type BypassPullRequestAllowance =
    {
        ///The name of the type
        __typename: string
    }

/// A common weakness enumeration
type CWE =
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

/// A check suite.
type CheckSuite =
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

/// The Code of Conduct for a repository
type CodeOfConduct =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'comment_deleted' event on a given issue or pull request.
type CommentDeletedEvent =
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

/// Represents a comment on a given Commit.
type CommitComment =
    {
        ///The name of the type
        __typename: string
    }

/// A thread of comments on a commit.
type CommitCommentThread =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a comparison between two commit revisions.
type Comparison =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'connected' event on a given issue or pull request.
type ConnectedEvent =
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

/// Represents a 'converted_note_to_issue' event on a given issue or pull request.
type ConvertedNoteToIssueEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'converted_to_discussion' event on a given issue.
type ConvertedToDiscussionEvent =
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

/// Represents a 'demilestoned' event on a given issue or pull request.
type DemilestonedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Dependency manifest for a repository
type DependencyGraphManifest =
    {
        ///The name of the type
        __typename: string
    }

/// A repository deploy key.
type DeployKey =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'deployed' event on a given pull request.
type DeployedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents triggered deployment instance.
type Deployment =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'deployment_environment_changed' event on a given pull request.
type DeploymentEnvironmentChangedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A deployment review.
type DeploymentReview =
    {
        ///The name of the type
        __typename: string
    }

/// Describes the status of a given deployment attempt.
type DeploymentStatus =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'disconnected' event on a given issue or pull request.
type DisconnectedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A discussion in a repository.
type Discussion =
    {
        ///The name of the type
        __typename: string
    }

/// A category for discussions in a repository.
type DiscussionCategory =
    {
        ///The name of the type
        __typename: string
    }

/// A comment on a discussion.
type DiscussionComment =
    {
        ///The name of the type
        __typename: string
    }

/// A poll for a discussion.
type DiscussionPoll =
    {
        ///The name of the type
        __typename: string
    }

/// An option for a discussion poll.
type DiscussionPollOption =
    {
        ///The name of the type
        __typename: string
    }

/// A draft issue within a project.
type DraftIssue =
    {
        ///The name of the type
        __typename: string
    }

/// An account to manage multiple organizations with consolidated policy and billing.
type Enterprise =
    {
        ///The name of the type
        __typename: string
    }

/// An invitation for a user to become an owner or billing manager of an enterprise.
type EnterpriseAdministratorInvitation =
    {
        ///The name of the type
        __typename: string
    }

/// An identity provider configured to provision identities for an enterprise. Visible to enterprise owners or enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
type EnterpriseIdentityProvider =
    {
        ///The name of the type
        __typename: string
    }

/// An invitation for a user to become an unaffiliated member of an enterprise.
type EnterpriseMemberInvitation =
    {
        ///The name of the type
        __typename: string
    }

/// A subset of repository information queryable from an enterprise.
type EnterpriseRepositoryInfo =
    {
        ///The name of the type
        __typename: string
    }

/// An Enterprise Server installation.
type EnterpriseServerInstallation =
    {
        ///The name of the type
        __typename: string
    }

/// A user account on an Enterprise Server installation.
type EnterpriseServerUserAccount =
    {
        ///The name of the type
        __typename: string
    }

/// An email belonging to a user account on an Enterprise Server installation.
type EnterpriseServerUserAccountEmail =
    {
        ///The name of the type
        __typename: string
    }

/// A user accounts upload from an Enterprise Server installation.
type EnterpriseServerUserAccountsUpload =
    {
        ///The name of the type
        __typename: string
    }

/// An account for a user who is an admin of an enterprise or a member of an enterprise through one or more organizations.
type EnterpriseUserAccount =
    {
        ///The name of the type
        __typename: string
    }

/// An environment.
type Environment =
    {
        ///The name of the type
        __typename: string
    }

/// An external identity provisioned by SAML SSO or SCIM. If SAML is configured on the organization, the external identity is visible to (1) organization owners, (2) organization owners' personal access tokens (classic) with read:org or admin:org scope, (3) GitHub App with an installation token with read or write access to members. If SAML is configured on the enterprise, the external identity is visible to (1) enterprise owners, (2) enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
type ExternalIdentity =
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

/// Represents a comment on an Gist.
type GistComment =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'head_ref_deleted' event on a given pull request.
type HeadRefDeletedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'head_ref_force_pushed' event on a given pull request.
type HeadRefForcePushedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'head_ref_restored' event on a given pull request.
type HeadRefRestoredEvent =
    {
        ///The name of the type
        __typename: string
    }

/// An IP address or range of addresses that is allowed to access an owner's resources.
type IpAllowListEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a comment on an Issue.
type IssueComment =
    {
        ///The name of the type
        __typename: string
    }

/// Represents the type of Issue.
type IssueType =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'issue_type_added' event on a given issue.
type IssueTypeAddedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'issue_type_changed' event on a given issue.
type IssueTypeChangedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'issue_type_removed' event on a given issue.
type IssueTypeRemovedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A label for categorizing Issues, Pull Requests, Milestones, or Discussions with a given Repository.
type Label =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'labeled' event on a given issue or pull request.
type LabeledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a given language found in repositories.
type Language =
    {
        ///The name of the type
        __typename: string
    }

/// A repository's open source license
type License =
    {
        ///The name of the type
        __typename: string
    }

/// A branch linked to an issue.
type LinkedBranch =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'locked' event on a given issue or pull request.
type LockedEvent =
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

/// Represents a 'marked_as_duplicate' event on a given issue or pull request.
type MarkedAsDuplicateEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A public description of a Marketplace category.
type MarketplaceCategory =
    {
        ///The name of the type
        __typename: string
    }

/// A listing in the GitHub integration marketplace.
type MarketplaceListing =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a member feature request notification
type MemberFeatureRequestNotification =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a members_can_delete_repos.clear event.
type MembersCanDeleteReposClearAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a members_can_delete_repos.disable event.
type MembersCanDeleteReposDisableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a members_can_delete_repos.enable event.
type MembersCanDeleteReposEnableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'mentioned' event on a given issue or pull request.
type MentionedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// The queue of pull request entries to be merged into a protected branch in a repository.
type MergeQueue =
    {
        ///The name of the type
        __typename: string
    }

/// Entries in a MergeQueue
type MergeQueueEntry =
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

/// A GitHub Enterprise Importer (GEI) migration source.
type MigrationSource =
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

/// Represents a 'milestoned' event on a given issue or pull request.
type MilestonedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'moved_columns_in_project' event on a given issue or pull request.
type MovedColumnsInProjectEvent =
    {
        ///The name of the type
        __typename: string
    }

/// An OIDC identity provider configured to provision identities for an enterprise. Visible to enterprise owners or enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
type OIDCProvider =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a oauth_application.create event.
type OauthApplicationCreateAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.add_billing_manager
type OrgAddBillingManagerAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.add_member
type OrgAddMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.block_user
type OrgBlockUserAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.config.disable_collaborators_only event.
type OrgConfigDisableCollaboratorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.config.enable_collaborators_only event.
type OrgConfigEnableCollaboratorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.create event.
type OrgCreateAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.disable_oauth_app_restrictions event.
type OrgDisableOauthAppRestrictionsAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.disable_saml event.
type OrgDisableSamlAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.disable_two_factor_requirement event.
type OrgDisableTwoFactorRequirementAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.enable_oauth_app_restrictions event.
type OrgEnableOauthAppRestrictionsAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.enable_saml event.
type OrgEnableSamlAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.enable_two_factor_requirement event.
type OrgEnableTwoFactorRequirementAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.invite_member event.
type OrgInviteMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.invite_to_business event.
type OrgInviteToBusinessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.oauth_app_access_approved event.
type OrgOauthAppAccessApprovedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.oauth_app_access_blocked event.
type OrgOauthAppAccessBlockedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.oauth_app_access_denied event.
type OrgOauthAppAccessDeniedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.oauth_app_access_requested event.
type OrgOauthAppAccessRequestedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.oauth_app_access_unblocked event.
type OrgOauthAppAccessUnblockedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.remove_billing_manager event.
type OrgRemoveBillingManagerAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.remove_member event.
type OrgRemoveMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.remove_outside_collaborator event.
type OrgRemoveOutsideCollaboratorAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.restore_member event.
type OrgRestoreMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.unblock_user
type OrgUnblockUserAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.update_default_repository_permission
type OrgUpdateDefaultRepositoryPermissionAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.update_member event.
type OrgUpdateMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.update_member_repository_creation_permission event.
type OrgUpdateMemberRepositoryCreationPermissionAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a org.update_member_repository_invitation_permission event.
type OrgUpdateMemberRepositoryInvitationPermissionAuditEntry =
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

/// An Identity Provider configured to provision SAML and SCIM identities for Organizations. Visible to (1) organization owners, (2) organization owners' personal access tokens (classic) with read:org or admin:org scope, (3) GitHub App with an installation token with read or write access to members.
type OrganizationIdentityProvider =
    {
        ///The name of the type
        __typename: string
    }

/// An Invitation for a user to an organization.
type OrganizationInvitation =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub Enterprise Importer (GEI) organization migration.
type OrganizationMigration =
    {
        ///The name of the type
        __typename: string
    }

/// Information for an uploaded package.
type Package =
    {
        ///The name of the type
        __typename: string
    }

/// A file in a package version.
type PackageFile =
    {
        ///The name of the type
        __typename: string
    }

/// A version tag contains the mapping between a tag name and a version.
type PackageTag =
    {
        ///The name of the type
        __typename: string
    }

/// Information about a specific package version.
type PackageVersion =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'parent_issue_added' event on a given issue.
type ParentIssueAddedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'parent_issue_removed' event on a given issue.
type ParentIssueRemovedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A Pinned Discussion is a discussion pinned to a repository's index page.
type PinnedDiscussion =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a pinned environment on a given repository
type PinnedEnvironment =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'pinned' event on a given issue or pull request.
type PinnedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A Pinned Issue is a issue pinned to a repository's index page.
type PinnedIssue =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a private_repository_forking.disable event.
type PrivateRepositoryForkingDisableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a private_repository_forking.enable event.
type PrivateRepositoryForkingEnableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Projects manage issues, pull requests and notes within a project owner.
type Project =
    {
        ///The name of the type
        __typename: string
    }

/// A card in a project.
type ProjectCard =
    {
        ///The name of the type
        __typename: string
    }

/// A column inside a project.
type ProjectColumn =
    {
        ///The name of the type
        __typename: string
    }

/// New projects that manage issues, pull requests and drafts using tables and boards.
type ProjectV2 =
    {
        ///The name of the type
        __typename: string
    }

/// A field inside a project.
type ProjectV2Field =
    {
        ///The name of the type
        __typename: string
    }

/// An item within a Project.
type ProjectV2Item =
    {
        ///The name of the type
        __typename: string
    }

/// The value of a date field in a Project item.
type ProjectV2ItemFieldDateValue =
    {
        ///The name of the type
        __typename: string
    }

/// The value of an iteration field in a Project item.
type ProjectV2ItemFieldIterationValue =
    {
        ///The name of the type
        __typename: string
    }

/// The value of a number field in a Project item.
type ProjectV2ItemFieldNumberValue =
    {
        ///The name of the type
        __typename: string
    }

/// The value of a single select field in a Project item.
type ProjectV2ItemFieldSingleSelectValue =
    {
        ///The name of the type
        __typename: string
    }

/// The value of a text field in a Project item.
type ProjectV2ItemFieldTextValue =
    {
        ///The name of the type
        __typename: string
    }

/// An iteration field inside a project.
type ProjectV2IterationField =
    {
        ///The name of the type
        __typename: string
    }

/// A single select field inside a project.
type ProjectV2SingleSelectField =
    {
        ///The name of the type
        __typename: string
    }

/// A status update within a project.
type ProjectV2StatusUpdate =
    {
        ///The name of the type
        __typename: string
    }

/// A view within a ProjectV2.
type ProjectV2View =
    {
        ///The name of the type
        __typename: string
    }

/// A workflow inside a project.
type ProjectV2Workflow =
    {
        ///The name of the type
        __typename: string
    }

/// A user's public key.
type PublicKey =
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

/// Represents a commit comment thread part of a pull request.
type PullRequestCommitCommentThread =
    {
        ///The name of the type
        __typename: string
    }

/// A review object for a given pull request.
type PullRequestReview =
    {
        ///The name of the type
        __typename: string
    }

/// A review comment associated with a given repository pull request.
type PullRequestReviewComment =
    {
        ///The name of the type
        __typename: string
    }

/// A threaded list of comments for a given pull request.
type PullRequestReviewThread =
    {
        ///The name of the type
        __typename: string
    }

/// A threaded list of comments for a given pull request.
type PullRequestThread =
    {
        ///The name of the type
        __typename: string
    }

/// A Git push.
type Push =
    {
        ///The name of the type
        __typename: string
    }

/// A team, user, or app who has the ability to push to a protected branch.
type PushAllowance =
    {
        ///The name of the type
        __typename: string
    }

/// An emoji reaction to a particular piece of content.
type Reaction =
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

/// Represents a Git reference.
type Ref =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'referenced' event on a given `ReferencedSubject`.
type ReferencedEvent =
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

/// A release asset contains the content for a release asset.
type ReleaseAsset =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'removed_from_merge_queue' event on a given pull request.
type RemovedFromMergeQueueEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'removed_from_project' event on a given issue or pull request.
type RemovedFromProjectEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'renamed' event on a given issue or pull request
type RenamedTitleEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'reopened' event on any `Closable`.
type ReopenedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.access event.
type RepoAccessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.add_member event.
type RepoAddMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.add_topic event.
type RepoAddTopicAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.archived event.
type RepoArchivedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.change_merge_setting event.
type RepoChangeMergeSettingAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.disable_anonymous_git_access event.
type RepoConfigDisableAnonymousGitAccessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.disable_collaborators_only event.
type RepoConfigDisableCollaboratorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.disable_contributors_only event.
type RepoConfigDisableContributorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.disable_sockpuppet_disallowed event.
type RepoConfigDisableSockpuppetDisallowedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.enable_anonymous_git_access event.
type RepoConfigEnableAnonymousGitAccessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.enable_collaborators_only event.
type RepoConfigEnableCollaboratorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.enable_contributors_only event.
type RepoConfigEnableContributorsOnlyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.enable_sockpuppet_disallowed event.
type RepoConfigEnableSockpuppetDisallowedAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.lock_anonymous_git_access event.
type RepoConfigLockAnonymousGitAccessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.config.unlock_anonymous_git_access event.
type RepoConfigUnlockAnonymousGitAccessAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.create event.
type RepoCreateAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.destroy event.
type RepoDestroyAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.remove_member event.
type RepoRemoveMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repo.remove_topic event.
type RepoRemoveTopicAuditEntry =
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

/// An invitation for a user to be added to a repository.
type RepositoryInvitation =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub Enterprise Importer (GEI) repository migration.
type RepositoryMigration =
    {
        ///The name of the type
        __typename: string
    }

/// A repository rule.
type RepositoryRule =
    {
        ///The name of the type
        __typename: string
    }

/// A repository ruleset.
type RepositoryRuleset =
    {
        ///The name of the type
        __typename: string
    }

/// A team or app that has the ability to bypass a rules defined on a ruleset
type RepositoryRulesetBypassActor =
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

/// Audit log entry for a repository_visibility_change.disable event.
type RepositoryVisibilityChangeDisableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a repository_visibility_change.enable event.
type RepositoryVisibilityChangeEnableAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// A Dependabot alert for a repository with a dependency affected by a security vulnerability.
type RepositoryVulnerabilityAlert =
    {
        ///The name of the type
        __typename: string
    }

/// A user, team, or app who has the ability to dismiss a review on a protected branch.
type ReviewDismissalAllowance =
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

/// A request for a user to review a pull request.
type ReviewRequest =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'review_request_removed' event on a given pull request.
type ReviewRequestRemovedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'review_requested' event on a given pull request.
type ReviewRequestedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// A Saved Reply is text a user can use to reply quickly.
type SavedReply =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub Security Advisory
type SecurityAdvisory =
    {
        ///The name of the type
        __typename: string
    }

/// An event related to sponsorship activity.
type SponsorsActivity =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub Sponsors listing.
type SponsorsListing =
    {
        ///The name of the type
        __typename: string
    }

/// A record that is promoted on a GitHub Sponsors profile.
type SponsorsListingFeaturedItem =
    {
        ///The name of the type
        __typename: string
    }

/// A GitHub Sponsors tier associated with a GitHub Sponsors listing.
type SponsorsTier =
    {
        ///The name of the type
        __typename: string
    }

/// A sponsorship relationship between a sponsor and a maintainer
type Sponsorship =
    {
        ///The name of the type
        __typename: string
    }

/// An update sent to sponsors of a user or organization on GitHub Sponsors.
type SponsorshipNewsletter =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a commit status.
type Status =
    {
        ///The name of the type
        __typename: string
    }

/// Represents the rollup for both the check runs and status for a commit.
type StatusCheckRollup =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an individual commit status context
type StatusContext =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'sub_issue_added' event on a given issue.
type SubIssueAddedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'sub_issue_removed' event on a given issue.
type SubIssueRemovedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'subscribed' event on a given `Subscribable`.
type SubscribedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Git tag.
type Tag =
    {
        ///The name of the type
        __typename: string
    }

/// A team of users in an organization.
type Team =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a team.add_member event.
type TeamAddMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a team.add_repository event.
type TeamAddRepositoryAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a team.change_parent_team event.
type TeamChangeParentTeamAuditEntry =
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

/// Audit log entry for a team.remove_member event.
type TeamRemoveMemberAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// Audit log entry for a team.remove_repository event.
type TeamRemoveRepositoryAuditEntry =
    {
        ///The name of the type
        __typename: string
    }

/// A topic aggregates entities that are related to a subject.
type Topic =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a 'transferred' event on a given issue or pull request.
type TransferredEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents a Git tree.
type Tree =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unassigned' event on any assignable object.
type UnassignedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unlabeled' event on a given issue or pull request.
type UnlabeledEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unlocked' event on a given issue or pull request.
type UnlockedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
type UnmarkedAsDuplicateEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unpinned' event on a given issue or pull request.
type UnpinnedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// Represents an 'unsubscribed' event on a given `Subscribable`.
type UnsubscribedEvent =
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

/// Represents a 'user_blocked' event on a given user.
type UserBlockedEvent =
    {
        ///The name of the type
        __typename: string
    }

/// An edit on user content
type UserContentEdit =
    {
        ///The name of the type
        __typename: string
    }

/// A user-curated list of repositories
type UserList =
    {
        ///The name of the type
        __typename: string
    }

/// A repository owned by an Enterprise Managed user.
type UserNamespaceRepository =
    {
        ///The name of the type
        __typename: string
    }

/// The user's description of what they're currently doing.
type UserStatus =
    {
        ///The name of the type
        __typename: string
    }

/// A domain that can be verified or approved for an organization or an enterprise.
type VerifiableDomain =
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

/// A workflow run.
type WorkflowRun =
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
type Nodes =
    {
        /// The username used to login.
        login: string
    }

/// A list of Users assigned to this object.
type UserConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<Nodes>>>
    }

/// The actor who authored the comment.
type Actor =
    {
        /// The username of the actor.
        login: string
    }

/// A list of nodes.
type NodesFromIssueComment =
    {
        /// The actor who authored the comment.
        author: Option<Actor>
        /// Identifies the date and time when the object was created.
        createdAt: System.DateTime
        /// The body as Markdown.
        body: string
        /// The body rendered to HTML.
        bodyHTML: string
    }

/// A list of comments associated with the Issue.
type IssueCommentConnection =
    {
        /// A list of nodes.
        nodes: Option<list<Option<NodesFromIssueComment>>>
    }

/// The actor who authored the comment.
type Author =
    {
        /// The username of the actor.
        login: string
    }

/// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
type Issue =
    {
        ///The name of the type
        __typename: string
        /// Identifies the issue title.
        title: string
        /// The Node ID of the Issue object
        id: string
        /// The HTTP URL for this issue
        url: string
        /// Identifies the body of the issue.
        body: string
        /// The body rendered to HTML.
        bodyHTML: string
        /// Identifies the date and time when the object was created.
        createdAt: System.DateTime
        /// A list of Users assigned to this object.
        assignees: UserConnection
        /// A list of comments associated with the Issue.
        comments: IssueCommentConnection
        /// The actor who authored the comment.
        author: Option<Author>
    }

/// The query root of GitHub's GraphQL interface.
[<RequireQualifiedAccess>]
type Node =
    | AddedToMergeQueueEvent of addedtomergequeueevent: AddedToMergeQueueEvent
    | AddedToProjectEvent of addedtoprojectevent: AddedToProjectEvent
    | App of app: App
    | AssignedEvent of assignedevent: AssignedEvent
    | AutoMergeDisabledEvent of automergedisabledevent: AutoMergeDisabledEvent
    | AutoMergeEnabledEvent of automergeenabledevent: AutoMergeEnabledEvent
    | AutoRebaseEnabledEvent of autorebaseenabledevent: AutoRebaseEnabledEvent
    | AutoSquashEnabledEvent of autosquashenabledevent: AutoSquashEnabledEvent
    | AutomaticBaseChangeFailedEvent of automaticbasechangefailedevent: AutomaticBaseChangeFailedEvent
    | AutomaticBaseChangeSucceededEvent of automaticbasechangesucceededevent: AutomaticBaseChangeSucceededEvent
    | BaseRefChangedEvent of baserefchangedevent: BaseRefChangedEvent
    | BaseRefDeletedEvent of baserefdeletedevent: BaseRefDeletedEvent
    | BaseRefForcePushedEvent of baserefforcepushedevent: BaseRefForcePushedEvent
    | Blob of blob: Blob
    | Bot of bot: Bot
    | BranchProtectionRule of branchprotectionrule: BranchProtectionRule
    | BypassForcePushAllowance of bypassforcepushallowance: BypassForcePushAllowance
    | BypassPullRequestAllowance of bypasspullrequestallowance: BypassPullRequestAllowance
    | CWE of cwe: CWE
    | CheckRun of checkrun: CheckRun
    | CheckSuite of checksuite: CheckSuite
    | ClosedEvent of closedevent: ClosedEvent
    | CodeOfConduct of codeofconduct: CodeOfConduct
    | CommentDeletedEvent of commentdeletedevent: CommentDeletedEvent
    | Commit of commit: Commit
    | CommitComment of commitcomment: CommitComment
    | CommitCommentThread of commitcommentthread: CommitCommentThread
    | Comparison of comparison: Comparison
    | ConnectedEvent of connectedevent: ConnectedEvent
    | ConvertToDraftEvent of converttodraftevent: ConvertToDraftEvent
    | ConvertedNoteToIssueEvent of convertednotetoissueevent: ConvertedNoteToIssueEvent
    | ConvertedToDiscussionEvent of convertedtodiscussionevent: ConvertedToDiscussionEvent
    | CrossReferencedEvent of crossreferencedevent: CrossReferencedEvent
    | DemilestonedEvent of demilestonedevent: DemilestonedEvent
    | DependencyGraphManifest of dependencygraphmanifest: DependencyGraphManifest
    | DeployKey of deploykey: DeployKey
    | DeployedEvent of deployedevent: DeployedEvent
    | Deployment of deployment: Deployment
    | DeploymentEnvironmentChangedEvent of deploymentenvironmentchangedevent: DeploymentEnvironmentChangedEvent
    | DeploymentReview of deploymentreview: DeploymentReview
    | DeploymentStatus of deploymentstatus: DeploymentStatus
    | DisconnectedEvent of disconnectedevent: DisconnectedEvent
    | Discussion of discussion: Discussion
    | DiscussionCategory of discussioncategory: DiscussionCategory
    | DiscussionComment of discussioncomment: DiscussionComment
    | DiscussionPoll of discussionpoll: DiscussionPoll
    | DiscussionPollOption of discussionpolloption: DiscussionPollOption
    | DraftIssue of draftissue: DraftIssue
    | Enterprise of enterprise: Enterprise
    | EnterpriseAdministratorInvitation of enterpriseadministratorinvitation: EnterpriseAdministratorInvitation
    | EnterpriseIdentityProvider of enterpriseidentityprovider: EnterpriseIdentityProvider
    | EnterpriseMemberInvitation of enterprisememberinvitation: EnterpriseMemberInvitation
    | EnterpriseRepositoryInfo of enterpriserepositoryinfo: EnterpriseRepositoryInfo
    | EnterpriseServerInstallation of enterpriseserverinstallation: EnterpriseServerInstallation
    | EnterpriseServerUserAccount of enterpriseserveruseraccount: EnterpriseServerUserAccount
    | EnterpriseServerUserAccountEmail of enterpriseserveruseraccountemail: EnterpriseServerUserAccountEmail
    | EnterpriseServerUserAccountsUpload of enterpriseserveruseraccountsupload: EnterpriseServerUserAccountsUpload
    | EnterpriseUserAccount of enterpriseuseraccount: EnterpriseUserAccount
    | Environment of environment: Environment
    | ExternalIdentity of externalidentity: ExternalIdentity
    | Gist of gist: Gist
    | GistComment of gistcomment: GistComment
    | HeadRefDeletedEvent of headrefdeletedevent: HeadRefDeletedEvent
    | HeadRefForcePushedEvent of headrefforcepushedevent: HeadRefForcePushedEvent
    | HeadRefRestoredEvent of headrefrestoredevent: HeadRefRestoredEvent
    | IpAllowListEntry of ipallowlistentry: IpAllowListEntry
    | IssueComment of issuecomment: IssueComment
    | IssueType of issuetype: IssueType
    | IssueTypeAddedEvent of issuetypeaddedevent: IssueTypeAddedEvent
    | IssueTypeChangedEvent of issuetypechangedevent: IssueTypeChangedEvent
    | IssueTypeRemovedEvent of issuetyperemovedevent: IssueTypeRemovedEvent
    | Label of label: Label
    | LabeledEvent of labeledevent: LabeledEvent
    | Language of language: Language
    | License of license: License
    | LinkedBranch of linkedbranch: LinkedBranch
    | LockedEvent of lockedevent: LockedEvent
    | Mannequin of mannequin: Mannequin
    | MarkedAsDuplicateEvent of markedasduplicateevent: MarkedAsDuplicateEvent
    | MarketplaceCategory of marketplacecategory: MarketplaceCategory
    | MarketplaceListing of marketplacelisting: MarketplaceListing
    | MemberFeatureRequestNotification of memberfeaturerequestnotification: MemberFeatureRequestNotification
    | MembersCanDeleteReposClearAuditEntry of memberscandeletereposclearauditentry: MembersCanDeleteReposClearAuditEntry
    | MembersCanDeleteReposDisableAuditEntry of
        memberscandeletereposdisableauditentry: MembersCanDeleteReposDisableAuditEntry
    | MembersCanDeleteReposEnableAuditEntry of
        memberscandeletereposenableauditentry: MembersCanDeleteReposEnableAuditEntry
    | MentionedEvent of mentionedevent: MentionedEvent
    | MergeQueue of mergequeue: MergeQueue
    | MergeQueueEntry of mergequeueentry: MergeQueueEntry
    | MergedEvent of mergedevent: MergedEvent
    | MigrationSource of migrationsource: MigrationSource
    | Milestone of milestone: Milestone
    | MilestonedEvent of milestonedevent: MilestonedEvent
    | MovedColumnsInProjectEvent of movedcolumnsinprojectevent: MovedColumnsInProjectEvent
    | OIDCProvider of oidcprovider: OIDCProvider
    | OauthApplicationCreateAuditEntry of oauthapplicationcreateauditentry: OauthApplicationCreateAuditEntry
    | OrgAddBillingManagerAuditEntry of orgaddbillingmanagerauditentry: OrgAddBillingManagerAuditEntry
    | OrgAddMemberAuditEntry of orgaddmemberauditentry: OrgAddMemberAuditEntry
    | OrgBlockUserAuditEntry of orgblockuserauditentry: OrgBlockUserAuditEntry
    | OrgConfigDisableCollaboratorsOnlyAuditEntry of
        orgconfigdisablecollaboratorsonlyauditentry: OrgConfigDisableCollaboratorsOnlyAuditEntry
    | OrgConfigEnableCollaboratorsOnlyAuditEntry of
        orgconfigenablecollaboratorsonlyauditentry: OrgConfigEnableCollaboratorsOnlyAuditEntry
    | OrgCreateAuditEntry of orgcreateauditentry: OrgCreateAuditEntry
    | OrgDisableOauthAppRestrictionsAuditEntry of
        orgdisableoauthapprestrictionsauditentry: OrgDisableOauthAppRestrictionsAuditEntry
    | OrgDisableSamlAuditEntry of orgdisablesamlauditentry: OrgDisableSamlAuditEntry
    | OrgDisableTwoFactorRequirementAuditEntry of
        orgdisabletwofactorrequirementauditentry: OrgDisableTwoFactorRequirementAuditEntry
    | OrgEnableOauthAppRestrictionsAuditEntry of
        orgenableoauthapprestrictionsauditentry: OrgEnableOauthAppRestrictionsAuditEntry
    | OrgEnableSamlAuditEntry of orgenablesamlauditentry: OrgEnableSamlAuditEntry
    | OrgEnableTwoFactorRequirementAuditEntry of
        orgenabletwofactorrequirementauditentry: OrgEnableTwoFactorRequirementAuditEntry
    | OrgInviteMemberAuditEntry of orginvitememberauditentry: OrgInviteMemberAuditEntry
    | OrgInviteToBusinessAuditEntry of orginvitetobusinessauditentry: OrgInviteToBusinessAuditEntry
    | OrgOauthAppAccessApprovedAuditEntry of orgoauthappaccessapprovedauditentry: OrgOauthAppAccessApprovedAuditEntry
    | OrgOauthAppAccessBlockedAuditEntry of orgoauthappaccessblockedauditentry: OrgOauthAppAccessBlockedAuditEntry
    | OrgOauthAppAccessDeniedAuditEntry of orgoauthappaccessdeniedauditentry: OrgOauthAppAccessDeniedAuditEntry
    | OrgOauthAppAccessRequestedAuditEntry of orgoauthappaccessrequestedauditentry: OrgOauthAppAccessRequestedAuditEntry
    | OrgOauthAppAccessUnblockedAuditEntry of orgoauthappaccessunblockedauditentry: OrgOauthAppAccessUnblockedAuditEntry
    | OrgRemoveBillingManagerAuditEntry of orgremovebillingmanagerauditentry: OrgRemoveBillingManagerAuditEntry
    | OrgRemoveMemberAuditEntry of orgremovememberauditentry: OrgRemoveMemberAuditEntry
    | OrgRemoveOutsideCollaboratorAuditEntry of
        orgremoveoutsidecollaboratorauditentry: OrgRemoveOutsideCollaboratorAuditEntry
    | OrgRestoreMemberAuditEntry of orgrestorememberauditentry: OrgRestoreMemberAuditEntry
    | OrgUnblockUserAuditEntry of orgunblockuserauditentry: OrgUnblockUserAuditEntry
    | OrgUpdateDefaultRepositoryPermissionAuditEntry of
        orgupdatedefaultrepositorypermissionauditentry: OrgUpdateDefaultRepositoryPermissionAuditEntry
    | OrgUpdateMemberAuditEntry of orgupdatememberauditentry: OrgUpdateMemberAuditEntry
    | OrgUpdateMemberRepositoryCreationPermissionAuditEntry of
        orgupdatememberrepositorycreationpermissionauditentry: OrgUpdateMemberRepositoryCreationPermissionAuditEntry
    | OrgUpdateMemberRepositoryInvitationPermissionAuditEntry of
        orgupdatememberrepositoryinvitationpermissionauditentry: OrgUpdateMemberRepositoryInvitationPermissionAuditEntry
    | Organization of organization: Organization
    | OrganizationIdentityProvider of organizationidentityprovider: OrganizationIdentityProvider
    | OrganizationInvitation of organizationinvitation: OrganizationInvitation
    | OrganizationMigration of organizationmigration: OrganizationMigration
    | Package of package: Package
    | PackageFile of packagefile: PackageFile
    | PackageTag of packagetag: PackageTag
    | PackageVersion of packageversion: PackageVersion
    | ParentIssueAddedEvent of parentissueaddedevent: ParentIssueAddedEvent
    | ParentIssueRemovedEvent of parentissueremovedevent: ParentIssueRemovedEvent
    | PinnedDiscussion of pinneddiscussion: PinnedDiscussion
    | PinnedEnvironment of pinnedenvironment: PinnedEnvironment
    | PinnedEvent of pinnedevent: PinnedEvent
    | PinnedIssue of pinnedissue: PinnedIssue
    | PrivateRepositoryForkingDisableAuditEntry of
        privaterepositoryforkingdisableauditentry: PrivateRepositoryForkingDisableAuditEntry
    | PrivateRepositoryForkingEnableAuditEntry of
        privaterepositoryforkingenableauditentry: PrivateRepositoryForkingEnableAuditEntry
    | Project of project: Project
    | ProjectCard of projectcard: ProjectCard
    | ProjectColumn of projectcolumn: ProjectColumn
    | ProjectV2 of projectv2: ProjectV2
    | ProjectV2Field of projectv2field: ProjectV2Field
    | ProjectV2Item of projectv2item: ProjectV2Item
    | ProjectV2ItemFieldDateValue of projectv2itemfielddatevalue: ProjectV2ItemFieldDateValue
    | ProjectV2ItemFieldIterationValue of projectv2itemfielditerationvalue: ProjectV2ItemFieldIterationValue
    | ProjectV2ItemFieldNumberValue of projectv2itemfieldnumbervalue: ProjectV2ItemFieldNumberValue
    | ProjectV2ItemFieldSingleSelectValue of projectv2itemfieldsingleselectvalue: ProjectV2ItemFieldSingleSelectValue
    | ProjectV2ItemFieldTextValue of projectv2itemfieldtextvalue: ProjectV2ItemFieldTextValue
    | ProjectV2IterationField of projectv2iterationfield: ProjectV2IterationField
    | ProjectV2SingleSelectField of projectv2singleselectfield: ProjectV2SingleSelectField
    | ProjectV2StatusUpdate of projectv2statusupdate: ProjectV2StatusUpdate
    | ProjectV2View of projectv2view: ProjectV2View
    | ProjectV2Workflow of projectv2workflow: ProjectV2Workflow
    | PublicKey of publickey: PublicKey
    | PullRequest of pullrequest: PullRequest
    | PullRequestCommit of pullrequestcommit: PullRequestCommit
    | PullRequestCommitCommentThread of pullrequestcommitcommentthread: PullRequestCommitCommentThread
    | PullRequestReview of pullrequestreview: PullRequestReview
    | PullRequestReviewComment of pullrequestreviewcomment: PullRequestReviewComment
    | PullRequestReviewThread of pullrequestreviewthread: PullRequestReviewThread
    | PullRequestThread of pullrequestthread: PullRequestThread
    | Push of push: Push
    | PushAllowance of pushallowance: PushAllowance
    | Query of query: Query
    | Reaction of reaction: Reaction
    | ReadyForReviewEvent of readyforreviewevent: ReadyForReviewEvent
    | Ref of ref: Ref
    | ReferencedEvent of referencedevent: ReferencedEvent
    | Release of release: Release
    | ReleaseAsset of releaseasset: ReleaseAsset
    | RemovedFromMergeQueueEvent of removedfrommergequeueevent: RemovedFromMergeQueueEvent
    | RemovedFromProjectEvent of removedfromprojectevent: RemovedFromProjectEvent
    | RenamedTitleEvent of renamedtitleevent: RenamedTitleEvent
    | ReopenedEvent of reopenedevent: ReopenedEvent
    | RepoAccessAuditEntry of repoaccessauditentry: RepoAccessAuditEntry
    | RepoAddMemberAuditEntry of repoaddmemberauditentry: RepoAddMemberAuditEntry
    | RepoAddTopicAuditEntry of repoaddtopicauditentry: RepoAddTopicAuditEntry
    | RepoArchivedAuditEntry of repoarchivedauditentry: RepoArchivedAuditEntry
    | RepoChangeMergeSettingAuditEntry of repochangemergesettingauditentry: RepoChangeMergeSettingAuditEntry
    | RepoConfigDisableAnonymousGitAccessAuditEntry of
        repoconfigdisableanonymousgitaccessauditentry: RepoConfigDisableAnonymousGitAccessAuditEntry
    | RepoConfigDisableCollaboratorsOnlyAuditEntry of
        repoconfigdisablecollaboratorsonlyauditentry: RepoConfigDisableCollaboratorsOnlyAuditEntry
    | RepoConfigDisableContributorsOnlyAuditEntry of
        repoconfigdisablecontributorsonlyauditentry: RepoConfigDisableContributorsOnlyAuditEntry
    | RepoConfigDisableSockpuppetDisallowedAuditEntry of
        repoconfigdisablesockpuppetdisallowedauditentry: RepoConfigDisableSockpuppetDisallowedAuditEntry
    | RepoConfigEnableAnonymousGitAccessAuditEntry of
        repoconfigenableanonymousgitaccessauditentry: RepoConfigEnableAnonymousGitAccessAuditEntry
    | RepoConfigEnableCollaboratorsOnlyAuditEntry of
        repoconfigenablecollaboratorsonlyauditentry: RepoConfigEnableCollaboratorsOnlyAuditEntry
    | RepoConfigEnableContributorsOnlyAuditEntry of
        repoconfigenablecontributorsonlyauditentry: RepoConfigEnableContributorsOnlyAuditEntry
    | RepoConfigEnableSockpuppetDisallowedAuditEntry of
        repoconfigenablesockpuppetdisallowedauditentry: RepoConfigEnableSockpuppetDisallowedAuditEntry
    | RepoConfigLockAnonymousGitAccessAuditEntry of
        repoconfiglockanonymousgitaccessauditentry: RepoConfigLockAnonymousGitAccessAuditEntry
    | RepoConfigUnlockAnonymousGitAccessAuditEntry of
        repoconfigunlockanonymousgitaccessauditentry: RepoConfigUnlockAnonymousGitAccessAuditEntry
    | RepoCreateAuditEntry of repocreateauditentry: RepoCreateAuditEntry
    | RepoDestroyAuditEntry of repodestroyauditentry: RepoDestroyAuditEntry
    | RepoRemoveMemberAuditEntry of reporemovememberauditentry: RepoRemoveMemberAuditEntry
    | RepoRemoveTopicAuditEntry of reporemovetopicauditentry: RepoRemoveTopicAuditEntry
    | Repository of repository: Repository
    | RepositoryInvitation of repositoryinvitation: RepositoryInvitation
    | RepositoryMigration of repositorymigration: RepositoryMigration
    | RepositoryRule of repositoryrule: RepositoryRule
    | RepositoryRuleset of repositoryruleset: RepositoryRuleset
    | RepositoryRulesetBypassActor of repositoryrulesetbypassactor: RepositoryRulesetBypassActor
    | RepositoryTopic of repositorytopic: RepositoryTopic
    | RepositoryVisibilityChangeDisableAuditEntry of
        repositoryvisibilitychangedisableauditentry: RepositoryVisibilityChangeDisableAuditEntry
    | RepositoryVisibilityChangeEnableAuditEntry of
        repositoryvisibilitychangeenableauditentry: RepositoryVisibilityChangeEnableAuditEntry
    | RepositoryVulnerabilityAlert of repositoryvulnerabilityalert: RepositoryVulnerabilityAlert
    | ReviewDismissalAllowance of reviewdismissalallowance: ReviewDismissalAllowance
    | ReviewDismissedEvent of reviewdismissedevent: ReviewDismissedEvent
    | ReviewRequest of reviewrequest: ReviewRequest
    | ReviewRequestRemovedEvent of reviewrequestremovedevent: ReviewRequestRemovedEvent
    | ReviewRequestedEvent of reviewrequestedevent: ReviewRequestedEvent
    | SavedReply of savedreply: SavedReply
    | SecurityAdvisory of securityadvisory: SecurityAdvisory
    | SponsorsActivity of sponsorsactivity: SponsorsActivity
    | SponsorsListing of sponsorslisting: SponsorsListing
    | SponsorsListingFeaturedItem of sponsorslistingfeatureditem: SponsorsListingFeaturedItem
    | SponsorsTier of sponsorstier: SponsorsTier
    | Sponsorship of sponsorship: Sponsorship
    | SponsorshipNewsletter of sponsorshipnewsletter: SponsorshipNewsletter
    | Status of status: Status
    | StatusCheckRollup of statuscheckrollup: StatusCheckRollup
    | StatusContext of statuscontext: StatusContext
    | SubIssueAddedEvent of subissueaddedevent: SubIssueAddedEvent
    | SubIssueRemovedEvent of subissueremovedevent: SubIssueRemovedEvent
    | SubscribedEvent of subscribedevent: SubscribedEvent
    | Tag of tag: Tag
    | Team of team: Team
    | TeamAddMemberAuditEntry of teamaddmemberauditentry: TeamAddMemberAuditEntry
    | TeamAddRepositoryAuditEntry of teamaddrepositoryauditentry: TeamAddRepositoryAuditEntry
    | TeamChangeParentTeamAuditEntry of teamchangeparentteamauditentry: TeamChangeParentTeamAuditEntry
    | TeamDiscussion of teamdiscussion: TeamDiscussion
    | TeamDiscussionComment of teamdiscussioncomment: TeamDiscussionComment
    | TeamRemoveMemberAuditEntry of teamremovememberauditentry: TeamRemoveMemberAuditEntry
    | TeamRemoveRepositoryAuditEntry of teamremoverepositoryauditentry: TeamRemoveRepositoryAuditEntry
    | Topic of topic: Topic
    | TransferredEvent of transferredevent: TransferredEvent
    | Tree of tree: Tree
    | UnassignedEvent of unassignedevent: UnassignedEvent
    | UnlabeledEvent of unlabeledevent: UnlabeledEvent
    | UnlockedEvent of unlockedevent: UnlockedEvent
    | UnmarkedAsDuplicateEvent of unmarkedasduplicateevent: UnmarkedAsDuplicateEvent
    | UnpinnedEvent of unpinnedevent: UnpinnedEvent
    | UnsubscribedEvent of unsubscribedevent: UnsubscribedEvent
    | User of user: User
    | UserBlockedEvent of userblockedevent: UserBlockedEvent
    | UserContentEdit of usercontentedit: UserContentEdit
    | UserList of userlist: UserList
    | UserNamespaceRepository of usernamespacerepository: UserNamespaceRepository
    | UserStatus of userstatus: UserStatus
    | VerifiableDomain of verifiabledomain: VerifiableDomain
    | Workflow of workflow: Workflow
    | WorkflowRun of workflowrun: WorkflowRun
    | WorkflowRunFile of workflowrunfile: WorkflowRunFile
    | Issue of issue: Issue

/// The query root of GitHub's GraphQL interface.
type Query =
    {
        /// Fetches an object given its ID.
        node: Option<Node>
    }
