using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Quote
{
    public int QuoteId { get; set; }

    public int? ContactId { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public DateTime? QuoteDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    public int? PaymentTerm { get; set; }

    public int ShipToContactId { get; set; }

    public double? Discount { get; set; }

    public int? QuoteStage { get; set; }

    public decimal? QuoteTotal { get; set; }

    public decimal? SubTotal { get; set; }

    public int? TaxId { get; set; }

    public bool? IsSalesOrder { get; set; }

    public int Status { get; set; }

    public string? Porefrence { get; set; }

    public string? Comment { get; set; }

    public string? TermAndCondition { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ContactCompany? Contact { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<QuoteDetail> QuoteDetails { get; set; } = new List<QuoteDetail>();

    public virtual List? QuoteStageNavigation { get; set; }

    public virtual Contact ShipToContact { get; set; } = null!;

    public virtual Shipper? ShipViaNavigation { get; set; }

    public virtual List StatusNavigation { get; set; } = null!;
}
