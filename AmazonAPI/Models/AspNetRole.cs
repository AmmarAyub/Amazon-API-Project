using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? DataAccessId { get; set; }

    public virtual ICollection<RoleRight> RoleRights { get; set; } = new List<RoleRight>();
}
