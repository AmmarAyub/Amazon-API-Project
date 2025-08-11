using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ChartofAcctToCategory
{
    public int Id { get; set; }

    public string GlCode { get; set; } = null!;

    public int CompId { get; set; }

    public int CategoryId { get; set; }
}
