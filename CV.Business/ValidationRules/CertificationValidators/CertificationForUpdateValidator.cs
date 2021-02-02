using CV.DTO.DTOs.CertificationDtos;
using FluentValidation;

namespace CV.Business.ValidationRules.CertificationValidators
{
    public class CertificationForUpdateValidator : AbstractValidator<CertificationForUpdateDto>
    {
        public CertificationForUpdateValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}