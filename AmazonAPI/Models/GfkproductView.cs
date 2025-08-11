using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class GfkproductView
{
    public string ProductName { get; set; } = null!;

    public int UnitPrice { get; set; }

    public string ItemCode { get; set; } = null!;

    public int Productid { get; set; }

    public string? Productimage { get; set; }

    public int Manufacturerid { get; set; }
}
