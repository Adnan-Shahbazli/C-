using Race_console_game.Data;
using Race_console_game.Models;

Console.Clear();

var dbContext = new MyDbContext();

var game = new Game();

game.Menu();
