using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameDungeons
{
    public int DungeonId { get; set; }

    public string DungeonName { get; set; } = null!;

    public int? RequiredLevel { get; set; }
}
