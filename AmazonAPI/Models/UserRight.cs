using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class UserRight
{
    public int UserRightsId { get; set; }

    public string? UserId { get; set; }

    public int? FormId { get; set; }

    public bool CanView { get; set; }

    public bool CanAdd { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime? HstryDateTime { get; set; }

    public virtual AspNetUser? User { get; set; }
}
