using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Issue
{
    public int IssueId { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int CategoryId { get; set; }

    public int SubCategoryId { get; set; }

    public string? CreatedBy { get; set; }

    public string AssingedToEmpId { get; set; } = null!;

    public int? Status { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public DateTime? IsMyDay { get; set; }

    public bool? IsCompleted { get; set; }

    public bool? IsPrivate { get; set; }

    public string? CompletedBy { get; set; }

    public string? AssignedBy { get; set; }

    public DateTime? AssignedDate { get; set; }

    public virtual AspNetUser? AssignedByNavigation { get; set; }

    public virtual AspNetUser AssingedToEmp { get; set; } = null!;

    public virtual IssueCategory Category { get; set; } = null!;

    public virtual AspNetUser? CompletedByNavigation { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual AspNetUser Employee { get; set; } = null!;

    public virtual ICollection<IssueNote> IssueNotes { get; set; } = new List<IssueNote>();
}
