namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
	public interface IRegisterLogin
	{
		Task<CustomModels.RegisterLoginModels.Response?> Login(CustomModels.RegisterLoginModels.Login request);
        Task<CustomModels.RegisterLoginModels.Response?> Register(CustomModels.RegisterLoginModels.Register request);
    }
}

