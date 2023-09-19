using System;
using System.Collections.Generic;

namespace SuperHeroApiDotNet7.CustomModels;

public class RegisterLoginModels
{
    public class Register
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }

    public class Login
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
    public class LoginSuccess
    {
        public bool success { get; set; }
        public string? token { get; set; }
        public string? error_messega { get; set; }
    }
}