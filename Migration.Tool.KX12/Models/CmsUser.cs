﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Migration.Tool.KX12.Models;

[Table("CMS_User")]
[Index("Email", Name = "IX_CMS_User_Email")]
[Index("FullName", Name = "IX_CMS_User_FullName")]
[Index("UserEnabled", "UserIsHidden", Name = "IX_CMS_User_UserEnabled_UserIsHidden")]
[Index("UserGuid", Name = "IX_CMS_User_UserGUID", IsUnique = true)]
[Index("UserName", Name = "IX_CMS_User_UserName", IsUnique = true)]
[Index("UserPrivilegeLevel", Name = "IX_CMS_User_UserPrivilegeLevel")]
public class CmsUser
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(100)]
    public string UserName { get; set; } = null!;

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? MiddleName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    public string? FullName { get; set; }

    [StringLength(254)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string UserPassword { get; set; } = null!;

    [StringLength(10)]
    public string? PreferredCultureCode { get; set; }

    [Column("PreferredUICultureCode")]
    [StringLength(10)]
    public string? PreferredUicultureCode { get; set; }

    public bool UserEnabled { get; set; }

    public bool? UserIsExternal { get; set; }

    [StringLength(10)]
    public string? UserPasswordFormat { get; set; }

    public DateTime? UserCreated { get; set; }

    public DateTime? LastLogon { get; set; }

    [StringLength(200)]
    public string? UserStartingAliasPath { get; set; }

    [Column("UserGUID")]
    public Guid UserGuid { get; set; }

    public DateTime UserLastModified { get; set; }

    public string? UserLastLogonInfo { get; set; }

    public bool? UserIsHidden { get; set; }

    public string? UserVisibility { get; set; }

    public bool? UserIsDomain { get; set; }

    public bool? UserHasAllowedCultures { get; set; }

    [Column("UserMFRequired")]
    public bool? UserMfrequired { get; set; }

    public int UserPrivilegeLevel { get; set; }

    [StringLength(72)]
    public string? UserSecurityStamp { get; set; }

    [Column("UserMFSecret")]
    public byte[]? UserMfsecret { get; set; }

    [Column("UserMFTimestep")]
    public long? UserMftimestep { get; set; }

    [InverseProperty("CommentApprovedByUser")]
    public virtual ICollection<BlogComment> BlogCommentCommentApprovedByUsers { get; set; } = new List<BlogComment>();

    [InverseProperty("CommentUser")]
    public virtual ICollection<BlogComment> BlogCommentCommentUsers { get; set; } = new List<BlogComment>();

    [InverseProperty("SubscriptionUser")]
    public virtual ICollection<BlogPostSubscription> BlogPostSubscriptions { get; set; } = new List<BlogPostSubscription>();

    [InverseProperty("BoardUser")]
    public virtual ICollection<BoardBoard> BoardBoards { get; set; } = new List<BoardBoard>();

    [InverseProperty("MessageApprovedByUser")]
    public virtual ICollection<BoardMessage> BoardMessageMessageApprovedByUsers { get; set; } = new List<BoardMessage>();

    [InverseProperty("MessageUser")]
    public virtual ICollection<BoardMessage> BoardMessageMessageUsers { get; set; } = new List<BoardMessage>();

    [InverseProperty("SubscriptionUser")]
    public virtual ICollection<BoardSubscription> BoardSubscriptions { get; set; } = new List<BoardSubscription>();

    [InverseProperty("InitiatedChatRequestUser")]
    public virtual ICollection<ChatInitiatedChatRequest> ChatInitiatedChatRequests { get; set; } = new List<ChatInitiatedChatRequest>();

    [InverseProperty("ChatUserUser")]
    public virtual ICollection<ChatUser> ChatUsers { get; set; } = new List<ChatUser>();

    [InverseProperty("ReportUser")]
    public virtual ICollection<CmsAbuseReport> CmsAbuseReports { get; set; } = new List<CmsAbuseReport>();

    [InverseProperty("LastModifiedByUser")]
    public virtual ICollection<CmsAclitem> CmsAclitemLastModifiedByUsers { get; set; } = new List<CmsAclitem>();

    [InverseProperty("User")]
    public virtual ICollection<CmsAclitem> CmsAclitemUsers { get; set; } = new List<CmsAclitem>();

    [InverseProperty("HistoryApprovedByUser")]
    public virtual ICollection<CmsAutomationHistory> CmsAutomationHistories { get; set; } = new List<CmsAutomationHistory>();

    [InverseProperty("StateUser")]
    public virtual ICollection<CmsAutomationState> CmsAutomationStates { get; set; } = new List<CmsAutomationState>();

    [InverseProperty("CategoryUser")]
    public virtual ICollection<CmsCategory> CmsCategories { get; set; } = new List<CmsCategory>();

    [InverseProperty("DocumentCheckedOutByUser")]
    public virtual ICollection<CmsDocument> CmsDocumentDocumentCheckedOutByUsers { get; set; } = new List<CmsDocument>();

    [InverseProperty("DocumentCreatedByUser")]
    public virtual ICollection<CmsDocument> CmsDocumentDocumentCreatedByUsers { get; set; } = new List<CmsDocument>();

    [InverseProperty("DocumentModifiedByUser")]
    public virtual ICollection<CmsDocument> CmsDocumentDocumentModifiedByUsers { get; set; } = new List<CmsDocument>();

    [InverseProperty("User")]
    public virtual ICollection<CmsEmailUser> CmsEmailUsers { get; set; } = new List<CmsEmailUser>();

    [InverseProperty("User")]
    public virtual ICollection<CmsExternalLogin> CmsExternalLogins { get; set; } = new List<CmsExternalLogin>();

    [InverseProperty("MacroIdentityEffectiveUser")]
    public virtual ICollection<CmsMacroIdentity> CmsMacroIdentities { get; set; } = new List<CmsMacroIdentity>();

    [InverseProperty("User")]
    public virtual ICollection<CmsMembershipUser> CmsMembershipUsers { get; set; } = new List<CmsMembershipUser>();

    [InverseProperty("ObjectCheckedOutByUser")]
    public virtual ICollection<CmsObjectSetting> CmsObjectSettings { get; set; } = new List<CmsObjectSetting>();

    [InverseProperty("VersionDeletedByUser")]
    public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistoryVersionDeletedByUsers { get; set; } = new List<CmsObjectVersionHistory>();

    [InverseProperty("VersionModifiedByUser")]
    public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistoryVersionModifiedByUsers { get; set; } = new List<CmsObjectVersionHistory>();

    [InverseProperty("User")]
    public virtual ICollection<CmsOpenIduser> CmsOpenIdusers { get; set; } = new List<CmsOpenIduser>();

    [InverseProperty("PersonalizationUser")]
    public virtual ICollection<CmsPersonalization> CmsPersonalizations { get; set; } = new List<CmsPersonalization>();

    [InverseProperty("TaskUser")]
    public virtual ICollection<CmsScheduledTask> CmsScheduledTasks { get; set; } = new List<CmsScheduledTask>();

    [InverseProperty("SessionUser")]
    public virtual ICollection<CmsSession> CmsSessions { get; set; } = new List<CmsSession>();

    [InverseProperty("SubmissionSubmittedByUser")]
    public virtual ICollection<CmsTranslationSubmission> CmsTranslationSubmissions { get; set; } = new List<CmsTranslationSubmission>();

    [InverseProperty("NodeOwnerNavigation")]
    public virtual ICollection<CmsTree> CmsTrees { get; set; } = new List<CmsTree>();

    [InverseProperty("User")]
    public virtual ICollection<CmsUserCulture> CmsUserCultures { get; set; } = new List<CmsUserCulture>();

    [InverseProperty("UserMacroIdentityUser")]
    public virtual CmsUserMacroIdentity? CmsUserMacroIdentity { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<CmsUserRole> CmsUserRoles { get; set; } = new List<CmsUserRole>();

    [InverseProperty("UserActivatedByUser")]
    public virtual ICollection<CmsUserSetting> CmsUserSettingUserActivatedByUsers { get; set; } = new List<CmsUserSetting>();

    [InverseProperty("UserSettingsUserNavigation")]
    public virtual CmsUserSetting? CmsUserSettingUserSettingsUserNavigation { get; set; }

    public virtual ICollection<CmsUserSetting> CmsUserSettingUserSettingsUsers { get; set; } = new List<CmsUserSetting>();

    [InverseProperty("User")]
    public virtual ICollection<CmsUserSite> CmsUserSites { get; set; } = new List<CmsUserSite>();

    [InverseProperty("ModifiedByUser")]
    public virtual ICollection<CmsVersionHistory> CmsVersionHistoryModifiedByUsers { get; set; } = new List<CmsVersionHistory>();

    [InverseProperty("VersionDeletedByUser")]
    public virtual ICollection<CmsVersionHistory> CmsVersionHistoryVersionDeletedByUsers { get; set; } = new List<CmsVersionHistory>();

    [InverseProperty("ApprovedByUser")]
    public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistories { get; set; } = new List<CmsWorkflowHistory>();

    [InverseProperty("User")]
    public virtual ICollection<CmsWorkflowStepUser> CmsWorkflowStepUsers { get; set; } = new List<CmsWorkflowStepUser>();

    [InverseProperty("CustomerUser")]
    public virtual ICollection<ComCustomer> ComCustomers { get; set; } = new List<ComCustomer>();

    [InverseProperty("ChangedByUser")]
    public virtual ICollection<ComOrderStatusUser> ComOrderStatusUsers { get; set; } = new List<ComOrderStatusUser>();

    [InverseProperty("OrderCreatedByUser")]
    public virtual ICollection<ComOrder> ComOrders { get; set; } = new List<ComOrder>();

    [InverseProperty("ShoppingCartUser")]
    public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; } = new List<ComShoppingCart>();

    [InverseProperty("User")]
    public virtual ICollection<ComWishlist> ComWishlists { get; set; } = new List<ComWishlist>();

    [InverseProperty("GroupApprovedByUser")]
    public virtual ICollection<CommunityGroup> CommunityGroupGroupApprovedByUsers { get; set; } = new List<CommunityGroup>();

    [InverseProperty("GroupCreatedByUser")]
    public virtual ICollection<CommunityGroup> CommunityGroupGroupCreatedByUsers { get; set; } = new List<CommunityGroup>();

    [InverseProperty("MemberApprovedByUser")]
    public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberApprovedByUsers { get; set; } = new List<CommunityGroupMember>();

    [InverseProperty("MemberInvitedByUser")]
    public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberInvitedByUsers { get; set; } = new List<CommunityGroupMember>();

    [InverseProperty("MemberUser")]
    public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberUsers { get; set; } = new List<CommunityGroupMember>();

    [InverseProperty("InvitedByUser")]
    public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedByUsers { get; set; } = new List<CommunityInvitation>();

    [InverseProperty("InvitedUser")]
    public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedUsers { get; set; } = new List<CommunityInvitation>();

    [InverseProperty("ExportUser")]
    public virtual ICollection<ExportHistory> ExportHistories { get; set; } = new List<ExportHistory>();

    [InverseProperty("PostApprovedByUser")]
    public virtual ICollection<ForumsForumPost> ForumsForumPostPostApprovedByUsers { get; set; } = new List<ForumsForumPost>();

    [InverseProperty("PostUser")]
    public virtual ICollection<ForumsForumPost> ForumsForumPostPostUsers { get; set; } = new List<ForumsForumPost>();

    [InverseProperty("SubscriptionUser")]
    public virtual ICollection<ForumsForumSubscription> ForumsForumSubscriptions { get; set; } = new List<ForumsForumSubscription>();

    [InverseProperty("User")]
    public virtual ICollection<ForumsUserFavorite> ForumsUserFavorites { get; set; } = new List<ForumsUserFavorite>();

    [InverseProperty("FileCreatedByUser")]
    public virtual ICollection<MediaFile> MediaFileFileCreatedByUsers { get; set; } = new List<MediaFile>();

    [InverseProperty("FileModifiedByUser")]
    public virtual ICollection<MediaFile> MediaFileFileModifiedByUsers { get; set; } = new List<MediaFile>();

    [InverseProperty("SubscriptionUser")]
    public virtual ICollection<NotificationSubscription> NotificationSubscriptions { get; set; } = new List<NotificationSubscription>();

    [InverseProperty("AccountOwnerUser")]
    public virtual ICollection<OmAccount> OmAccounts { get; set; } = new List<OmAccount>();

    [InverseProperty("ContactOwnerUser")]
    public virtual ICollection<OmContact> OmContacts { get; set; } = new List<OmContact>();

    [InverseProperty("ReportSubscriptionUser")]
    public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; } = new List<ReportingReportSubscription>();

    [InverseProperty("SavedReportCreatedByUser")]
    public virtual ICollection<ReportingSavedReport> ReportingSavedReports { get; set; } = new List<ReportingSavedReport>();

    [InverseProperty("User")]
    public virtual StagingTaskGroupUser? StagingTaskGroupUser { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<StagingTaskUser> StagingTaskUsers { get; set; } = new List<StagingTaskUser>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<BoardBoard> Boards { get; set; } = new List<BoardBoard>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<ForumsForum> Forums { get; set; } = new List<ForumsForum>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<CmsWorkflow> Workflows { get; set; } = new List<CmsWorkflow>();
}
