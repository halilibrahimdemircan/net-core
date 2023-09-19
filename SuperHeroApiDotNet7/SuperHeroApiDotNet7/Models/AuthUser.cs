using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class AuthUser
{
    public int Id { get; set; }

    public string Password { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public bool IsSuperuser { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsStaff { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateJoined { get; set; }

    public virtual ICollection<AuthUserGroups> AuthUserGroups { get; set; } = new List<AuthUserGroups>();

    public virtual ICollection<AuthUserUserPermissions> AuthUserUserPermissions { get; set; } = new List<AuthUserUserPermissions>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLog { get; set; } = new List<DjangoAdminLog>();
}
