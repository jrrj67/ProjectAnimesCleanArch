using FluentValidation;
using ProjectAnimes.Domain.Entities;

namespace ProjectAnimes.Domain.Validators
{
    public class EpisodeValidator : AbstractValidator<EpisodeEntity>
    {
        public EpisodeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(100);

            RuleFor(x => x.Url)
                .NotEmpty()
                .NotNull()
                .Must(BeValidUrl).WithMessage("Invalid url.");
        }

        public bool BeValidUrl(string url)
        {
            bool result = false;

            try
            {
                Uri uri = new Uri(url);

                result = (uri.Scheme == "http" || uri.Scheme == "https");
            }
            catch (Exception)
            {
                return false;
            }

            return result;
        }
    }
}
