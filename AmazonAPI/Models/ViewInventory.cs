using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewInventory
{
    public int ProductId { get; set; }

    public string? ItemCode { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? InvoiceRemainingQuantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? TotalValue { get; set; }

    public DateTime? PurchaseOrdersDate { get; set; }
}
