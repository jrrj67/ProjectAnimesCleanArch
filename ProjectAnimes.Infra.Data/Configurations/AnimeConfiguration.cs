using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Infra.Data.Configurations
{
    public class AnimeConfiguration : IEntityTypeConfiguration<AnimeEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasMany(x => x.Seasons)
                .WithOne(x => x.Anime)
                .HasForeignKey(x => x.AnimeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<AnimeEntity>()
            {
                new AnimeEntity
                (
                    id: Guid.NewGuid(),
                    name: "Naruto"
                )
            });
        }
    }
}
