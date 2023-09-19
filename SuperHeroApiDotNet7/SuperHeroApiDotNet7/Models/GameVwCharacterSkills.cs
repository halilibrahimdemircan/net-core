using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameVwCharacterSkills
{
    public int? CharacterId { get; set; }

    public int? SkillId { get; set; }

    public decimal? Point { get; set; }

    public string? SkillName { get; set; }

    public bool? IsSkill { get; set; }
}
