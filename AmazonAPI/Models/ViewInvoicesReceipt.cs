using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewInvoicesReceipt
{
    public DateOnly? DateReceived { get; set; }

    public string? CompanyName { get; set; }

    public string? Porefrence { get; set; }

    public int InvoiceId { get; set; }

    public decimal? InvoiceTotal { get; set; }

    public string? AccountName { get; set; }

    public int? ReceiptId { get; set; }

    public double? InvoiceAmmount { get; set; }

    public string Name { get; set; } = null!;
}
