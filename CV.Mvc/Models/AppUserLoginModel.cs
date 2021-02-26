using System.ComponentModel.DataAnnotations;

namespace CV.Mvc.Models
{
    public class AppUserLoginModel
    {
        [Required] public string UserName { get; set; }
        [Required] public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}