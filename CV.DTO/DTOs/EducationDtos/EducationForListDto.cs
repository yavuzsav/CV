using System;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.EducationDtos
{
    public class EducationForListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}