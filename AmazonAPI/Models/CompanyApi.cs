using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class CompanyApi
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public bool? EnableFlag { get; set; }

    public string? Api { get; set; }

    public string? Token { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public virtual Company? Company { get; set; }
}
