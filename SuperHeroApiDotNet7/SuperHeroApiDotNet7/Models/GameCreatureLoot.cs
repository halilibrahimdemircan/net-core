using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCreatureLoot
{
    public int? CreatureId { get; set; }

    public string? CreatureName { get; set; }

    public int? ItemId { get; set; }

    public decimal? Chance { get; set; }

    public int? MinCount { get; set; }

    public int? MaxCount { get; set; }

    public int? Id { get; set; }
}
