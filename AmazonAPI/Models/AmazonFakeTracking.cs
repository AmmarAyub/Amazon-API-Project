using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AmazonFakeTracking
{
    public int Id { get; set; }

    public string? AmazonOrderId { get; set; }

    public string? FakeTrackingId { get; set; }

    public string? RealTracking { get; set; }

    public int? Status { get; set; }
}
