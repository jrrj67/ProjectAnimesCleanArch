using FluentValidation;
using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Domain.Validators
{
    public class AnimeValidator : AbstractValidator<AnimeEntity>
    {
        public AnimeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(100);
        }
    }
}
