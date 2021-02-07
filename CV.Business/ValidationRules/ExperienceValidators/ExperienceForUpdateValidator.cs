using CV.DTO.DTOs.ExperienceDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.ExperienceValidators
{
    public class ExperienceForUpdateValidator : AbstractValidator<ExperienceForUpdateDto>
    {
        public ExperienceForUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty();
        }
    }
}