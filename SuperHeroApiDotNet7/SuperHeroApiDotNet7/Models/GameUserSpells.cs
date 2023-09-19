using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameUserSpells
{
    public int UserSpellId { get; set; }

    public int? UserId { get; set; }

    public string? Spells { get; set; }
}
