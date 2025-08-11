using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class SessionLog
{
    public int SessionId { get; set; }

    public int? FormsId { get; set; }

    public int? RecordId { get; set; }

    public string? TableName { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? ExpireTime { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }
}
