using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCharacterInventory
{
    public int? Id { get; set; }

    public int? CharacterId { get; set; }

    public string? ItemId { get; set; }

    public string? Additional { get; set; }

    public string? Enchant { get; set; }

    public int? Durability { get; set; }

    public int? Slot { get; set; }

    public string? ItemName { get; set; }

    public int? MaxDurability { get; set; }
}
