using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class IssueSubCategory
{
    public int IssueSubCategoryId { get; set; }

    public string? SubCategoryName { get; set; }

    public int IssueCategoryId { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime HstryDateTime { get; set; }

    public virtual IssueCategory IssueCategory { get; set; } = null!;
}
