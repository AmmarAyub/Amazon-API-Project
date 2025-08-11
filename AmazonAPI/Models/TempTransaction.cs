using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TempTransaction
{
    public DateOnly Date { get; set; }

    public string Description { get; set; } = null!;

    public string OriginalDescription { get; set; } = null!;

    public double Amount { get; set; }

    public string TransactionType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string? Labels { get; set; }

    public string? Notes { get; set; }
}
