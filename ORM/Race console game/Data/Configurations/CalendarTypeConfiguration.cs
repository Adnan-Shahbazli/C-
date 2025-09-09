using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Race_console_game.Models;


namespace Race_console_game.Data.Configurations
{
    public class CalendarTypeConfiguration : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder
                .ToTable("Calendars");

            builder
                .HasKey(calendar => calendar.Id);

            builder
                .Property(calendar => calendar.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne<Season>()
                .WithMany()
                .HasForeignKey(calendar => calendar.SeasonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(calendar => calendar.WeekNumber)
                .IsRequired(true);

            builder
                .Property(calendar => calendar.IsReac)
                .IsRequired(true);

            builder
                .Property(calendar => calendar.RaceName)
                .IsRequired(false);
        }
    }
}