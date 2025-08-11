using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmailToList
{
    public int Id { get; set; }

    public Guid? EmailId { get; set; }

    public string? EmailTo { get; set; }

    public virtual EmailTracking? Email { get; set; }
}
