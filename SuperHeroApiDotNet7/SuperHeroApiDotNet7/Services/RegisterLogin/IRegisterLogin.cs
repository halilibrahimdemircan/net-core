namespace SuperHeroApiDotNet7.Services.RegisterLogin
{
	public interface IRegisterLogin
	{
		Task<List<GameUsers>?> Login(CustomModels.RegisterLoginModels.Login request);
	}
}

