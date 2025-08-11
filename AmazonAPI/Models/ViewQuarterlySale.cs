using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewQuarterlySale
{
    public int? Year { get; set; }

    public decimal? Q1 { get; set; }

    public decimal? Q2 { get; set; }

    public decimal? Q3 { get; set; }

    public decimal? Q4 { get; set; }
}
