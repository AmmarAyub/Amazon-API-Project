using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewInvoiceRegister
{
    public string Name { get; set; } = null!;

    public string? CompanyName { get; set; }

    public int InvoiceId { get; set; }

    public string? ExternalInvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? Freight { get; set; }

    public double? Discount { get; set; }

    public decimal? InvoiceSubTotal { get; set; }

    public decimal? InvoiceTotal { get; set; }

    public bool? IsPaid { get; set; }
}
