using Microsoft.AspNetCore.Identity;

namespace GoogleAuthInAspNetCoreMVC.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePic { get; set; }
    }
}
