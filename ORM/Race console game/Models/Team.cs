using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Race_console_game.Models
{
    public class Team
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Driver FirstNowDriverId { get; set; }
        public required Driver SeconNowdDriverId { get; set; }
        public required Driver FirstDefaultDriverId { get; set; }
        public required Driver SeconDefaultdDriverId { get; set; }
    }
}