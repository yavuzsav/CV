using CV.DTO.DTOs.ReferenceDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.ReferenceValidators
{
    public class ReferenceForAddValidator : AbstractValidator<ReferenceForAddDto>
    {
        public ReferenceForAddValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
        }
    }
}