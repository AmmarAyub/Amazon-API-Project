using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string? Refrence { get; set; }

    public string? ContactType { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ContactTitle { get; set; }

    public int? ContactCompanyId { get; set; }

    public string? Department { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Extension { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public string? Website { get; set; }

    public bool? Iso1099 { get; set; }

    public string? PhotoPath { get; set; }

    public string? Notes { get; set; }

    public int? Tax { get; set; }

    public int Status { get; set; }

    public bool? Reseller { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ContactCompany? ContactCompany { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Porequest> Porequests { get; set; } = new List<Porequest>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual List StatusNavigation { get; set; } = null!;

    public virtual TaxRate? TaxNavigation { get; set; }
}
