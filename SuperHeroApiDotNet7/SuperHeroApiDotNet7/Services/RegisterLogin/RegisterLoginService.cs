using System;
using SuperHeroApiDotNet7.CustomModels;
using SuperHeroApiDotNet7.Models;

namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
    public class RegisterLoginService : IRegisterLogin
    {
        private readonly DataContext _context;
        public RegisterLoginService(DataContext context)
        {
            _context = context;
        }

        List<GameUsers> IRegisterLogin.Login(RegisterLoginModels.Login request)
        {
            throw new NotImplementedException();
        }
    }
}

