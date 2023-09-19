using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameItems
{
    public int? ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? ItemLevel { get; set; }

    public int? Quality { get; set; }

    public string? Description { get; set; }

    public int? Stackable { get; set; }

    public long? BuyPrice { get; set; }

    public long? SellPrice { get; set; }

    public string? ItemClass { get; set; }

    public string? ItemSubClass { get; set; }

    public string? ItemType { get; set; }

    public string? InventoryTypeWow { get; set; }

    public string? WeaponInfo { get; set; }

    public int? MaxCount { get; set; }

    public int? MaxDurability { get; set; }

    public string? RequiredSkill { get; set; }

    public bool? Upgradable { get; set; }

    public int? Id { get; set; }

    public bool? Equippable { get; set; }

    public string? InventoryType { get; set; }

    public string? BonusStats { get; set; }

    public int? RequiredLevel { get; set; }
}
