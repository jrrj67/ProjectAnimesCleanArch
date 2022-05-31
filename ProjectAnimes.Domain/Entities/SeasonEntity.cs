using ProjectAnimes.Domain.Validators;

namespace ProjectAnimes.Domain.Entities
{
    public sealed class SeasonEntity : BaseEntity
    {
        private readonly SeasonValidator _validator = new SeasonValidator();

        public Guid AnimeId { get; }

        private int _number;
        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                ValidateProperty(nameof(Number));
            }
        }

        private string _description = string.Empty;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                ValidateProperty(nameof(Description));
            }
        }

        // Nav props

        public AnimeEntity? Anime { get; set; }
        public ICollection<EpisodeEntity>? Episodes { get; set; }

        public SeasonEntity(Guid id, int number, string description, Guid animeId)
        {
            Id = id;
            Number = number;
            Description = description;
            AnimeId = animeId;
            ValidateEntity();
        }

        public override bool ValidateEntity()
        {
            return this.ValidateEntity(_validator);
        }

        public override bool ValidateProperty(string propertyName)
        {
            return this.ValidateProperty(propertyName, _validator);
        }
    }
}
