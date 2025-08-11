using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewSystemsSqlbackup
{
    public long? Id { get; set; }

    public string? Server { get; set; }

    public string? DatabaseName { get; set; }

    public DateTime? BackupStartDate { get; set; }

    public DateTime? BackupFinishDate { get; set; }

    public int? TimeTaken { get; set; }

    public string? BackupType { get; set; }

    public string? Type { get; set; }

    public decimal? SizeInGb { get; set; }

    public string? PhysicalDeviceName { get; set; }
}
