using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class AuthUserGroups
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public int GroupId { get; set; }

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual AuthUser User { get; set; } = null!;
}
