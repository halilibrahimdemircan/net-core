using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class DjangoMigrations
{
    public long Id { get; set; }

    public string App { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Applied { get; set; }
}
