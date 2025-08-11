using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewProfitAndLoss
{
    public string? CompanyName { get; set; }

    public string? CompanyCharged { get; set; }

    public string? OriginalDescription { get; set; }

    public string? CategoryName { get; set; }

    public string? SubCategory { get; set; }

    public double? Amount { get; set; }

    public DateOnly? Date { get; set; }

    public string? TransactionType { get; set; }

    public string? AccountName { get; set; }

    public string? CategoryOrignal { get; set; }
}
