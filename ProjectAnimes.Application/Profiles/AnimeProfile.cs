using AutoMapper;
using ProjectAnimes.Application.Models.DTOs;
using ProjectAnimes.Application.Models.ViewModels;

namespace ProjectAnimes.Application.Profiles
{
    public class AnimeProfile : Profile
    {
        public AnimeProfile()
        {
            CreateMap<AnimeDTO, AnimeVm>().ReverseMap();
        }
    }
}
