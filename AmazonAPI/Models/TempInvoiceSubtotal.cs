using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TempInvoiceSubtotal
{
    public int? Invoiceid { get; set; }

    public decimal? Itemtotal { get; set; }
}
