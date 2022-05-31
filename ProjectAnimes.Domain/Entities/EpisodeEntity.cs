using ProjectAnimes.Domain.Validators;

namespace ProjectAnimes.Domain.Entities
{
    public sealed class EpisodeEntity : BaseEntity
    {
        private readonly EpisodeValidator _validator = new EpisodeValidator();

        public Guid SeasonId { get; }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                ValidateProperty(nameof(Name));
            }
        }

        private string _url = string.Empty;
        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                ValidateProperty(nameof(Url));
            }
        }

        // Nav props

        public SeasonEntity? Season { get; set; }

        public EpisodeEntity(Guid id, string name, string url, Guid seasonId)
        {
            Id = id;
            Name = name;
            Url = url;
            SeasonId = seasonId;
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
