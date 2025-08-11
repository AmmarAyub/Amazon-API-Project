using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class FormSequence
{
    public int FormSequenceId { get; set; }

    public string UserId { get; set; } = null!;

    public int FormId { get; set; }

    public int ColId { get; set; }

    public int ColSequence { get; set; }

    public bool ColStatus { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
