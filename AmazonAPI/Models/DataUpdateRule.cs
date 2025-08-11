using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class DataUpdateRule
{
    public int RuleId { get; set; }

    public string? TableName { get; set; }

    public string? Setfield1 { get; set; }

    public string? UpdateWith1 { get; set; }

    public string? Setfield2 { get; set; }

    public string? UpdateWith2 { get; set; }

    public string? Setfield3 { get; set; }

    public string? UpdateWith3 { get; set; }

    public string? Where1 { get; set; }

    public string? Condition1 { get; set; }

    public string? Predicate1 { get; set; }

    public string? Where2 { get; set; }

    public string? Condition2 { get; set; }

    public string? Predicate2 { get; set; }

    public string? Where3 { get; set; }

    public string? Condition3 { get; set; }

    public string? Predicate3 { get; set; }

    public string? Where4 { get; set; }

    public string? Condition4 { get; set; }
}
