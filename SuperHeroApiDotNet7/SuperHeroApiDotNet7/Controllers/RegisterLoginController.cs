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

        [HttpPost]
        public async Task<ActionResult<List<CustomModels.RegisterLoginModels.Login>>> Login(CustomModels.RegisterLoginModels.Login request)
        {
            var _result = _registerLoginService.Login(request);
            return Ok(_result);
        }


    }
}
