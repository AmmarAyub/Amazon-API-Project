using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewBillRegister
{
    public string? CompanyName { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? BillDate { get; set; }

    public int BillId { get; set; }

    public string? Porefrence { get; set; }

    public decimal? Freight { get; set; }

    public double? Discount { get; set; }

    public decimal? BillSubTotal { get; set; }

    public decimal? BillTotal { get; set; }

    public bool? IsPaid { get; set; }
}
