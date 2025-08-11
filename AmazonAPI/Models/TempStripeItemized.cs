using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TempStripeItemized
{
    public string? AutomaticPayoutId { get; set; }

    public DateTime? AutomaticPayoutEffectiveAt { get; set; }

    public string? BalanceTransactionId { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? AvailableOn { get; set; }

    public string? Currency { get; set; }

    public double? Gross { get; set; }

    public double? Fee { get; set; }

    public double? Net { get; set; }

    public string? ReportingCategory { get; set; }

    public string? Description { get; set; }

    public bool? IsReconcile { get; set; }

    public int? TransactionId { get; set; }
}
