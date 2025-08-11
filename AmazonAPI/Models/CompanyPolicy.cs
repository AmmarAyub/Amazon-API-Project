using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class CompanyPolicy
{
    public int PolicyId { get; set; }

    public int? CompanyId { get; set; }

    public int? SequenceId { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? PolicyDetails { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Company? Company { get; set; }
}
