using Microsoft.AspNetCore.Identity;

namespace GoogleAuthInAspNetCoreMVC.Models
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }

        [PersonalData]
        public string? LastName { get; set; }

        [PersonalData]
        public string? ProfilePic { get; set; }

    }
}
