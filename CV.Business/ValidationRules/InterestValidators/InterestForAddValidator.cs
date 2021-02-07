using CV.DTO.DTOs.InterestDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.InterestValidators
{
    public class InterestForAddValidator : AbstractValidator<InterestForAddDto>
    {
        public InterestForAddValidator()
        {
        }
    }
}