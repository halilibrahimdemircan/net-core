using System;
using SuperHeroApiDotNet7.CustomModels;
using SuperHeroApiDotNet7.Models;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;

namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
    public class RegisterLoginService : IRegisterLogin
    {
        //config dosyasindan cekmek icin
        private readonly IConfiguration _config;
        private readonly DataContext _context;
        public RegisterLoginService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public static string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                // String'i byte dizisine dönüştür
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // MD5 hash hesapla
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Hash'i bir dize olarak biçimlendir
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Her byte'ı iki haneli onaltılık olarak biçimlendir
                }

                return sb.ToString();
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // To generate token
        private string GenerateToken(GameUsers user)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Email),
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public async Task<RegisterLoginModels.Success?> Login(RegisterLoginModels.Login request)
        {
            RegisterLoginModels.Success response = new RegisterLoginModels.Success();
            var isValidEmail = IsValidEmail(request.Email.ToLower());
            if (isValidEmail == false)
            {
                response.success = false;
                response.error_messega = "Email Uygun degil";
                return response;
            }
            var user = await _context.GameUsers.Where(x => x.Email == request.Email && x.Password == CalculateMD5Hash(request.Password)).FirstOrDefaultAsync();
            if (user != null)
            {
                var token = GenerateToken(user);
                var user_tokens = _context.GameUserTokens.Where(x => x.UserId == user.UserId).FirstOrDefault();
                user_tokens.Token = token;
                _context.SaveChanges();
                response.success = true;
                response.token = token;
            }
            else
            {
                response.success = false;
                response.error_messega = "User Bulumadım napıcan";
            }
            return response;
        }

        public async Task<RegisterLoginModels.Success?> Register(RegisterLoginModels.Register request)
        {
            RegisterLoginModels.Success response = new RegisterLoginModels.Success();
            var isValidEmail = IsValidEmail(request.Email.ToLower());
            if (isValidEmail == false)
            {
                response.success = false;
                response.error_messega = "Email Uygun degil";
                return response;
            }
            var user = await _context.GameUsers.FirstOrDefaultAsync(x => x.Email.ToLower() == request.Email);
            if (user == null)
            {
                var newUser = new GameUsers()
                {
                    CreatedAt = DateTime.Now,
                    Email = request.Email,
                    Password = CalculateMD5Hash(request.Password),
                    IsDeleted = false,
                    UpdatedAt = DateTime.Now

                };

                _context.GameUsers.Add(newUser);
                await _context.SaveChangesAsync();

                var new_token = GenerateToken(newUser);
                var newUserToken = new GameUserTokens()
                {
                    CreatedAt = DateTime.Now,
                    UserId = newUser.UserId,
                    IsDeleted = false,
                    UpdatedAt = DateTime.Now,
                    Token = new_token

                };
                _context.GameUserTokens.Add(newUserToken);
                await _context.SaveChangesAsync();

                response.success = true;
                response.token = new_token;
                return response;
            }
            response.success = false;
            response.error_messega = "User var kac kere kayıt olacan";
            return response;
        }
    }
}

