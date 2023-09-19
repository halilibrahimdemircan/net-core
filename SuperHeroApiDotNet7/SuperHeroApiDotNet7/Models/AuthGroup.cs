using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class AuthGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; } = new List<AuthGroupPermissions>();

    public virtual ICollection<AuthUserGroups> AuthUserGroups { get; set; } = new List<AuthUserGroups>();
}
