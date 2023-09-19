using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameStyles
{
    public int StyleId { get; set; }

    public string StyleTitle { get; set; } = null!;

    public string? StyleValue { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? StyleType { get; set; }
}
