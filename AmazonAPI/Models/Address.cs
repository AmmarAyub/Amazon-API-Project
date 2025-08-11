using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Address
{
    public string DisplayName { get; set; } = null!;

    public string? Attention { get; set; }

    public string? Address1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Code { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }
}
