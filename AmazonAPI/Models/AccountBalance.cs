using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AccountBalance
{
    public int BalanceId { get; set; }

    public int AccountId { get; set; }

    public decimal Amount { get; set; }

    public DateOnly BalanceDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreateDate { get; set; }
}
