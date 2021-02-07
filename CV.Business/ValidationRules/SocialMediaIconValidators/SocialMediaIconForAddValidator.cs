using CV.DTO.DTOs.SocialMediaIconDto;
using FluentValidation;

namespace CV.Business.ValidationRules.SocialMediaIconValidators
{
    public class SocialMediaIconForAddValidator : AbstractValidator<SocialMediaIconForAddDto>
    {
        public SocialMediaIconForAddValidator()
        {
            RuleFor(x => x.AppUserId).NotEmpty();
            RuleFor(x => x.Link).NotEmpty();
        }
    }
}