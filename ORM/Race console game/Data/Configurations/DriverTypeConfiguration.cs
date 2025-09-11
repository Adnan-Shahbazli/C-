using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;

namespace Race_console_game.Data.Configurations
{
    public class DriverTypeConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder
                .ToTable("Drivers");

            builder
                .HasKey(driver => driver.Id);

            builder
                .Property(driver => driver.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(driver => driver.FirstName)
                .IsRequired(true)
                .HasColumnType("varchar(80)");

            builder
                .Property(driver => driver.LastName)
                .IsRequired(true)
                .HasColumnType("varchar(80)");

            builder
                .Property(driver => driver.ShortName)
                .IsRequired(true)
                .HasColumnType("char(3)");

            builder
                .Property(driver => driver.DriverNumber)
                .IsRequired(true);

            builder
                .HasOne<DriverCharacteristics>()
                .WithMany()
                .HasForeignKey(driver => driver.CharacteristicsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(driver => driver.Score)
                .IsRequired(true)
                .HasDefaultValue(0);

            builder
                .HasOne<GameSave>()
                .WithMany()
                .HasForeignKey(driver => driver.GameSaveId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .Property(driver => driver.GameSaveId)
                .IsRequired(false);
        }
    }
}