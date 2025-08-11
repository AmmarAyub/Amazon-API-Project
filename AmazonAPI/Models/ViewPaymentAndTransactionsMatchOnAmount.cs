using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPaymentAndTransactionsMatchOnAmount
{
    public string? AccountName { get; set; }

    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public double? Amount { get; set; }

    public string Paymentside { get; set; } = null!;

    public string? CompanyName { get; set; }

    public DateOnly? DateReceived { get; set; }

    public double? TotalAmmount { get; set; }
}
