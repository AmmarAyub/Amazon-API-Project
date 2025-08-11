using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AccountNameTemp
{
    public string IdaccName { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string TypeofAccount { get; set; } = null!;

    public string? DefaultUser { get; set; }

    public string? Last4 { get; set; }

    public string? CardDescription { get; set; }
}
