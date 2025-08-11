using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewGetOpenPurchaseOrder
{
    public string CompanyName { get; set; } = null!;

    public string? ContactCompany { get; set; }

    public int PurchaseOrdersId { get; set; }

    public decimal? PurchaseOrdersTotal { get; set; }

    public DateTime? PurchaseOrdersDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public string? Porefrence { get; set; }

    public string? ListValue { get; set; }

    public bool? IsSalesOrder { get; set; }
}
