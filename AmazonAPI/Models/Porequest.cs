using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Porequest
{
    public int Id { get; set; }

    public int? PoCompany { get; set; }

    public string? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? ShipToId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Reference { get; set; }

    public int? ShipVia { get; set; }

    public int? VendorId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public string? HstryUserId { get; set; }

    public string? HstryDateTime { get; set; }

    public decimal? ShippingCost { get; set; }

    public virtual ContactCompany? Customer { get; set; }

    public virtual Company? PoCompanyNavigation { get; set; }

    public virtual ICollection<PorequestDetail> PorequestDetails { get; set; } = new List<PorequestDetail>();

    public virtual PurchaseOrder? PurchaseOrder { get; set; }

    public virtual Contact? ShipTo { get; set; }

    public virtual Shipper? ShipViaNavigation { get; set; }

    public virtual ContactCompany? Vendor { get; set; }
}
