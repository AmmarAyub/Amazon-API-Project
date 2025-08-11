using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class DynamicReport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ReportHeader { get; set; }

    public string? PreDynamic { get; set; }

    public string? DynamicQuerytoRun { get; set; }

    public string? PostDynamic { get; set; }

    public string? TotalQuery { get; set; }

    public string? ReportArea { get; set; }

    public string? SubReportArea { get; set; }

    public bool? Isemail { get; set; }

    public string? DynamicCss { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateDate { get; set; }
}
