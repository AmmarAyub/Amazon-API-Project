using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ContactCompany
{
    public int ContactCompanyId { get; set; }

    public int? ExternalId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyName2 { get; set; }

    public string? BillToTitle { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public bool? Iso1099 { get; set; }

    public string? PhotoPath { get; set; }

    public string? Notes { get; set; }

    public int? PaymentId { get; set; }

    public int? Status { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public string? AccountOwner { get; set; }

    public virtual AspNetUser? AccountOwnerNavigation { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual ICollection<PaymentMade> PaymentMades { get; set; } = new List<PaymentMade>();

    public virtual ICollection<Porequest> PorequestCustomers { get; set; } = new List<Porequest>();

    public virtual ICollection<Porequest> PorequestVendors { get; set; } = new List<Porequest>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
