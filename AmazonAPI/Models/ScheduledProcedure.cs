using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ScheduledProcedure
{
    public int ProcedureId { get; set; }

    public string ProcedureName { get; set; } = null!;

    public TimeOnly? ExecutionTime { get; set; }

    public string? Parameters { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<StoreProcedureParam> StoreProcedureParams { get; set; } = new List<StoreProcedureParam>();
}
