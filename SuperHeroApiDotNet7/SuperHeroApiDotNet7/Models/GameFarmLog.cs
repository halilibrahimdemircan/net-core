using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameFarmLog
{
    public long Id { get; set; }

    public long? FarmId { get; set; }

    public string? CharacterSkillName { get; set; }

    public string? CharacterSpellName { get; set; }

    public string? DesciriptionList { get; set; }

    public string? StatsDescriptionList { get; set; }

    public int? CharacterSpellId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
