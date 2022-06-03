using Microsoft.EntityFrameworkCore;
using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Infra.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<AnimeEntity>? Animes { get; set; }
        public DbSet<EpisodeEntity>? Episodes { get; set; }
        public DbSet<SeasonEntity>? Seasons { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
