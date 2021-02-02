using CV.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.AppUserValidators
{
    public class AppUserForUserNameValidator : AbstractValidator<AppUserForUserNameDto>
    {
        public AppUserForUserNameValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Username).NotEmpty();
        }
    }
}