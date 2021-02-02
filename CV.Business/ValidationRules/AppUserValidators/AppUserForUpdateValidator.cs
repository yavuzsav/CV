using CV.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.AppUserValidators
{
    public class AppUserForUpdateValidator : AbstractValidator<AppUserForUpdateDto>
    {
        public AppUserForUpdateValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Username).NotEmpty();

        }
    }
}