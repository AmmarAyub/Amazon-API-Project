using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Issuebackup
{
    public int IssueId { get; set; }

    public int EmployeeId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int CategoryId { get; set; }

    public int SubCategoryId { get; set; }

    public int AssingedToEmpId { get; set; }

    public int? Status { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }
}
