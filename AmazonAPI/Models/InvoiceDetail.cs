using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class InvoiceDetail
{
    public int Id { get; set; }

    public int? QuoteId { get; set; }

    public int? InvoiceId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public bool? Tax { get; set; }

    public string? Note { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public int? PurchaseOrderId { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual PurchaseOrdersDetail? PurchaseOrder { get; set; }

    public virtual QuoteDetail? Quote { get; set; }
}
