using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public int? PrimaryCompanyId { get; set; }

    public string? Title { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? HomePhone { get; set; }

    public string? Extension { get; set; }

    public string? Mobile { get; set; }

    public string? UserId { get; set; }

    public string? Notes { get; set; }

    public int? ReportsToId { get; set; }

    public string? PhotoPath { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public int Status { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual ICollection<AttendDetail> AttendDetails { get; set; } = new List<AttendDetail>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<EmailNotificationsDetail> EmailNotificationsDetails { get; set; } = new List<EmailNotificationsDetail>();

    public virtual ICollection<EmployeeCompany> EmployeeCompanies { get; set; } = new List<EmployeeCompany>();

    public virtual ICollection<Employee> InverseReportsTo { get; set; } = new List<Employee>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<LeaveRequestDetail> LeaveRequestDetails { get; set; } = new List<LeaveRequestDetail>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();

    public virtual Employee? ReportsTo { get; set; }

    public virtual ICollection<ResponsibilityUser> ResponsibilityUsers { get; set; } = new List<ResponsibilityUser>();

    public virtual ICollection<Rule> Rules { get; set; } = new List<Rule>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual AspNetUser? User { get; set; }
}
