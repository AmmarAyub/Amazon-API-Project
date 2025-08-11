using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int? ContactId { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    public int? PaymentTerm { get; set; }

    public int ShipToContactId { get; set; }

    public double? Discount { get; set; }

    public int? BillStage { get; set; }

    public decimal? BillTotal { get; set; }

    public decimal? BillSubTotal { get; set; }

    public string? PaymentOrderId { get; set; }

    public int? TaxId { get; set; }

    public bool? IsPaid { get; set; }

    public int Status { get; set; }

    public string? Porefrence { get; set; }

    public string? VendorInv { get; set; }

    public string? Comment { get; set; }

    public string? TermAndCondition { get; set; }

    public string? BillDocument { get; set; }

    public string? TrackingInfo { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual List? BillStageNavigation { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ContactCompany? Contact { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<PaymentMadeBill> PaymentMadeBills { get; set; } = new List<PaymentMadeBill>();

    public virtual Contact ShipToContact { get; set; } = null!;

    public virtual Shipper? ShipViaNavigation { get; set; }

    public virtual List StatusNavigation { get; set; } = null!;
}
