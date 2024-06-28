using GoogleAuthInAspNetCoreMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleAuthInAspNetCoreMVC.Data
{
    public class GoogleAuthInAspNetCoreMVCContext : IdentityDbContext<AppUser>
    {
        public GoogleAuthInAspNetCoreMVCContext(DbContextOptions<GoogleAuthInAspNetCoreMVCContext> options)
            : base(options)
        {

        }
    }
}
