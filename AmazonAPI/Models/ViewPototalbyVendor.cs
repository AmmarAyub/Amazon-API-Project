using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPototalbyVendor
{
    public string Name { get; set; } = null!;

    public string? CompanyName { get; set; }

    public decimal? PoTotal { get; set; }
}
