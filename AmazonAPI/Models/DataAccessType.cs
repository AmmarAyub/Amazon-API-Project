using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class DataAccessType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }
}
