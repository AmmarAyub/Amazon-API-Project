using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class DynamicReportHistory
{
    public int DrjobId { get; set; }

    public int DynamicReportId { get; set; }

    public string? Html { get; set; }

    public bool? Isemail { get; set; }

    public string? EmailAddress { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
