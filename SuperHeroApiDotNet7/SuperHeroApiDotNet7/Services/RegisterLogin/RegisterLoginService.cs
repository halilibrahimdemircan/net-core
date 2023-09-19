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

        public async Task<List<GameUsers>?> Login(RegisterLoginModels.Login request)
        {
            var result = await _context.GameUsers.Where(x => x.Email == request.Email && x.Password==request.Password).ToListAsync();
            if (result.Count()==0)
                return null;
            return result;

        }
    }
}

