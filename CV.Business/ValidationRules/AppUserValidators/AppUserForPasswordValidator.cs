using CV.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.AppUserValidators
{
    public class AppUserForPasswordValidator : AbstractValidator<AppUserForPasswordDto>
    {
        public AppUserForPasswordValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}