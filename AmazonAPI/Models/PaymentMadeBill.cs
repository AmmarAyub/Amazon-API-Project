using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PaymentMadeBill
{
    public int Id { get; set; }

    public int? PaymentMadeId { get; set; }

    public int? BillsId { get; set; }

    public double? BillsAmmount { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime? HstryDateTime { get; set; }

    public virtual Bill? Bills { get; set; }

    public virtual PaymentMade? PaymentMade { get; set; }
}
