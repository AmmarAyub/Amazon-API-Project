using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Log
{
    public string LogId { get; set; } = null!;

    public DateTime? LogDate { get; set; }

    public int? FormId { get; set; }

    public int? DocId { get; set; }

    public string? Action { get; set; }

    public string? UserId { get; set; }

    public string? Changes { get; set; }

    public string? UserName { get; set; }

    public string? HostName { get; set; }

    public string? Ipaddress { get; set; }

    public string? MachineName { get; set; }
}
