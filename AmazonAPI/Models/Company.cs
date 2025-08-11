using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? OtherNames { get; set; }

    public int? Status { get; set; }

    public string? Notes { get; set; }

    public string? CompanyLogo { get; set; }

    public bool? IsInvoice { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public string? CompanyApprover { get; set; }

    public string? CompanyCashier { get; set; }

    public int? Port { get; set; }

    public string? Host { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? UseDefaultCredentials { get; set; }

    public bool? EnableSsl { get; set; }

    public string? DomainName { get; set; }

    public string? StripApiKey { get; set; }

    public int? StripeAccountNameId { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<CompanyApi> CompanyApis { get; set; } = new List<CompanyApi>();

    public virtual ICollection<CompanyPolicy> CompanyPolicies { get; set; } = new List<CompanyPolicy>();

    public virtual ICollection<EmployeeCompany> EmployeeCompanies { get; set; } = new List<EmployeeCompany>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<PaymentMade> PaymentMades { get; set; } = new List<PaymentMade>();

    public virtual ICollection<Porequest> Porequests { get; set; } = new List<Porequest>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();

    public virtual Accountname? StripeAccountName { get; set; }
}
