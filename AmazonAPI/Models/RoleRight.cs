using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class RoleRight
{
    public int RoleRightsId { get; set; }

    public string RoleId { get; set; } = null!;

    public int FormId { get; set; }

    public bool Access { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool CanView { get; set; }

    public bool CanAdd { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public virtual AspNetRole Role { get; set; } = null!;
}
