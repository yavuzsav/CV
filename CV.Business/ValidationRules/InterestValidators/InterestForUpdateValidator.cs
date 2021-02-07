using CV.DTO.DTOs.InterestDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.InterestValidators
{
    public class InterestForUpdateValidator : AbstractValidator<InterestForUpdateDto>
    {
        public InterestForUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}