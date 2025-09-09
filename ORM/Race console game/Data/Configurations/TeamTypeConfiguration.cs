using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;

namespace Race_console_game.Data.Configurations
{
    public class TeamTypeConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .ToTable("Teams");

            builder
                .HasKey(team => team.Id);

            builder
                .Property(team => team.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne<Driver>()
                .WithMany()
                .HasForeignKey(gs => gs.FirstNowDriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<Driver>()
                .WithMany()
                .HasForeignKey(gs => gs.SeconNowdDriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<Driver>()
                .WithMany()
                .HasForeignKey(gs => gs.FirstDefaultDriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne<Driver>()
                .WithMany()
                .HasForeignKey(gs => gs.SeconDefaultdDriverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}