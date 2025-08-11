using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AccountsUpload
{
    public int Id { get; set; }

    public string? AccountName { get; set; }

    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public string? Amount { get; set; }

    public string? TransactionType { get; set; }

    public string? CompanyCharged { get; set; }

    public string? Category { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public string? Lable { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }
}
