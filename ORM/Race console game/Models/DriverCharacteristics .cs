using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Race_console_game.Models
{
    public class DriverCharacteristics
    {
        public int Id { get; set; }
        public int Rating { get; set; } = 10;
        public int QualifyingRating { get; set; } = 10;
        public int SpeedRating { get; set; } = 10;
        public int DefenseRating { get; set; } = 10;
        public int OvertakingRating { get; set; } = 10;
        public int ConcentrationRating { get; set; } = 10;
        public int Level { get; set; } = 1;
        public int ex { get; set; } = 0;
    }
}