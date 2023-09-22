using Microsoft.EntityFrameworkCore;

namespace EFCoreTablePerTypeInheritance.Models
{
    public class MyApplicationContext : DbContext
    {
        public MyApplicationContext(DbContextOptions<MyApplicationContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Using TPT mapping strategy with EF Core
            modelBuilder.Entity<Vehicle>().UseTptMappingStrategy();

            base.OnModelCreating(modelBuilder);
        }
    }
}
