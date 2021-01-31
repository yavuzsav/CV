using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.SkillDtos
{
    public class SkillForListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}