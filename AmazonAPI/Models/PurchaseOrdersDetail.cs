using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PurchaseOrdersDetail
{
    public int Id { get; set; }

    public int? PurchaseOrdersId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public decimal? RemainingQuantity { get; set; }

    public bool? Tax { get; set; }

    public string? Note { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public decimal? InvoiceRemainingQuantity { get; set; }

    public bool? IsLock { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual Product Product { get; set; } = null!;

    public virtual PurchaseOrder? PurchaseOrders { get; set; }
}
