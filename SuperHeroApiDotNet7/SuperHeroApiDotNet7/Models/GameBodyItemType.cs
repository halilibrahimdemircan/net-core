using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameBodyItemType
{
    public string? ItemClass { get; set; }

    public string? ItemType { get; set; }

    public string? AcceptType { get; set; }

    public int? BodySlot { get; set; }
}
