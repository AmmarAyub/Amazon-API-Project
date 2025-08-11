using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Accountname
{
    public int IdaccName { get; set; }

    public string? AccountName { get; set; }

    public string? TypeofAccount { get; set; }

    public string? DefaultUser { get; set; }

    public string? Last4 { get; set; }

    public string? CardDescription { get; set; }

    public string? OtherNames { get; set; }

    public virtual ICollection<AllCard> AllCards { get; set; } = new List<AllCard>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<FinalTransaction> FinalTransactions { get; set; } = new List<FinalTransaction>();

    public virtual ICollection<PaymentMade> PaymentMades { get; set; } = new List<PaymentMade>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
