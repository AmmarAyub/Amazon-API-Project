using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Synnex2024
{
    public string? Po { get; set; }

    public int? Order { get; set; }

    public int? Invoice { get; set; }

    public string? Cin { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public double? OrderTotal { get; set; }

    public double? PayAmount { get; set; }

    public int? PaymentDate { get; set; }

    public int? CloseDate { get; set; }

    public int? BatchRefId { get; set; }

    public string? PaymentConfirmationId { get; set; }
}
