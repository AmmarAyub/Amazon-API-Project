using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TaxRate
{
    public int TaxId { get; set; }

    public string? CityAndRate { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? TaxRegionName { get; set; }

    public double? StateRate { get; set; }

    public double? EstimatedCombinedRate { get; set; }

    public double? EstimatedCountyRate { get; set; }

    public double? EstimatedCityRate { get; set; }

    public double? EstimatedSpecialRate { get; set; }

    public double? RiskLevel { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
