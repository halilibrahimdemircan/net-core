using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class AuthPermission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ContentTypeId { get; set; }

    public string Codename { get; set; } = null!;

    public virtual ICollection<AuthGroupPermissions> AuthGroupPermissions { get; set; } = new List<AuthGroupPermissions>();

    public virtual ICollection<AuthUserUserPermissions> AuthUserUserPermissions { get; set; } = new List<AuthUserUserPermissions>();

    public virtual DjangoContentType ContentType { get; set; } = null!;
}
