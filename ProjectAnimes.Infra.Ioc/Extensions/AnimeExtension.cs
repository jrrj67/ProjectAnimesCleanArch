using Microsoft.Extensions.DependencyInjection;
using ProjectAnimes.Application.Services.AnimeService;
using ProjectAnimes.Domain.Interfaces;
using ProjectAnimes.Infra.Data.Repositories;

namespace ProjectAnimes.Infra.Ioc.Extensions
{
    public static class AnimeExtension
    {
        public static IServiceCollection AddAnime(this IServiceCollection services)
        {
            services.AddScoped<IAnimeRepository, AnimeRepository>();

            services.AddScoped<IAnimeService, AnimeService>();

            return services;
        }
    }
}
