using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ProductsUpload
{
    public string ProductName { get; set; } = null!;

    public int UnitPrice { get; set; }

    public int Status { get; set; }

    public string ItemCode { get; set; } = null!;

    public int GfkproductId { get; set; }
}
