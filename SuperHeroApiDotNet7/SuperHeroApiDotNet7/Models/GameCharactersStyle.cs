using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameCharactersStyle
{
    public int? CharacterId { get; set; }

    public string? HairStyle { get; set; }

    public string? FacialHairStyle { get; set; }

    public string? SkinTone { get; set; }

    public string? ShirtColor { get; set; }

    public string? PantsColor { get; set; }

    public string? HairColor { get; set; }

    public string? FacialHairColor { get; set; }

    public bool? IsMale { get; set; }
}
