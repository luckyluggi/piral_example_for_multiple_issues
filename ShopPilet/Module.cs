using Microsoft.Extensions.DependencyInjection;

namespace ShopPilet
{
	public class Module
	{
		public static void Main()
		{
			// this entrypoint should remain empty
		}

		public static void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<RedCartState>();
		}
	}
}
