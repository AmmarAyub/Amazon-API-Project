using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewOpenInvoiceSuggestedPo
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public int? PurchaseOrdersId { get; set; }

    public decimal? InvoiceRemainingQuantity { get; set; }
}
