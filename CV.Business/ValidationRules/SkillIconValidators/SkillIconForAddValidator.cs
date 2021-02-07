using CV.DTO.DTOs.SkillIconDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.SkillIconValidators
{
    public class SkillIconForAddValidator : AbstractValidator<SkillIconForAddDto>
    {
        public SkillIconForAddValidator()
        {
            RuleFor(x => x.SkillId).NotEmpty();
            RuleFor(x => x.Icon).NotEmpty();
        }
    }
}