using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StateShippingTax
{
    public string StateName { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public bool ShippingTaxable { get; set; }

    public DateTime LastUpdated { get; set; }
}
