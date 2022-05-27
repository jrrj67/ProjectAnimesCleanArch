using ProjectAnimes.Domain.Entities;

var anime = new AnimeEntity(id: Guid.NewGuid(), name: "Naruto");

anime.Name = "N";

Console.ReadLine();