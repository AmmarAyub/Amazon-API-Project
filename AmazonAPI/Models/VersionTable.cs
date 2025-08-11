using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class VersionTable
{
    public int VersionId { get; set; }

    public string? VersionName { get; set; }

    public DateTime? VersionDate { get; set; }

    public string? Description { get; set; }
}
