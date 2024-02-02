using Microsoft.EntityFrameworkCore;
using ETourProject1.Models;



namespace ETourProject1.Repository
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }
       public DbSet<Passanger_Master> Passanger { get; set; }

        public DbSet<Package_Master> PackageMaster { get; set; }

      
        public DbSet<Itinerary_Master> ItineraryMaster { get; set; }

        public DbSet<Customer_Master> CustomerMaster { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


       public DbSet<Booking_Header> BookingHeaders { get; set; }

        public DbSet<Cost_Master> CostMaster { get; set; }


        public DbSet<Category_Master> CategoryMaster { get; set; }


        public DbSet<Date_Master> DateMaster { get; set; }

         


    }
}
