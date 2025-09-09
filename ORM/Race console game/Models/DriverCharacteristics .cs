namespace Race_console_game.Models
{
    public class DriverCharacteristics
    {
        public required int Id { get; set; }
        public required int Rating { get; set; } = 10;
        public required int QualifyingRating { get; set; } = 10;
        public required int SpeedRating { get; set; } = 10;
        public required int DefenseRating { get; set; } = 10;
        public required int OvertakingRating { get; set; } = 10;
        public required int ConcentrationRating { get; set; } = 10;
        public required int Level { get; set; } = 1;
        public required int Ex { get; set; } = 0;
        public required int Points { get; set; } = 0;
    }
}