using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewBillPayment
{
    public string Name { get; set; } = null!;

    public DateTime? BillDate { get; set; }

    public string? Porefrence { get; set; }

    public int BillId { get; set; }

    public string? CompanyName { get; set; }

    public decimal? BillTotal { get; set; }

    public string? AccountName { get; set; }

    public DateOnly? DateReceived { get; set; }

    public double? TotalAmmount { get; set; }
}
