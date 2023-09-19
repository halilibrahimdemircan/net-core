using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameUsers
{
    public int UserId { get; set; }

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }
}
