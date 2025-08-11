using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ProductImage
{
    public int ProductImageId { get; set; }

    public int ProductId { get; set; }

    public string? FilePath { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual AspNetUser HstryUser { get; set; } = null!;
}
