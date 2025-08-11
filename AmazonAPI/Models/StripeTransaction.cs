using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StripeTransaction
{
    public int StripTransactionId { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? AvailableOn { get; set; }

    public DateTime? Created { get; set; }

    public string? Currency { get; set; }

    public string? Description { get; set; }

    public decimal? Fee { get; set; }

    public decimal? Net { get; set; }

    public string? ReportingCategory { get; set; }

    public string? Source { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? StripeAccountName { get; set; }

    public virtual ICollection<StripeFee> StripeFees { get; set; } = new List<StripeFee>();
}
