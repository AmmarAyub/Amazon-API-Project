using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmployeeCompany
{
    public int EmployeeCompaniesId { get; set; }

    public int EmployeeId { get; set; }

    public int CompanyId { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
