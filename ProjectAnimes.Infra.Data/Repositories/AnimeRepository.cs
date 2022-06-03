using ProjectAnimes.Domain.Entities;
using ProjectAnimes.Domain.Interfaces;
using ProjectAnimes.Infra.Data.Contexts;

namespace ProjectAnimes.Infra.Data.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly AppDbContext _context;

        public AnimeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AnimeEntity> CreateAsync(AnimeEntity anime)
        {
            _context.Add(anime);

            await _context.SaveChangesAsync();

            return anime;
        }

        public Task<AnimeEntity> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<AnimeEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AnimeEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AnimeEntity> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
