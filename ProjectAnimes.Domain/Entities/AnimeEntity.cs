using ProjectAnimes.Domain.Validators;

namespace ProjectAnimes.Domain.Entities
{
    public sealed class AnimeEntity : BaseEntity
    {
        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Validate();
            }
        }

        public AnimeEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
            Validate();
        }

        public override bool Validate()
        {
            return this.ValidateEntity(new AnimeValidator());
        }
    }
}
