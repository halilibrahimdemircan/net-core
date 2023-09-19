using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameVwCharacterItemsWithInfo
{
    public int? Id { get; set; }

    public int? CharacterId { get; set; }

    public int? ItemId { get; set; }

    public string? Additional { get; set; }

    public int? Durability { get; set; }

    public int? Slot { get; set; }

    public int? Count { get; set; }

    public string? ItemClass { get; set; }

    public string? InventoryType { get; set; }

    public string? ItemName { get; set; }

    public string? BonusStats { get; set; }

    public string? WeaponInfo { get; set; }

    public int? ItemLevel { get; set; }

    public bool? IsBody { get; set; }

    public string? ItemType { get; set; }
}
