using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewIssueStatus
{
    public string ListValue { get; set; } = null!;

    public int? Ticket { get; set; }
}
