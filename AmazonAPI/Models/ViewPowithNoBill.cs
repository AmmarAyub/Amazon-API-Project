using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPowithNoBill
{
    public string Name { get; set; } = null!;

    public DateTime? PurchaseOrdersDate { get; set; }

    public string? CompanyName { get; set; }

    public int PurchaseOrdersId { get; set; }

    public string? Porefrence { get; set; }

    public decimal? PurchaseOrdersTotal { get; set; }
}
