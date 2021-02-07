using CV.DTO.DTOs.CertificationDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.CertificationValidators
{
    public class CertificationForAddValidator : AbstractValidator<CertificationForAddDto>
    {
        public CertificationForAddValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}