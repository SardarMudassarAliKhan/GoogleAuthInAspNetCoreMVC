using GoogleAuthInAspNetCoreMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoogleAuthInAspNetCoreMVC.Data
{
    public class GoogleAuthInAspNetCoreMVCContext : IdentityDbContext<IdentityUser>
    {
        public GoogleAuthInAspNetCoreMVCContext(DbContextOptions<GoogleAuthInAspNetCoreMVCContext> options)
            : base(options)
        {

        }

        public DbSet<IdentityUser> Users { get; set; }
    }
}
