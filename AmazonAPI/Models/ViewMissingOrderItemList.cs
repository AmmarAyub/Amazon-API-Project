using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewMissingOrderItemList
{
    public string? AmazonOrderId { get; set; }

    public int OrderId { get; set; }
}
