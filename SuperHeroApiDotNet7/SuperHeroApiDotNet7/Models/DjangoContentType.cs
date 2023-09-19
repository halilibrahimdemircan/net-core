using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class DjangoContentType
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<AuthPermission> AuthPermission { get; set; } = new List<AuthPermission>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLog { get; set; } = new List<DjangoAdminLog>();
}
