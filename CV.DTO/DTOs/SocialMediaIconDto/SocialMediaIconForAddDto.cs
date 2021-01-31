using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.SocialMediaIconDto
{
    public class SocialMediaIconForAddDto : IDto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}