using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewUploadToTransaction
{
    public int? AccountId { get; set; }

    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public string? Amount { get; set; }

    public string? TransactionType { get; set; }

    public string Category { get; set; } = null!;

    public string SubCategory { get; set; } = null!;

    public string Labels { get; set; } = null!;

    public string? Notes { get; set; }

    public string AccountType { get; set; } = null!;

    public string? PreviouslyChargedTo { get; set; }

    public string? DefaultActUser { get; set; }

    public string? CompanyCharged { get; set; }

    public string Personal { get; set; } = null!;

    public string? AddedBy { get; set; }

    public DateTime AddedDate { get; set; }

    public int? Enableflag { get; set; }

    public string? AccountName { get; set; }

    public string? OriginalDescription1 { get; set; }
}
