namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
	public interface IRegisterLogin
	{
		Task<CustomModels.RegisterLoginModels.Success?> Login(CustomModels.RegisterLoginModels.Login request);
        Task<CustomModels.RegisterLoginModels.Success?> Register(CustomModels.RegisterLoginModels.Register request);
    }
}

