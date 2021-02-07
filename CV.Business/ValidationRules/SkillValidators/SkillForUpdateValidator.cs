using CV.DTO.DTOs.SkillDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.SkillValidators
{
    public class SkillForUpdateValidator : AbstractValidator<SkillForUpdateDto>
    {
        public SkillForUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}