using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.AppUserDtos
{
    public class AppUserForPasswordDto : IDto
    {
        public int Id { get; set; }
        public int Password { get; set; }
    }
}