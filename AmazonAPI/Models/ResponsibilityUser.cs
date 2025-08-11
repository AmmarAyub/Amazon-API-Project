using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ResponsibilityUser
{
    public int TaskUserId { get; set; }

    public int? TaskResponsibilityId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Role { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual TaskResponsibility? TaskResponsibility { get; set; }
}
