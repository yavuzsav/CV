using CV.DTO.DTOs.ExperienceDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.ExperienceValidators
{
    public class ExperienceForAddValidator : AbstractValidator<ExperienceForAddDto>
    {
        public ExperienceForAddValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty();
        }
    }
}