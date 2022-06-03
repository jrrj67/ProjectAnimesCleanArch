using Microsoft.AspNetCore.Mvc;
using ProjectAnimes.Application.Services.AnimeService;

namespace ProjectAnimes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : ControllerBase
    {
        private readonly IAnimeService _animeService;

        public AnimesController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var data = await _animeService.GetAllAsync();

            return Ok(data);
        }
    }
}
