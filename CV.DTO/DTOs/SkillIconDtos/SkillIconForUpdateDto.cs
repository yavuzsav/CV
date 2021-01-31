using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.SkillIconDtos
{
    public class SkillIconForUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int SkillId { get; set; }
    }
}