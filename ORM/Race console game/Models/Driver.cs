namespace Race_console_game.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string ShortName { get; set; }
        public required int DriverNumber { get; set; }
        public required DriverCharacteristics CharacteristicsId { get; set; }
        public required int Score { get; set; } = 0;
        public required int GameSaveId { get; set; } = 0;
    }
}