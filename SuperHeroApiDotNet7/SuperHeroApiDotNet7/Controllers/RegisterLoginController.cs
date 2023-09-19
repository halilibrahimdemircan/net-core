using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApiDotNet7.Models;
using SuperHeroApiDotNet7.Services.RegisterLogin;

namespace SuperHeroApiDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterLoginController : ControllerBase
    {
        private readonly IRegisterLogin _registerLoginService;

        public RegisterLoginController(IRegisterLogin registerLoginService)
        {
            _registerLoginService = registerLoginService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<CustomModels.RegisterLoginModels.Success>> Login(CustomModels.RegisterLoginModels.Login request)
        {
            var result = await _registerLoginService.Login(request);
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<CustomModels.RegisterLoginModels.Success>> Register(CustomModels.RegisterLoginModels.Register request)
        {
            var result = await _registerLoginService.Register(request);
            return Ok(result);
        }
    }
}