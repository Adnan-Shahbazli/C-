namespace Race_console_game.Models
{
    public class GameSave
    {
        public required int Id { get; set; }
        public required int WeekNow { get; set; }
        public required int TeamId { get; set; }
        public required int SeasonId{ get; set; }

    }
}