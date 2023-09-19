using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCreatures
{
    public int? CreatureId { get; set; }

    public string? Name { get; set; }

    public string? SubName { get; set; }

    public int? MinLevel { get; set; }

    public int? MaxLevel { get; set; }

    public int? Rank { get; set; }

    public int? MinGold { get; set; }

    public int? MaxGold { get; set; }

    public int? Id { get; set; }

    public int? HealthPoints { get; set; }

    public int? Class { get; set; }

    public int? AttackPower { get; set; }

    public bool? IsQuest { get; set; }

    public string? ImageUrl { get; set; }
}
