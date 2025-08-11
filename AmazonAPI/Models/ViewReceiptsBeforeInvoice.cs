using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewReceiptsBeforeInvoice
{
    public string? CompanyName { get; set; }

    public int InvoiceId { get; set; }

    public string? InvoiceDate { get; set; }

    public int ReceiptId { get; set; }

    public string? ReceiptDate { get; set; }

    public string PaymentTerm { get; set; } = null!;
}
