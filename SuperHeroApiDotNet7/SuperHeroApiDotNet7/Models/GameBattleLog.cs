using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameBattleLog
{
    public long? BattleId { get; set; }

    public int? CharacterHp { get; set; }

    public string? CreatureHp { get; set; }

    public string? CharacterSkillName { get; set; }

    public int? Damage { get; set; }

    public bool? IsCharacterAttack { get; set; }

    public string? Description { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? StatsDescriptionList { get; set; }

    public string? CharacterSpellName { get; set; }

    public int? CharacterSpellId { get; set; }

    public long Id { get; set; }
}
