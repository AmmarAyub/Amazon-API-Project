using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ProfitSharing
{
    public int ProfitSharingId { get; set; }

    public string? CompanyId { get; set; }

    public Guid? AspnetUserId { get; set; }

    public string? SharePercentage { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }
}
