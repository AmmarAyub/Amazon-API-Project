using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AmazonApiInsertLog
{
    public int Id { get; set; }

    public DateTime? ExecDate { get; set; }

    public string? AmazonOrderid { get; set; }

    public int? ContactCompanyId { get; set; }

    public int? ContactId { get; set; }

    public int? ProductId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public int? PurchaseOrderDetailId { get; set; }

    public string? Comments { get; set; }
}
