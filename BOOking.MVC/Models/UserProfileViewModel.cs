using Microsoft.Build.Framework;

namespace BOOking.MVC.Models
{
    public class UserProfileViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Fullname { get; set; }
    }
}
