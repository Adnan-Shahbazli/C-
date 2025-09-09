namespace Race_console_game.Models
{
    public class Calendar
    {
        public required int Id { get; set; }
        public required int SeasonId { get; set; }
        public required int WeekNumber { get; set; }
        public required bool IsReac { get; set; }
        public string? RaceName { get; set; }
    }
}