using System.ComponentModel.DataAnnotations;

namespace BOOking.MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
