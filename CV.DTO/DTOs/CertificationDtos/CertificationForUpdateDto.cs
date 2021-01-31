using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.CertificationDtos
{
    public class CertificationForUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}