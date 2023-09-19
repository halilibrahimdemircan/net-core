using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameFarm
{
    public int FarmId { get; set; }

    public int CreatureId { get; set; }

    public int? CharacterId { get; set; }

    public int? UserId { get; set; }
}
