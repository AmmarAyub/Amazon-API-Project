using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ProductManufacturer
{
    public int ManufacturerId { get; set; }

    public string? Name { get; set; }

    public string? ManufacturerRemarks { get; set; }

    public int? ProductId { get; set; }

    public string? ItemCode { get; set; }

    public int? EtzproductId { get; set; }

    public int? EtzmanufacturerId { get; set; }

    public virtual Product? Product { get; set; }
}
