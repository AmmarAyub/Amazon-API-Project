using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ToolTip
{
    public int ToolTipId { get; set; }

    public int FormId { get; set; }

    public string TableName { get; set; } = null!;

    public string? ColumnName { get; set; }

    public string? DataType { get; set; }

    public string? ToolTipMessage { get; set; }

    public string? FieldMessage { get; set; }

    public virtual Form Form { get; set; } = null!;
}
