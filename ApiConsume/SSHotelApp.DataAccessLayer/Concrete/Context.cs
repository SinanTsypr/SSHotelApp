using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSHotelApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<Staff> Staffs => Set<Staff>();
        public DbSet<Subscribe> Subscribes => Set<Subscribe>();
        public DbSet<Testimonial> Testimonials => Set<Testimonial>();
        public DbSet<AboutUs> AboutUss => Set<AboutUs>();
        public DbSet<Booking> Bookings => Set<Booking>();
        public DbSet<Guest> Guests => Set<Guest>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<SendMessage> SendMessages => Set<SendMessage>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=SSHotelAppDb; Trusted_Connection=True;");
        }
    }
}
