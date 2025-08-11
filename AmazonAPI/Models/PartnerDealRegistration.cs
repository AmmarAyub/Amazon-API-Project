using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerDealRegistration
{
    public int DealRegId { get; set; }

    public int? OpportunityId { get; set; }

    public bool? IsDealRegForRenewal { get; set; }

    public bool? IsTradeUpOpportunity { get; set; }

    public bool? IsOutOfTerritory { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Notes { get; set; }

    public string? ChangedBy { get; set; }

    public virtual PartnerOpportunity? Opportunity { get; set; }
}
