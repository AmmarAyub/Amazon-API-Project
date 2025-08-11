using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ShipmentTracking
{
    public int ShipmentTrackignId { get; set; }

    public int ShipperId { get; set; }

    public int OrderId { get; set; }

    public string TrackingNumber { get; set; } = null!;

    public string Urlprefix { get; set; } = null!;

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }
}
