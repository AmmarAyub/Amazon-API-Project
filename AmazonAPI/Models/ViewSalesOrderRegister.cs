using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewSalesOrderRegister
{
    public string Name { get; set; } = null!;

    public string? CompanyName { get; set; }

    public int QuoteId { get; set; }

    public string? Porefrence { get; set; }

    public string? Comment { get; set; }

    public DateTime? QuoteDate { get; set; }

    public decimal? Freight { get; set; }

    public double? Discount { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? QuoteTotal { get; set; }
}
