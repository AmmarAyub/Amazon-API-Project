using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductCode { get; set; }

    public string? ProductCategory { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Notes { get; set; }

    public string? ChangedBy { get; set; }
}
