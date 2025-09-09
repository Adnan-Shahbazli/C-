using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;

namespace Race_console_game.Data.Configurations
{
    public class SeasonTypeConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder
                .ToTable("Seasons");

            builder
                .HasKey(season => season.Id);

            builder
                .Property(season => season.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(season => season.Year)
                .IsRequired(true);
        }
    }
}