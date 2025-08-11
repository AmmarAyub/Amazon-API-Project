using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewDuplicateInvoice
{
    public int InvoiceId { get; set; }

    public int? CompanyId { get; set; }

    public string? ExternalInvoiceNo { get; set; }

    public decimal? InvoiceTotal { get; set; }
}
