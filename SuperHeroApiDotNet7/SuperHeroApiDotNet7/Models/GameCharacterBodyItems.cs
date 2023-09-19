using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCharacterBodyItems
{
    public int Id { get; set; }

    public int? CharacterId { get; set; }

    public int? ItemId { get; set; }

    public int? Slot { get; set; }

    public string? Additional { get; set; }

    public int? Durability { get; set; }

    public int? Count { get; set; }
}
