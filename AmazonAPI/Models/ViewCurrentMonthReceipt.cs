using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewCurrentMonthReceipt
{
    public string Name { get; set; } = null!;

    public decimal? Total { get; set; }

    public string? AccountName { get; set; }
}
