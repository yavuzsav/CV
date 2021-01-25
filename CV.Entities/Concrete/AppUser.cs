using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("AppUsers")]
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string ShortDescription { get; set; }
    }
}