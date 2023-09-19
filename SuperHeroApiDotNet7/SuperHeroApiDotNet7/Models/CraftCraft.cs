using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class CraftCraft
{
    public int? CraftId { get; set; }

    public int? ItemId { get; set; }

    public int? RequiredItemId { get; set; }

    public int? RequiredQuantity { get; set; }

    public int? OutputCount { get; set; }
}
