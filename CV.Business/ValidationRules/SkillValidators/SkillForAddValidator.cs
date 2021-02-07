using CV.DTO.DTOs.SkillDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.SkillValidators
{
    public class SkillForAddValidator : AbstractValidator<SkillForAddDto>
    {
        public SkillForAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}