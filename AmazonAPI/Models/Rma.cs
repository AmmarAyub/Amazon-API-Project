using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Rma
{
    public int Rmaid { get; set; }

    public int? InvoiceId { get; set; }

    public int? InvoiceDetailId { get; set; }

    public int? ReasonForReturn { get; set; }

    public int? CurrentProductCondition { get; set; }

    public decimal? Amount { get; set; }

    public int? ReturnQty { get; set; }

    public string? SerialNo { get; set; }

    public string? TrakingNo { get; set; }

    public string? Comment { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime HstryDateTime { get; set; }

    public virtual AspNetUser HstryUser { get; set; } = null!;

    public virtual Invoice? Invoice { get; set; }
}
