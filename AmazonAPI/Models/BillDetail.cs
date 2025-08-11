using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class BillDetail
{
    public int Id { get; set; }

    public int? PurchaseDetailId { get; set; }

    public int? BilId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public bool? Tax { get; set; }

    public string? Note { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual Bill? Bil { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual PurchaseOrdersDetail? PurchaseDetail { get; set; }
}
