using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PaymentTerm
{
    public int PaymentId { get; set; }

    public string PaymentTerm1 { get; set; } = null!;

    public double? LimitAmount { get; set; }

    public string? Notes { get; set; }

    public string? Status { get; set; }

    public int? Days { get; set; }

    public bool? ExcludeFees { get; set; }

    public bool? ExcludeTax { get; set; }

    public string? HstryUserId { get; set; }

    public string? HstryDateTime { get; set; }

    public virtual ICollection<PaymentMade> PaymentMades { get; set; } = new List<PaymentMade>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
