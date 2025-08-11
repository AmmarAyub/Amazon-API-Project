using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public int Status { get; set; }

    public string? ItemCode { get; set; }

    public bool? IsTrackable { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<PorequestDetail> PorequestDetails { get; set; } = new List<PorequestDetail>();

    public virtual ICollection<ProductManufacturer> ProductManufacturers { get; set; } = new List<ProductManufacturer>();

    public virtual ICollection<PurchaseOrdersDetail> PurchaseOrdersDetails { get; set; } = new List<PurchaseOrdersDetail>();

    public virtual ICollection<QuoteDetail> QuoteDetails { get; set; } = new List<QuoteDetail>();

    public virtual List StatusNavigation { get; set; } = null!;
}
