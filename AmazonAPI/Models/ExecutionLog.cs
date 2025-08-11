using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ExecutionLog
{
    public int LogId { get; set; }

    public int? ProcedureId { get; set; }

    public string? ProcedureName { get; set; }

    public DateTime? ExecutionTime { get; set; }

    public string? Parameters { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? ExecutionDate { get; set; }
}
