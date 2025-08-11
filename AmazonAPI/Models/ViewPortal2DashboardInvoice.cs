using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPortal2DashboardInvoice
{
    public DateOnly? Date { get; set; }

    public string? CompanyName { get; set; }

    public string? Total { get; set; }

    public string Status { get; set; } = null!;
}
