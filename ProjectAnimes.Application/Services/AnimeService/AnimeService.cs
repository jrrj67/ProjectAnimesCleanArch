using AutoMapper;
using ProjectAnimes.Application.Models.DTOs;
using ProjectAnimes.Application.Models.ViewModels;
using ProjectAnimes.Domain.Entities;
using ProjectAnimes.Domain.Interfaces;

namespace ProjectAnimes.Application.Services.AnimeService
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IMapper _mapper;

        public AnimeService(IAnimeRepository animeRepository, IMapper mapper)
        {
            _animeRepository = animeRepository;
            _mapper = mapper;
        }

        public async Task<AnimeVm> CreateAsync(AnimeDTO dto)
        {
            var entity = _mapper.Map<AnimeEntity>(dto);

            var createdEntity = await _animeRepository.CreateAsync(entity);

            var viewModel = _mapper.Map<AnimeVm>(createdEntity);

            return viewModel;
        }

        public async Task<AnimeVm> DeleteAsync(Guid id)
        {
            var deletedEntity = await _animeRepository.DeleteAsync(id);

            var viewModel = _mapper.Map<AnimeVm>(deletedEntity);

            return viewModel;
        }

        public async Task<ICollection<AnimeVm>> GetAllAsync()
        {
            var entities = await _animeRepository.GetAllAsync();

            var viewModels = _mapper.Map<ICollection<AnimeVm>>(entities);

            return viewModels;
        }

        public async Task<AnimeVm> GetByIdAsync(Guid id)
        {
            var entity = await _animeRepository.GetByIdAsync(id);

            var viewModel = _mapper.Map<AnimeVm>(entity);

            return viewModel;
        }

        public async Task<AnimeVm> UpdateAsync(Guid id)
        {
            var updatedEntity = await _animeRepository.UpdateAsync(id);

            var viewModel = _mapper.Map<AnimeVm>(updatedEntity);

            return viewModel;
        }
    }
}
