using FluentValidation;
using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Domain.Validators
{
    public class SeasonValidator : AbstractValidator<SeasonEntity>
    {
        public SeasonValidator()
        {
            RuleFor(x => x.Number)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .LessThanOrEqualTo(100);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(100);
        }
    }
}
