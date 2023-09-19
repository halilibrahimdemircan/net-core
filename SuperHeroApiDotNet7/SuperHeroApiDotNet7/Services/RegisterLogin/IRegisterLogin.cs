using System;
namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
	public interface IRegisterLogin
	{
		List<GameUsers> Login(CustomModels.RegisterLoginModels.Login request);
	}
}

