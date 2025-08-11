using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewIssuesDetail
{
    public DateTime? OpenDate { get; set; }

    public int IssueId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public string? IssueCategoryName { get; set; }

    public string? SubCategoryName { get; set; }

    public string Status { get; set; } = null!;

    public string? TicketUrl { get; set; }
}
