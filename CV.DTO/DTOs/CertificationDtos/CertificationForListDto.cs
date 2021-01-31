using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.CertificationDtos
{
    public class CertificationForListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}