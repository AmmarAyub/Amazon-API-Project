using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StoreProcedureList
{
    public int StoreProcedureId { get; set; }

    public string? StoreProcedureName { get; set; }

    public string? DisplayName { get; set; }

    public string? Notes { get; set; }
}
