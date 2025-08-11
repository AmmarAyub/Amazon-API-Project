using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPLdetail
{
    public string? AccountName { get; set; }

    public DateOnly? MonthCharged { get; set; }

    public string? OriginalDescription { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? TypeofAccount { get; set; }

    public string? CompanyCharged { get; set; }

    public string? Notes { get; set; }
}
