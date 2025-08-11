using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class SageInvoice
{
    public string? Products { get; set; }

    public string? Service { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? Name { get; set; }

    public string? InvoiceNo { get; set; }

    public string? UnitPrice { get; set; }

    public string? QtyHrs { get; set; }

    public string? Net { get; set; }

    public string? Cost { get; set; }

    public string? Profit { get; set; }

    public string? Profit2 { get; set; }
}
