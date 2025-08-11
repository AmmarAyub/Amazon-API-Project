using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewAccountsReceivableByCompany
{
    public string Name { get; set; } = null!;

    public decimal? TotalInv { get; set; }

    public int Id { get; set; }
}
