using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewInvoiceWeeklyTotal
{
    public decimal? InvTotal { get; set; }

    public int InvoiceId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? InvoiceDate { get; set; }
}
