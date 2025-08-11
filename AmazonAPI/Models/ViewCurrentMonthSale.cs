using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewCurrentMonthSale
{
    public string Name { get; set; } = null!;

    public decimal? TotalSales { get; set; }
}
