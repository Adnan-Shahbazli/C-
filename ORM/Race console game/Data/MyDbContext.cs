using Microsoft.EntityFrameworkCore;
using Race_console_game.Models;

namespace Race_console_game.Data
{
    public class MyDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DbRace;TrustServerCertificate=True;";
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverCharacteristics> DriversCharacteristics { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<GameSave> GameSaves { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}