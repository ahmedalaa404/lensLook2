using lensLook.Dal.models;
using lensLook.Dal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lensLook.Dal.Context
{
    public class LensLookDbContext:IdentityDbContext<user>
    {
        public LensLookDbContext(DbContextOptions<LensLookDbContext> Options):base(Options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

        }


        public DbSet<Product> Products { get; set; }
    }
}
