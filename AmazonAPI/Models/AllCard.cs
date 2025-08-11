using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AllCard
{
    public int Id { get; set; }

    public int? AccountId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public double? Amount { get; set; }

    public string? ChargedTo { get; set; }

    public string? Status { get; set; }

    public virtual Accountname? Account { get; set; }
}
