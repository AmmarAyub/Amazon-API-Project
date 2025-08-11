using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ReceiptInvoice
{
    public int Id { get; set; }

    public int? ReceiptId { get; set; }

    public int? InvoiceId { get; set; }

    public double? InvoiceAmmount { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Receipt? Receipt { get; set; }
}
