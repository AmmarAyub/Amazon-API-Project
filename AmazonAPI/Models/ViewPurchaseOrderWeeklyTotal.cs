using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPurchaseOrderWeeklyTotal
{
    public decimal? Pototal { get; set; }

    public int PurchaseOrdersId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? PurchaseOrdersDate { get; set; }
}
