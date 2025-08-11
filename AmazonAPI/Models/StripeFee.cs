using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StripeFee
{
    public int StripeFeesId { get; set; }

    public int? StripeTransactionId { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public virtual StripeTransaction? StripeTransaction { get; set; }
}
