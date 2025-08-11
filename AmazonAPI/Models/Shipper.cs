using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Shipper
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ShippingService { get; set; }

    public string? Phone { get; set; }

    public string? Link { get; set; }

    public int Status { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Porequest> Porequests { get; set; } = new List<Porequest>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();
}
