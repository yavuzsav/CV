using CV.DTO.DTOs.EducationDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.EducationValidators
{
    public class EducationForAddValidator : AbstractValidator<EducationForAddDto>
    {
        public EducationForAddValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty();
        }
    }
}