using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Receipt
{
    public int ReceiptId { get; set; }

    public int? ContactCompanyId { get; set; }

    public int? AccountNameId { get; set; }

    public int? MethodId { get; set; }

    public DateOnly? DateReceived { get; set; }

    public string? Reference { get; set; }

    public double? Fees { get; set; }

    public double? Tax { get; set; }

    public double? TotalAmmount { get; set; }

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

    public virtual ICollection<ReceiptInvoice> ReceiptInvoices { get; set; } = new List<ReceiptInvoice>();
}
