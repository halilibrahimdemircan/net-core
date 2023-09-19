global using Microsoft.EntityFrameworkCore;

namespace SuperHeroApiDotNet7.Data
{
    public class DataContext: DbContext
	{
		public DataContext(DbContextOptions<DataContext> options ) : base(options)
		{

		}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=104.247.165.244;Database=game;Username=game_admin;Password=sU8^0338zB!e;");
        }
    }

}

