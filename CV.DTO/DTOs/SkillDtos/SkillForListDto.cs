using System.Collections.Generic;
using CV.DTO.DTOs.SkillIconDtos;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.SkillDtos
{
    public class SkillForListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<SkillIconForListDto> SkillIcons { get; set; }
    }
}