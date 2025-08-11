using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StoreProcedureParam
{
    public int StoreProcedureIparamD { get; set; }

    public int StoreProcedureId { get; set; }

    public string? ParamName { get; set; }

    public string? ParamValue { get; set; }

    public string? Notes { get; set; }

    public virtual ScheduledProcedure StoreProcedure { get; set; } = null!;
}
