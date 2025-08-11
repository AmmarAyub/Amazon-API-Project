using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerContact
{
    public int ContactId { get; set; }

    public int? PartnerId { get; set; }

    public string ContactName { get; set; } = null!;

    public string? ContactRole { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Notes { get; set; }

    public virtual Partner? Partner { get; set; }
}
