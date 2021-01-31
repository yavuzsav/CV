using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.InterestDtos
{
    public class InterestForUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}