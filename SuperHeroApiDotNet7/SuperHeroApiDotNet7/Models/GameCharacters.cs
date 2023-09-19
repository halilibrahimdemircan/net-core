using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCharacters
{
    public int CharacterId { get; set; }

    public int? UserId { get; set; }

    public string CharacterName { get; set; } = null!;

    public int? Level { get; set; }

    public int? HealthPointsMax { get; set; }

    public int? HealthPointsAvailable { get; set; }

    public long? GoldAmount { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageName { get; set; }
}
