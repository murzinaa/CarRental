using CarRentalService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalService.DataAccess
{
    public class CarRentalContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Fine> Fines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRental;");
        }

    }
}
