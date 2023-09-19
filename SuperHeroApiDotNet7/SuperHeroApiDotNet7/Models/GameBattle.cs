using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameBattle
{
    public long BattleId { get; set; }

    public string? CreatureId { get; set; }

    public int? CharacterId { get; set; }

    public int? UserId { get; set; }

    public DateTime? InsertDate { get; set; }

    public int? CreatureHpAvailable { get; set; }

    public int? CharacterHpAvailable { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsCharacterWin { get; set; }

    public bool? IsFinish { get; set; }

    public int? CharacterHp { get; set; }

    public int? CreatureHp { get; set; }
}
