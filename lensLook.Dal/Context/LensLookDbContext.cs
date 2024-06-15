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
            modelbuilder.Entity<OrderItem>().OwnsOne(o => o.Product, Product => Product.WithOwner());




            modelbuilder.Entity<user>().HasMany(x => x.UserBooking).WithOne(x=>x.User).HasForeignKey(x=>x.UserId);
            modelbuilder.Entity<user>().HasMany(x => x.DoctorBooking).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorId);
            modelbuilder.Entity<user>().HasMany(x => x.AdminBooking).WithOne(x => x.Admin).HasForeignKey(x => x.AdminId);




            modelbuilder.Entity<Booking>().HasOne(x => x.Services).WithMany(x=>x.Bookings).HasForeignKey(x => x.ServiceId);

            modelbuilder.Entity<Booking>().Property(x => x.AdminStatus)
                .HasConversion(x => x.ToString(), dataToreturn => (BookingStatus)Enum.Parse(typeof(BookingStatus), dataToreturn));






            modelbuilder.Entity<Booking>().Property(x => x.DoctorStatus)
                .HasConversion(x => x.ToString(), dataToreturn => (BookingStatus)Enum.Parse(typeof(BookingStatus), dataToreturn));



            modelbuilder.Entity<Booking>().Property(x => x.Status)
                .HasConversion(x => x.ToString(), dataToreturn => (BookingStatus)Enum.Parse(typeof(BookingStatus), dataToreturn));










        }


        public DbSet<Product> Products { get; set; }
        public DbSet<BasketCustomer> BasketCustomers { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Booking> BookingS { get; set; }
        public DbSet<Services> Services { get; set; }

    }
}
