namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
	public interface IRegisterLogin
	{
		Task<CustomModels.RegisterLoginModels.LoginSuccess?> Login(CustomModels.RegisterLoginModels.Login request);
	}
}

