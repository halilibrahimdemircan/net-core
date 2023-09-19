using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameSpell
{
    public int? SpellId { get; set; }

    public int? SkillId { get; set; }

    public string? SpellName { get; set; }

    public int? CoolDownCount { get; set; }

    public int? RequiredSkillPoint { get; set; }

    public bool? IsDamageSpell { get; set; }

    public string? Desciription { get; set; }

    public int? MinPower { get; set; }

    public int? MaxPower { get; set; }

    public int? EffectRoundCount { get; set; }

    public int? EffectMinPower { get; set; }

    public int? EffectMaxPower { get; set; }

    public bool? IsRequiredShield { get; set; }

    public int? Id { get; set; }

    public string? ImageName { get; set; }

    public string? ImageUrl { get; set; }
}
