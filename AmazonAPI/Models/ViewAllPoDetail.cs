using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewAllPoDetail
{
    public string Name { get; set; } = null!;

    public DateTime? PurchaseOrdersDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Porefrence { get; set; }

    public int ProductId { get; set; }

    public string? ItemCode { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public decimal? PurchaseOrdersTotal { get; set; }

    public short? RemainingQuantity { get; set; }

    public int? PurchaseOrdersId { get; set; }

    public int Id { get; set; }

    public short? InvoiceRemainingQuantity { get; set; }
}
