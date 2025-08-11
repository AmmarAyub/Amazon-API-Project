using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPoandInvoicesNotMatched
{
    public string Name { get; set; } = null!;

    public string? Customer { get; set; }

    public int? InvoiceId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public short Quantity { get; set; }

    public string? Comment { get; set; }

    public string Blank { get; set; } = null!;

    public string? Vendor { get; set; }

    public string? Pocomment { get; set; }

    public int PurchaseOrdersId { get; set; }

    public int PoProductIe { get; set; }

    public string PoProduct { get; set; } = null!;

    public short Poqty { get; set; }

    public decimal PoPrice { get; set; }

    public int Id { get; set; }

    public decimal UnitPrice { get; set; }

    public short? InvoiceRemainingQuantity { get; set; }
}
