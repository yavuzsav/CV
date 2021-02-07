using CV.DTO.DTOs.EducationDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.EducationValidators
{
    public class EducationForUpdateValidator : AbstractValidator<EducationForUpdateDto>
    {
        public EducationForUpdateValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty();
        }
    }
}