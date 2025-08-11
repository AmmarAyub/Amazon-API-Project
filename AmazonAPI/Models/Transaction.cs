using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int? AccountId { get; set; }

    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public double? Amount { get; set; }

    public string? TransactionType { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? Labels { get; set; }

    public string? Notes { get; set; }

    public string? AccountType { get; set; }

    public string? PreviouslyChargedTo { get; set; }

    public string? DefaultActUser { get; set; }

    public string? CompanyCharged { get; set; }

    public string? Personal { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool? Enableflag { get; set; }

    public virtual Accountname? Account { get; set; }
}
