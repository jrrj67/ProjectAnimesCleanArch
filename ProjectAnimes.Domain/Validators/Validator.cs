using FluentValidation;
using FluentValidation.Internal;
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

        public static bool ValidateProperty<T>(this T subject, string fieldName, AbstractValidator<T> validator)
        {
            var errors = new List<string>();

            var properties = new[] { fieldName };

            var context = new ValidationContext<T>(subject, new PropertyChain(), new MemberNameValidatorSelector(properties));

            var validation = validator.Validate(context);

            if (!validation.IsValid)
            {
                validation.Errors.ForEach(error => errors.Add(error.ErrorMessage));

                throw new DomainException("Property not valid.", errors);
            }

            return validation.IsValid;
        }
    }
}
