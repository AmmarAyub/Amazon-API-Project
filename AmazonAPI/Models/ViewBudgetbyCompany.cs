using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewBudgetbyCompany
{
    public int Id { get; set; }

    public int BudgetId { get; set; }

    public string? CompanyName { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? Details { get; set; }

    public string? VendorName { get; set; }

    public decimal? Amount { get; set; }
}
