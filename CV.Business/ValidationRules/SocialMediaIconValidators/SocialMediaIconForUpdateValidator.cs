using CV.DTO.DTOs.SocialMediaIconDto;
using FluentValidation;

namespace CV.Business.ValidationRules.SocialMediaIconValidators
{
    public class SocialMediaIconForUpdateValidator : AbstractValidator<SocialMediaIconForUpdateDto>
    {
        public SocialMediaIconForUpdateValidator()
        {
            RuleFor(x => x.AppUserId).NotEmpty();
            RuleFor(x => x.Link).NotEmpty();
        }
    }
}