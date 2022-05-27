using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Domain.Interfaces
{
    public interface IAnimeRepository
    {
        public Task<AnimeEntity> GetByIdAsync(Guid id);
        public Task<ICollection<AnimeEntity>> GetAllAsync();
        public Task<AnimeEntity> CreateAsync(AnimeEntity anime);
        public Task<AnimeEntity> UpdateAsync(Guid id);
        public Task<AnimeEntity> DeleteAsync(Guid id);
    }
}
