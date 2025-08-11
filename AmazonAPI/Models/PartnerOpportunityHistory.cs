using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerOpportunityHistory
{
    public int HistoryId { get; set; }

    public int? OpportunityId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? ChangedDate { get; set; }

    public string? ChangedBy { get; set; }

    public string? Notes { get; set; }

    public virtual PartnerOpportunity? Opportunity { get; set; }

    public virtual PartnerOpportunityStatus? Status { get; set; }
}
