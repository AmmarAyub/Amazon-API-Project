using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ShipTo
{
    public int ShipToId { get; set; }

    public int ContactId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? ContactTitle { get; set; }

    public string? ContactCompanyId { get; set; }

    public string? Department { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Extension { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public string? Website { get; set; }

    public int Status { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }
}
