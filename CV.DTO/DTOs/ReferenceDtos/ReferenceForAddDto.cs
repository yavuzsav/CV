using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.ReferenceDtos
{
    public class ReferenceForAddDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconLink { get; set; }
        public string ProjectLink { get; set; }
    }
}