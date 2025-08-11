using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmailCclist
{
    public int Id { get; set; }

    public Guid? EmailId { get; set; }

    public string? EmailCc { get; set; }

    public virtual EmailTracking? Email { get; set; }
}
