using Microsoft.EntityFrameworkCore;
using task.Models;

namespace task.Data
{
    public class MyDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyEfDb;TrustServerCertificate=True;";
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .HasKey(Car => Car.Id);

            modelBuilder.Entity<Car>()
                .Property(Car => Car.Name)
                .HasMaxLength(80);
        }
    }
}