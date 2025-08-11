using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewReceiptDetail
{
    public DateOnly? DateReceived { get; set; }

    public string? CustomerName { get; set; }

    public string? BankAccountName { get; set; }

    public string CompanyName { get; set; } = null!;

    public int? InvoiceId { get; set; }

    public int? ReceiptId { get; set; }

    public string? Reference { get; set; }

    public double? TotalAmmount { get; set; }

    public double? InvoiceAmmount { get; set; }

    public int? AccountNameId { get; set; }

    public string PaymentTerm { get; set; } = null!;

    public int? CompanyId { get; set; }
}
