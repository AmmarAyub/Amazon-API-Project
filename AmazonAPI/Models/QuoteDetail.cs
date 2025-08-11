using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class QuoteDetail
{
    public int Id { get; set; }

    public int? QuoteId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public decimal? RemainingQuantity { get; set; }

    public bool? Tax { get; set; }

    public string? Note { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual Product Product { get; set; } = null!;

    public virtual Quote? Quote { get; set; }
}
