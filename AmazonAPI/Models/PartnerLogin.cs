using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerLogin
{
    public int LoginId { get; set; }

    public int? PartnerId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? LoginUrl { get; set; }

    public virtual Partner? Partner { get; set; }
}
