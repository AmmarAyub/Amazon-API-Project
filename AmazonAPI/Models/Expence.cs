using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Expence
{
    public int ExpenseId { get; set; }

    public int? Category { get; set; }

    public int? SubCategory { get; set; }

    public string? ExpenseDetail { get; set; }

    public decimal? Amount { get; set; }

    public int? Company { get; set; }

    public string? PaidBy { get; set; }

    public int? Department { get; set; }

    public string? ExpensedBy { get; set; }

    public string? ApprovedBy { get; set; }

    public bool? ApprovedByStatus { get; set; }

    public string? ManagerApproval { get; set; }

    public bool? ManagerApprovalStatus { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? ExpenceDate { get; set; }

    public decimal? PkrAmmount { get; set; }

    public decimal? CurrentDollorRate { get; set; }

    public int? PaidVia { get; set; }

    public bool? ExpanceOccured { get; set; }

    public string? PaymentContact { get; set; }

    public bool? PaymentStatus { get; set; }

    public int? TransactionId { get; set; }

    public int? FormId { get; set; }

    public int? DocumentId { get; set; }

    public virtual AspNetUser? ApprovedByNavigation { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }

    public virtual AspNetUser? ExpensedByNavigation { get; set; }

    public virtual AspNetUser? ManagerApprovalNavigation { get; set; }

    public virtual AspNetUser? PaidByNavigation { get; set; }
}
