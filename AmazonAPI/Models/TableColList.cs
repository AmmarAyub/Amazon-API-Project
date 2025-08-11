using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TableColList
{
    public int TableColId { get; set; }

    public string TableColName { get; set; } = null!;

    public int TableId { get; set; }

    public virtual Form Table { get; set; } = null!;
}
