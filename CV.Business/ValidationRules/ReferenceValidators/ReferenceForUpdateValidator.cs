using CV.DTO.DTOs.ReferenceDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.ReferenceValidators
{
    public class ReferenceForUpdateValidator : AbstractValidator<ReferenceForUpdateDto>
    {
        public ReferenceForUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
        }
    }
}