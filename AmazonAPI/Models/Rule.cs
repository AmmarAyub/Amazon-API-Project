using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Rule
{
    public Guid RuleId { get; set; }

    public string? RuleName { get; set; }

    public string? RuleDescription { get; set; }

    public string? RuleQuery { get; set; }

    public bool? RunFlag { get; set; }

    public int? AssignTo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Employee? AssignToNavigation { get; set; }
}
