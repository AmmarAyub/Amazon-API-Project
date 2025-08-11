using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerOpportunityStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Notes { get; set; }

    public string? ChangedBy { get; set; }

    public virtual ICollection<PartnerOpportunityHistory> PartnerOpportunityHistories { get; set; } = new List<PartnerOpportunityHistory>();
}
