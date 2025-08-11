using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ApiCreateAfter
{
    public int Id { get; set; }

    public string? CreateAfter { get; set; }

    public string? RefreshToken { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }
}
