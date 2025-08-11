using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class IssueCategory
{
    public int IssueCategoryId { get; set; }

    public string? IssueCategoryName { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<IssueSubCategory> IssueSubCategories { get; set; } = new List<IssueSubCategory>();

    public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
}
