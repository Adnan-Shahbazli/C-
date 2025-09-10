using Dapper;
using Microsoft.Data.SqlClient;

namespace Race_console_game.Models
{
    public class Game
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DbRace;TrustServerCertificate=True;";

        public void Menu()
        {
            var logo = new List<string>
            {
                @"__        __   _                            ",
                @"\ \      / /__| | ___ ___  _ __ ___   ___  ",
                @" \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ ",
                @"  \ V  V /  __/ | (_| (_) | | | | | |  __/ ",
                @"   \_/\_/ \___|_|\___\___/|_| |_| |_|\___| ",
                @"                                          ",
                @"    -           __                         ",
                @"  --          ~( @\   \                    ",
                @" ---   _________]_[__/_>________           ",
                @"      /  ____ \ <>     |  ____  \          ",
                @"     =\_/ __ \_\_______|_/ __ \__D         ",
                @" ________(__)_____________(__)____         "
            };

            foreach (var line in logo)
            {
                foreach (var ch in line)
                {
                    Console.Write(ch);
                    Thread.Sleep(1);
                }
                Console.WriteLine();
            }

            bool hasSaves = false;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var count = connection.ExecuteScalar<int>("select count(*) from GameSaves");
                hasSaves = count > 0;
            }

            string[] menuItems = { "Create", "Load", "Exit" };
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.SetCursorPosition(0, logo.Count);
                Console.WriteLine("\t");

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == 1 && !hasSaves)
                        Console.WriteLine($"  {menuItems[i]} [X]");
                    else if (i == selectedIndex)
                        Console.WriteLine($"> {menuItems[i]}");
                    else
                        Console.WriteLine($"  {menuItems[i]}");
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0) selectedIndex = menuItems.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= menuItems.Length) selectedIndex = 0;
                }

                if (selectedIndex == 1 && !hasSaves)
                    selectedIndex = 0;

                Console.SetCursorPosition(0, logo.Count);
            } while (key != ConsoleKey.Enter);

            Console.Clear();
            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("Create выбрано! (тут запускаем создание)");
                    break;
                case 1:
                    Console.WriteLine("Load выбрано! (тут запускаем загрузку)");
                    break;
                case 2:
                    Console.WriteLine("Выход из программы...");
                    break;
            }
        }
    }
}
