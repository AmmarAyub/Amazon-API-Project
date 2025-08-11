using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class CanceledOrderNotification
{
    public string AmazonOrderId { get; set; } = null!;

    public DateTime? NotifiedDate { get; set; }
}
