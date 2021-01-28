using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.AppUserDtos
{
    public class AppUserForUserNameDto : IDto
    {
        public int Id { get; set; }
        public int Username { get; set; }
    }
}