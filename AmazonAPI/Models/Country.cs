using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? Iso31661Alpha2 { get; set; }

    public string? Dial { get; set; }

    public string? Tld { get; set; }
}
