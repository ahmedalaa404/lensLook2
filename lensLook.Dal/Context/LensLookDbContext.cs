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


            modelbuilder.Entity<user>()
                .HasOne(x => x.BasketCustomers)
                .WithOne(x => x.user);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<BasketCustomer> BasketCustomers { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }

    }
}
