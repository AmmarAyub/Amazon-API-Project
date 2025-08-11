using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewAccountPayableByCompany
{
    public string Name { get; set; } = null!;

    public decimal? TotalBill { get; set; }

    public int Id { get; set; }
}
