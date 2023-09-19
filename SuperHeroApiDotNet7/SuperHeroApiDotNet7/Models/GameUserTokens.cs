using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.Models;

public partial class GameUserTokens
{
    public int TokenId { get; set; }

    public int? UserId { get; set; }

    public string? Token { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UserAgent { get; set; }

    public string? RemoteIp { get; set; }

    public string? Tokenios { get; set; }

    public string? Tokenandroid { get; set; }
}
