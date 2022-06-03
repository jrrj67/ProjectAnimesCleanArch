using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectAnimes.Infra.Ioc.Extensions;

namespace ProjectAnimes.Infra.Ioc
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddAnime();

            return services;
        }
    }
}
