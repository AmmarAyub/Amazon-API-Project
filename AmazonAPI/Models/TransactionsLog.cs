using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TransactionsLog
{
    public int LogId { get; set; }

    public string? UserId { get; set; }

    public int? TransectionId { get; set; }

    public string? CategoryName { get; set; }

    public string? SubCategoryName { get; set; }

    public int? CompanyCharged { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? ContactCompany { get; set; }

    public string? Process { get; set; }

    public DateTime? TimeStamp { get; set; }

    public virtual AspNetUser? User { get; set; }
}
