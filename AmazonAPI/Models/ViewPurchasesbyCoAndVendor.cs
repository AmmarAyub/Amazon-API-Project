using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPurchasesbyCoAndVendor
{
    public string Name { get; set; } = null!;

    public string? CompanyName { get; set; }

    public decimal? Frieght { get; set; }

    public double? Discount { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }
}
