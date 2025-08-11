using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public string? ExternalInvoiceNo { get; set; }

    public int? ContactId { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    public int? PaymentTerm { get; set; }

    public int ShipToContactId { get; set; }

    public double? Discount { get; set; }

    public int? InvoiceStage { get; set; }

    public decimal? InvoiceTotal { get; set; }

    public decimal? InvoiceSubTotal { get; set; }

    public string? SaleInvoiceIdId { get; set; }

    public int? TaxId { get; set; }

    public bool? IsPaid { get; set; }

    public int Status { get; set; }

    public string? Porefrence { get; set; }

    public string? Comment { get; set; }

    public string? TermAndCondition { get; set; }

    public string? TrackingInfo { get; set; }

    public decimal? FeesAndCharges { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ContactCompany? Contact { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual List? InvoiceStageNavigation { get; set; }

    public virtual ICollection<ReceiptInvoice> ReceiptInvoices { get; set; } = new List<ReceiptInvoice>();

    public virtual ICollection<Rma> Rmas { get; set; } = new List<Rma>();

    public virtual Contact ShipToContact { get; set; } = null!;

    public virtual Shipper? ShipViaNavigation { get; set; }

    public virtual List StatusNavigation { get; set; } = null!;
}
