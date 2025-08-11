using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PaymentMade
{
    public int PaymentMadeId { get; set; }

    public int? ContactCompanyId { get; set; }

    public int? AccountNameId { get; set; }

    public int? MethodId { get; set; }

    public DateOnly? DateReceived { get; set; }

    public string? Reference { get; set; }

    public double? TotalAmmount { get; set; }

    public string? PaymentMadeDocument { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public int? FinalTransactionId { get; set; }

    public virtual Accountname? AccountName { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ContactCompany? ContactCompany { get; set; }

    public virtual FinalTransaction? FinalTransaction { get; set; }

    public virtual PaymentTerm? Method { get; set; }

    public virtual ICollection<PaymentMadeBill> PaymentMadeBills { get; set; } = new List<PaymentMadeBill>();
}
