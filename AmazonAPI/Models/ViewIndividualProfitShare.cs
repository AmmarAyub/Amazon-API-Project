using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewIndividualProfitShare
{
    public string Name { get; set; } = null!;

    public int? InvoiceId { get; set; }

    public string? FullName { get; set; }

    public decimal? MyShare { get; set; }

    public string? InvDate { get; set; }
}
