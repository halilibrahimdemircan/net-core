using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class CraftVwCraftItems
{
    public int? ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? RequiredLevel { get; set; }

    public string? RequiredItems { get; set; }
}
