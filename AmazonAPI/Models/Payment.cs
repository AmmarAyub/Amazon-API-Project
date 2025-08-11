using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public string? PaymentType { get; set; }

    public int? PaidInto { get; set; }

    public string? Method { get; set; }

    public string? Reference { get; set; }

    public string? HstryUserId { get; set; }

    public byte[]? HstryDateTime { get; set; }
}
