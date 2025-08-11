using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AmazonApiProductInsertLog
{
    public DateTime ExecDate { get; set; }

    public string? AmazonOrderid { get; set; }

    public string? SellerSku { get; set; }
}
