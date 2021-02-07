using CV.DTO.DTOs.SkillIconDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.SkillIconValidators
{
    public class SkillIconForUpdateValidator : AbstractValidator<SkillIconForUpdateDto>
    {
        public SkillIconForUpdateValidator()
        {
            RuleFor(x => x.SkillId).NotEmpty();
            RuleFor(x => x.Icon).NotEmpty();
        }
    }
}