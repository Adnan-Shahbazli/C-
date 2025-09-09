namespace Race_console_game.Models
{
    public class Team
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int FirstNowDriverId { get; set; }
        public required int SeconNowdDriverId { get; set; }
        public required int FirstDefaultDriverId { get; set; }
        public required int SeconDefaultdDriverId { get; set; }
    }
}