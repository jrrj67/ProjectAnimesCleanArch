using ProjectAnimes.Application.Models.DTOs;
using ProjectAnimes.Application.Models.ViewModels;

namespace ProjectAnimes.Application.Services.AnimeService
{
    public interface IAnimeService
    {
        public Task<AnimeVm> GetByIdAsync(Guid id);
        public Task<ICollection<AnimeVm>> GetAllAsync();
        public Task<AnimeVm> CreateAsync(AnimeDTO anime);
        public Task<AnimeVm> UpdateAsync(Guid id);
        public Task<AnimeVm> DeleteAsync(Guid id);
    }
}
