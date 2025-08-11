using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerOpportunity
{
    public int OpportunityId { get; set; }

    public int? PartnerId { get; set; }

    public string OpportunityName { get; set; } = null!;

    public string? OpportunityType { get; set; }

    public string? ProductName { get; set; }

    public string? SerialNumber { get; set; }

    public string? FortiCareId { get; set; }

    public string? CoTermQuoteId { get; set; }

    public string? TradeUpId { get; set; }

    public bool? IsSdwanopportunity { get; set; }

    public string? IsOperationalTechnologyOpportunity { get; set; }

    public decimal? EstimatedValue { get; set; }

    public int? StatusId { get; set; }

    public bool? DealRegOot { get; set; }

    public bool? IsRenewalOver9999 { get; set; }

    public bool? FedDeal { get; set; }

    public bool? TradeIn { get; set; }

    public string? DealType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public string? ChangedBy { get; set; }

    public virtual Partner? Partner { get; set; }

    public virtual ICollection<PartnerDealRegistration> PartnerDealRegistrations { get; set; } = new List<PartnerDealRegistration>();

    public virtual ICollection<PartnerOpportunityHistory> PartnerOpportunityHistories { get; set; } = new List<PartnerOpportunityHistory>();
}
