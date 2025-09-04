using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Race_console_game.Models
{
    public class GameSave
    {
        public required int Id { get; set; }
        public required int WeekNow { get; set; }
        public required Team TeamId { get; set; }
        public required ReceWeek { get; set; }

    }
}