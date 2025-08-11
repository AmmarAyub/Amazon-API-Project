using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewBudget
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? Details { get; set; }

    public string? VendorName { get; set; }

    public decimal? Amount { get; set; }
}
