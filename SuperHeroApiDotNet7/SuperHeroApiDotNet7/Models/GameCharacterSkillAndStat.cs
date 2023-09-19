using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCharacterSkillAndStat
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CharacterId { get; set; }

    public int? SkillId { get; set; }

    public decimal? Point { get; set; }
}
