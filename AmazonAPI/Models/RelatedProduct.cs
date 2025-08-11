using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class RelatedProduct
{
    public int RelatedProductId { get; set; }

    public int ProductId { get; set; }

    public int RelatedProduct1 { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime HstryDateTime { get; set; }

    public virtual AspNetUser HstryUser { get; set; } = null!;
}
