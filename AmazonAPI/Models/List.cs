using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class List
{
    public int ListId { get; set; }

    public string ListName { get; set; } = null!;

    public string ListValue { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Bill> BillBillStageNavigations { get; set; } = new List<Bill>();

    public virtual ICollection<Bill> BillStatusNavigations { get; set; } = new List<Bill>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Invoice> InvoiceInvoiceStageNavigations { get; set; } = new List<Invoice>();

    public virtual ICollection<Invoice> InvoiceStatusNavigations { get; set; } = new List<Invoice>();

    public virtual ICollection<LeaveRequestDetail> LeaveRequestDetails { get; set; } = new List<LeaveRequestDetail>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderPurchaseOrdersStageNavigations { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseOrder> PurchaseOrderStatusNavigations { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> QuoteQuoteStageNavigations { get; set; } = new List<Quote>();

    public virtual ICollection<Quote> QuoteStatusNavigations { get; set; } = new List<Quote>();
}
