using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;

namespace Race_console_game.Data.Configurations
{
    public class DriverCharacteristicsTypeConfiguration : IEntityTypeConfiguration<DriverCharacteristics>
    {
        public void Configure(EntityTypeBuilder<DriverCharacteristics> builder)
        {
            builder
                .ToTable("DriverCharacteristics");

            builder
                .HasKey(dc => dc.Id);

            builder
                .Property(dc => dc.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(dc => dc.Rating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.QualifyingRating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.SpeedRating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.DefenseRating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.OvertakingRating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.ConcentrationRating)
                .IsRequired(true)
                .HasDefaultValue(10);

            builder
                .Property(dc => dc.Level)
                .IsRequired(true)
                .HasDefaultValue(1);

            builder
                .Property(dc => dc.Ex)
                .IsRequired(true)
                .HasDefaultValue(1); 
                
            builder
                .Property(dc => dc.Points)
                .IsRequired(true)
                .HasDefaultValue(1); 
        }
    }
}