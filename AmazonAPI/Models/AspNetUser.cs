using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public string? NudePassword { get; set; }

    public string? FullName { get; set; }

    public bool UserStatus { get; set; }

    public string? CompanyName { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; } = new List<AspNetUserRole>();

    public virtual ICollection<ContactCompany> ContactCompanies { get; set; } = new List<ContactCompany>();

    public virtual ICollection<CustomFieldDatum> CustomFieldData { get; set; } = new List<CustomFieldDatum>();

    public virtual ICollection<CustomField> CustomFields { get; set; } = new List<CustomField>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Expence> ExpenceApprovedByNavigations { get; set; } = new List<Expence>();

    public virtual ICollection<Expence> ExpenceCreatedByNavigations { get; set; } = new List<Expence>();

    public virtual ICollection<Expence> ExpenceExpensedByNavigations { get; set; } = new List<Expence>();

    public virtual ICollection<Expence> ExpenceManagerApprovalNavigations { get; set; } = new List<Expence>();

    public virtual ICollection<Expence> ExpencePaidByNavigations { get; set; } = new List<Expence>();

    public virtual ICollection<FeesAndCharge> FeesAndCharges { get; set; } = new List<FeesAndCharge>();

    public virtual ICollection<FormSequence> FormSequences { get; set; } = new List<FormSequence>();

    public virtual ICollection<Issue> IssueAssignedByNavigations { get; set; } = new List<Issue>();

    public virtual ICollection<Issue> IssueAssingedToEmps { get; set; } = new List<Issue>();

    public virtual ICollection<Issue> IssueCompletedByNavigations { get; set; } = new List<Issue>();

    public virtual ICollection<Issue> IssueCreatedByNavigations { get; set; } = new List<Issue>();

    public virtual ICollection<Issue> IssueEmployees { get; set; } = new List<Issue>();

    public virtual ICollection<IssueNoteReply> IssueNoteReplies { get; set; } = new List<IssueNoteReply>();

    public virtual ICollection<IssueNote> IssueNotes { get; set; } = new List<IssueNote>();

    public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();

    public virtual ICollection<RelatedProduct> RelatedProducts { get; set; } = new List<RelatedProduct>();

    public virtual ICollection<Rma> Rmas { get; set; } = new List<Rma>();

    public virtual ICollection<TransactionsLog> TransactionsLogs { get; set; } = new List<TransactionsLog>();

    public virtual ICollection<UserRight> UserRights { get; set; } = new List<UserRight>();
}
