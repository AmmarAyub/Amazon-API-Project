using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class FeesAndCharge
{
    public int FeeId { get; set; }

    public int? PaymentTermId { get; set; }

    public int? Percentage { get; set; }

    public int? FixCharges { get; set; }

    public int Status { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual AspNetUser HstryUser { get; set; } = null!;
}
