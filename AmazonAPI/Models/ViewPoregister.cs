using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPoregister
{
    public string Name { get; set; } = null!;

    public DateTime? PurchaseOrdersDate { get; set; }

    public int PurchaseOrdersId { get; set; }

    public string? Porefrence { get; set; }

    public string? CompanyName { get; set; }

    public decimal? Freight { get; set; }

    public double? Discount { get; set; }

    public decimal? PurchaseOrdersSubTotal { get; set; }

    public decimal? PurchaseOrdersTotal { get; set; }

    public bool? IsPaid { get; set; }
}
