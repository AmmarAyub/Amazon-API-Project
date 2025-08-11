using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AuditLog
{
    public Guid? LogId { get; set; }

    public DateTime? LogDate { get; set; }

    public string? TableName { get; set; }

    public string? AuditAction { get; set; }

    public string? AuditCommandDeleted { get; set; }

    public string? AuditCommandCreated { get; set; }

    public string? Login { get; set; }
}
