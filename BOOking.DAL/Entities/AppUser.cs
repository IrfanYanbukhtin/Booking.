using Microsoft.AspNetCore.Identity;

namespace BOOking.DAL.Entities
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
