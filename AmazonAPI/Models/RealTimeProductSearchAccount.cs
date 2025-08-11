using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class RealTimeProductSearchAccount
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? CustomerNo { get; set; }

    public string? AccountCompanyName { get; set; }

    public string? AccountName { get; set; }

    public bool? DefaultAccount { get; set; }
}
