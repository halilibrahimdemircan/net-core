using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameSkillAndStat
{
    public int SkillId { get; set; }

    public string SkillName { get; set; } = null!;

    public int SkillMin { get; set; }

    public int SkillMax { get; set; }

    public bool IsSkill { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageName { get; set; }
}
