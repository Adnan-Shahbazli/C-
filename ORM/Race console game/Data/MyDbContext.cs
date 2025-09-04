using Microsoft.EntityFrameworkCore;
using Race_console_game.Models;

namespace Race_console_game.Data
{
    public class MyDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DbRace;TrustServerCertificate=True;";
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverCharacteristics> DriversCharacteristics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}