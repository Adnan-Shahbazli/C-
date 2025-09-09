using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;

namespace Race_console_game.Data.Configurations
{
    public class GameSaveTypeConfiguration : IEntityTypeConfiguration<GameSave>
    {
        public void Configure(EntityTypeBuilder<GameSave> builder)
        {
            builder
                .ToTable("GameSaves");

            builder
                .HasKey(gs => gs.Id);

            builder
                .Property(gs => gs.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(gs => gs.WeekNow)
                .IsRequired(true);


            builder
                .HasOne<Team>()
                .WithMany()
                .HasForeignKey(gs => gs.TeamId)
                .OnDelete(DeleteBehavior.Restrict);
                
            
            builder
                .HasOne<Season>()
                .WithMany()
                .HasForeignKey(gs => gs.SeasonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}