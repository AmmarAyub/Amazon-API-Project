using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class FinalTransaction
{
    public int Id { get; set; }

    public int? AccountId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public string? OriginalDescription { get; set; }

    public double? Amount { get; set; }

    public string? TransactionType { get; set; }

    public int? CategoryId { get; set; }

    public string? Category { get; set; }

    public int? SubCategoryId { get; set; }

    public string? SubCategory { get; set; }

    public string? Labels { get; set; }

    public string? Notes { get; set; }

    public string? AccountType { get; set; }

    public string? PreviouslyChargedTo { get; set; }

    public string? DefaultActUser { get; set; }

    public int? CompanyCharged { get; set; }

    public string? Personal { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool? IsAudit { get; set; }

    public bool? IsReconcile { get; set; }

    public bool? IsAssigned { get; set; }

    public int? ContactCompanyId { get; set; }

    public string? TypeOfCharges { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Accountname? Account { get; set; }

    public virtual ICollection<PaymentMade> PaymentMades { get; set; } = new List<PaymentMade>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
