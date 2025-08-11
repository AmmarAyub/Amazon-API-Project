using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AssignedCard
{
    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public string? Amount { get; set; }

    public string? ChargedTo { get; set; }

    public string? Status { get; set; }

    public string? AccountName { get; set; }
}
