using ProjectAnimes.Domain.Entities;

var anime = new AnimeEntity(id: Guid.NewGuid(), name: "Naruto");

var season = new SeasonEntity(id: Guid.NewGuid(), number: 1, "Primeira temp", anime.Id);

var episodes = new List<EpisodeEntity>()
{
    new EpisodeEntity(id: Guid.NewGuid(), name: "Naruto primeiro epi", url: "https://naruto.com", season.Id)
};

Console.ReadLine();