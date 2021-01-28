using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.AppUserDtos
{
    public class AppUserForListDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string ShortDescription { get; set; }
    }
}