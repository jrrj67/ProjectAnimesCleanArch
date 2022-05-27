using FluentValidation;
using ProjectAnimes.Domain.Exceptions;

namespace ProjectAnimes.Domain.Validators
{
    public static class Validator
    {
        public static bool ValidateEntity<T>(this T subject, AbstractValidator<T> validator)
        {
            var errors = new List<string>();

            var validation = validator.Validate(subject);

            if (!validation.IsValid)
            {
                validation.Errors.ForEach(error => errors.Add(error.ErrorMessage));

                throw new DomainException("Entity not valid.", errors);
            }

            return validation.IsValid;
        }
    }
}
