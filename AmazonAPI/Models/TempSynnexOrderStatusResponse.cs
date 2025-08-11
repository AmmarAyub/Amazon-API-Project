using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TempSynnexOrderStatusResponse
{
    public int OrderResponseId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? Ponumber { get; set; }

    public string? Code { get; set; }

    public DateTime? Podatetime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public string? ResponseElapsedTime { get; set; }
}
