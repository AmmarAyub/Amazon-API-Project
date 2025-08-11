using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PorequestDetail
{
    public int Id { get; set; }

    public int? PorequestId { get; set; }

    public int? ProductId { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Quantity { get; set; }

    public string? Note { get; set; }

    public decimal? PriceQuoted { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public string? VendorNotes { get; set; }

    public virtual Porequest? Porequest { get; set; }

    public virtual Product? Product { get; set; }
}
