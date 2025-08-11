using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Jan2020
{
    public string InvoiceId { get; set; } = null!;

    public int CompanyId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public string Customer { get; set; } = null!;

    public double Total { get; set; }

    public string AmountDue { get; set; } = null!;

    public string Issued { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ReferencePoNumber { get; set; }

    public string? TotalDue { get; set; }

    public string? Column12 { get; set; }
}
