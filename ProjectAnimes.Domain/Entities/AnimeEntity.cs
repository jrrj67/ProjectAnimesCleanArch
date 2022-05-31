﻿using ProjectAnimes.Domain.Validators;

namespace ProjectAnimes.Domain.Entities
{
    public sealed class AnimeEntity : BaseEntity
    {
        private readonly AnimeValidator _validator = new AnimeValidator();

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

        // Nav props

        public ICollection<SeasonEntity>? Seasons { get; set; }

        public AnimeEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
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
