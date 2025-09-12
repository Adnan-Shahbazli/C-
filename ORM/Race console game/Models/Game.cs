using System.Drawing;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Race_console_game.Models
{
    public class Game
    {
        private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DbRace;TrustServerCertificate=True;";
        private static readonly List<string> logo = new List<string>
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

        public void Menu()
        {
            foreach (var line in logo)
            {
                foreach (var ch in line)
                {
                    Console.Write(ch);
                    Thread.Sleep(1);
                }
                Console.WriteLine();
            }
            int menuStartLine = logo.Count;
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
                    do
                    {
                        selectedIndex--;
                        if (selectedIndex < 0)
                            selectedIndex = menuItems.Length - 1;
                    } while (selectedIndex == 1 && !hasSaves);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    do
                    {
                        selectedIndex++;
                        if (selectedIndex >= menuItems.Length)
                            selectedIndex = 0;
                    } while (selectedIndex == 1 && !hasSaves);
                }

                Console.SetCursorPosition(0, logo.Count);
            } while (key != ConsoleKey.Enter);

            Console.Clear();
            switch (selectedIndex)
            {
                case 0:
                    Create();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
            }

        }
        public void Create()
        {
            Console.Clear();
            foreach (var item in logo)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("\t");

            Console.Write("Please let's download the necessary data first. Press ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\"Enter\"");
            Console.ResetColor();
            Console.WriteLine(" to continue.");

            while (true)
            {
                var keyEnter = Console.ReadKey(true);
                if (keyEnter.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            connection.Execute(@"
                DECLARE @verstappen_char_id INT, @perez_char_id INT;
                DECLARE @leclerc_char_id INT, @sainz_char_id INT;
                DECLARE @norris_char_id INT, @piastri_char_id INT;
                DECLARE @hamilton_char_id INT, @russell_char_id INT;
                DECLARE @alonso_char_id INT, @stroll_char_id INT;
                DECLARE @ocon_char_id INT, @gasly_char_id INT;
                DECLARE @albon_char_id INT, @sargeant_char_id INT;
                DECLARE @tsunoda_char_id INT, @ricciardo_char_id INT;
                DECLARE @bottas_char_id INT, @zhou_char_id INT;
                DECLARE @hulkenberg_char_id INT, @magnussen_char_id INT;

                DECLARE @verstappen_id INT, @perez_id INT;
                DECLARE @leclerc_id INT, @sainz_id INT;
                DECLARE @norris_id INT, @piastri_id INT;
                DECLARE @hamilton_id INT, @russell_id INT;
                DECLARE @alonso_id INT, @stroll_id INT;
                DECLARE @ocon_id INT, @gasly_id INT;
                DECLARE @albon_id INT, @sargeant_id INT;
                DECLARE @tsunoda_id INT, @ricciardo_id INT;
                DECLARE @bottas_id INT, @zhou_id INT;
                DECLARE @hulkenberg_id INT, @magnussen_id INT;

                DECLARE @red_bull_team_id INT;
                DECLARE @ferrari_team_id INT;
                DECLARE @mclaren_team_id INT;
                DECLARE @mercedes_team_id INT;
                DECLARE @aston_martin_team_id INT;
                DECLARE @alpine_team_id INT;
                DECLARE @williams_team_id INT;
                DECLARE @visa_cash_app_rb_team_id INT;
                DECLARE @haas_team_id INT;
                DECLARE @sauber_team_id INT;

                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (95, 98, 97, 94, 96, 95, 1, 0, 0); SET @verstappen_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (92, 91, 93, 90, 92, 91, 1, 0, 0); SET @perez_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (94, 95, 94, 92, 93, 96, 1, 0, 0); SET @leclerc_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (89, 88, 90, 89, 91, 89, 1, 0, 0); SET @sainz_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (90, 92, 91, 88, 90, 93, 1, 0, 0); SET @norris_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (88, 89, 87, 88, 89, 87, 1, 0, 0); SET @piastri_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (93, 94, 92, 91, 92, 93, 1, 0, 0); SET @hamilton_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (87, 88, 86, 87, 89, 88, 1, 0, 0); SET @russell_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (85, 86, 85, 84, 87, 86, 1, 0, 0); SET @alonso_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (84, 85, 83, 85, 86, 85, 1, 0, 0); SET @stroll_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (86, 87, 85, 86, 85, 87, 1, 0, 0); SET @ocon_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (83, 84, 82, 83, 84, 83, 1, 0, 0); SET @gasly_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (82, 83, 81, 82, 83, 82, 1, 0, 0); SET @albon_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (79, 80, 78, 79, 80, 79, 1, 0, 0); SET @sargeant_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (81, 82, 80, 81, 82, 81, 1, 0, 0); SET @tsunoda_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (78, 79, 77, 78, 79, 78, 1, 0, 0); SET @ricciardo_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (85, 86, 85, 84, 87, 86, 1, 0, 0); SET @hulkenberg_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (87, 88, 86, 87, 89, 88, 1, 0, 0); SET @magnussen_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (80, 81, 79, 80, 81, 80, 1, 0, 0); SET @bottas_char_id = SCOPE_IDENTITY();
                INSERT INTO [DriverCharacteristics] ([Rating], [QualifyingRating], [SpeedRating], [DefenseRating], [OvertakingRating], [ConcentrationRating], [Level], [Ex], [Points]) VALUES (77, 78, 76, 77, 78, 77, 1, 0, 0); SET @zhou_char_id = SCOPE_IDENTITY();

                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Max', 'Verstappen', 'VER', 1, @verstappen_char_id, 0, NULL); SET @verstappen_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Sergio', 'Perez', 'PER', 11, @perez_char_id, 0, NULL); SET @perez_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Charles', 'Leclerc', 'LEC', 16, @leclerc_char_id, 0, NULL); SET @leclerc_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Carlos', 'Sainz', 'SAI', 55, @sainz_char_id, 0, NULL); SET @sainz_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Lando', 'Norris', 'NOR', 4, @norris_char_id, 0, NULL); SET @norris_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Oscar', 'Piastri', 'PIA', 81, @piastri_char_id, 0, NULL); SET @piastri_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Lewis', 'Hamilton', 'HAM', 44, @hamilton_char_id, 0, NULL); SET @hamilton_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('George', 'Russell', 'RUS', 63, @russell_char_id, 0, NULL); SET @russell_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Fernando', 'Alonso', 'ALO', 14, @alonso_char_id, 0, NULL); SET @alonso_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Lance', 'Stroll', 'STR', 18, @stroll_char_id, 0, NULL); SET @stroll_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Esteban', 'Ocon', 'OCO', 31, @ocon_char_id, 0, NULL); SET @ocon_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Pierre', 'Gasly', 'GAS', 10, @gasly_char_id, 0, NULL); SET @gasly_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Alexander', 'Albon', 'ALB', 23, @albon_char_id, 0, NULL); SET @albon_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Logan', 'Sargeant', 'SAR', 2, @sargeant_char_id, 0, NULL); SET @sargeant_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Yuki', 'Tsunoda', 'TSU', 22, @tsunoda_char_id, 0, NULL); SET @tsunoda_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Daniel', 'Ricciardo', 'RIC', 3, @ricciardo_char_id, 0, NULL); SET @ricciardo_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Nico', 'Hulkenberg', 'HUL', 27, @hulkenberg_char_id, 0, NULL); SET @hulkenberg_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Kevin', 'Magnussen', 'MAG', 20, @magnussen_char_id, 0, NULL); SET @magnussen_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Valtteri', 'Bottas', 'BOT', 77, @bottas_char_id, 0, NULL); SET @bottas_id = SCOPE_IDENTITY();
                INSERT INTO [Drivers] ([FirstName], [LastName], [ShortName], [DriverNumber], [CharacteristicsId], [Score], [GameSaveId]) VALUES ('Guanyu', 'Zhou', 'ZHO', 24, @zhou_char_id, 0, NULL); SET @zhou_id = SCOPE_IDENTITY();

                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Red Bull Racing', @verstappen_id, @perez_id, @verstappen_id, @perez_id); SET @red_bull_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Scuderia Ferrari', @leclerc_id, @sainz_id, @leclerc_id, @sainz_id); SET @ferrari_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('McLaren', @norris_id, @piastri_id, @norris_id, @piastri_id); SET @mclaren_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Mercedes', @hamilton_id, @russell_id, @hamilton_id, @russell_id); SET @mercedes_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Aston Martin', @alonso_id, @stroll_id, @alonso_id, @stroll_id); SET @aston_martin_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Alpine', @ocon_id, @gasly_id, @ocon_id, @gasly_id); SET @alpine_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Williams', @albon_id, @sargeant_id, @albon_id, @sargeant_id); SET @williams_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Visa Cash App RB', @tsunoda_id, @ricciardo_id, @tsunoda_id, @ricciardo_id); SET @visa_cash_app_rb_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Haas', @magnussen_id, @hulkenberg_id, @magnussen_id, @hulkenberg_id); SET @haas_team_id = SCOPE_IDENTITY();
                INSERT INTO [Teams] ([Name], [FirstNowDriverId], [SeconNowdDriverId], [FirstDefaultDriverId], [SeconDefaultdDriverId]) VALUES ('Sauber', @bottas_id, @zhou_id, @bottas_id, @zhou_id); SET @sauber_team_id = SCOPE_IDENTITY();

                INSERT INTO [Seasons] ([Year])
                VALUES (2025);

                DECLARE @seasonId INT = SCOPE_IDENTITY();

                INSERT INTO [Calendars] ([SeasonId], [WeekNumber], [IsReac], [RaceName])
                VALUES
                (@seasonId, 9, 1, 'Australian Grand Prix'),
                (@seasonId, 10, 1, 'Chinese Grand Prix'),
                (@seasonId, 14, 1, 'Japanese Grand Prix'),
                (@seasonId, 16, 1, 'Bahrain Grand Prix'),
                (@seasonId, 17, 1, 'Saudi Arabian Grand Prix'),
                (@seasonId, 19, 1, 'Miami Grand Prix'),
                (@seasonId, 21, 1, 'Monaco Grand Prix'),
                (@seasonId, 23, 1, 'Canadian Grand Prix'),
                (@seasonId, 25, 1, 'Spanish Grand Prix'),
                (@seasonId, 26, 1, 'Austrian Grand Prix'),
                (@seasonId, 28, 1, 'British Grand Prix'),
                (@seasonId, 30, 1, 'Belgian Grand Prix'),
                (@seasonId, 31, 1, 'Dutch Grand Prix'),
                (@seasonId, 33, 1, 'Hungarian Grand Prix'),
                (@seasonId, 35, 1, 'Italian Grand Prix'),
                (@seasonId, 38, 1, 'Azerbaijan Grand Prix'),
                (@seasonId, 39, 1, 'Singapore Grand Prix'),
                (@seasonId, 41, 1, 'United States Grand Prix'),
                (@seasonId, 43, 1, 'Mexico City Grand Prix'),
                (@seasonId, 45, 1, 'São Paulo Grand Prix'),
                (@seasonId, 47, 1, 'Las Vegas Grand Prix'),
                (@seasonId, 49, 1, 'Qatar Grand Prix'),
                (@seasonId, 50, 1, 'Abu Dhabi Grand Prix');
                
                INSERT INTO [GameSaves] ([WeekNow], [TeamId], [SeasonId])
                VALUES (9, @ferrari_team_id, @seasonId);
            ");

            Console.Clear();
            foreach (var item in logo)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("\t");

            System.Console.WriteLine("Thanks for waiting.<3");
            Thread.Sleep(2000);
            Console.Clear();
            foreach (var item in logo)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("\t");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            string shortName;
            while (true)
            {
                Console.Write("Enter your driver short name (3 letters): ");
                shortName = Console.ReadLine().ToUpper();
                if (shortName.Length == 3)
                {
                    break;
                }
                Console.WriteLine("The abbreviation must consist of exactly 3 letters. Please try again.");
            }

            int driverNumber;
            while (true)
            {
                Console.Write("Enter your driver number: ");
                try
                {
                    driverNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter the correct number (digits only).");
                }
            }

            var teams = connection.Query<dynamic>(@"
                SELECT 
                    T.Id,
                    T.Name,
                    (DC1.Rating + DC2.Rating) / 2 AS AverageRating
                FROM Teams AS T
                JOIN Drivers AS D1 ON T.FirstDefaultDriverId = D1.Id
                JOIN DriverCharacteristics AS DC1 ON D1.CharacteristicsId = DC1.Id
                JOIN Drivers AS D2 ON T.SeconDefaultdDriverId = D2.Id
                JOIN DriverCharacteristics AS DC2 ON D2.CharacteristicsId = DC2.Id
                ORDER BY AverageRating ASC
                OFFSET 0 ROWS
                FETCH NEXT 3 ROWS ONLY;
            ").ToList();

            Console.Clear();
            foreach (var item in logo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\t");
            Console.WriteLine("Select the command:");

            int selectedTeamIndex = 0;
            ConsoleKey key;
            do
            {
                Console.SetCursorPosition(0, logo.Count + 2);
                for (int i = 0; i < teams.Count; i++)
                {
                    if (i == selectedTeamIndex)
                    {
                        Console.WriteLine($"> {teams[i].Name}");
                    }
                    else
                    {
                        Console.WriteLine($"  {teams[i].Name}");
                    }
                }

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    selectedTeamIndex = (selectedTeamIndex - 1 + teams.Count) % teams.Count;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedTeamIndex = (selectedTeamIndex + 1) % teams.Count;
                }
            } while (key != ConsoleKey.Enter);

            var selectedTeam = teams[selectedTeamIndex];
            Console.WriteLine($"A team has been selected.: {selectedTeam.Name}");
            
            int seasonId = connection.ExecuteScalar<int>(@"
                SELECT Id FROM Seasons ORDER BY Year DESC;
            ");
            int newGameSaveId = connection.ExecuteScalar<int>($@"
                INSERT INTO GameSaves (WeekNow, TeamId, SeasonId)
                VALUES (1, {selectedTeam.Id}, {seasonId});
                SELECT SCOPE_IDENTITY();
            ");

            int userCharId = connection.ExecuteScalar<int>(@"
                INSERT INTO DriverCharacteristics (Rating, QualifyingRating, SpeedRating, DefenseRating, OvertakingRating, ConcentrationRating, Level, Ex, Points) 
                VALUES (10, 10, 10, 10, 10, 10, 1, 0, 0); 
                SELECT SCOPE_IDENTITY();
            ");
            
            connection.Execute($@"
                INSERT INTO Drivers (FirstName, LastName, ShortName, DriverNumber, CharacteristicsId, Score, GameSaveId) 
                VALUES ('{firstName}', '{lastName}', '{shortName}', {driverNumber}, {userCharId}, 0, {newGameSaveId});
            ");
            
            int userId = connection.ExecuteScalar<int>($@"
                SELECT TOP 1 Id FROM Drivers WHERE GameSaveId = {newGameSaveId};
            ");

            connection.Execute($@"
                UPDATE Teams 
                SET FirstNowDriverId = {userId} 
                WHERE Id = {selectedTeam.Id};
            ");
            

            Console.Clear();
            string message = "Thanks for creating the player. Have a nice game.<3";
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Thread.Sleep(2000);
            Console.Clear();

            Games(newGameSaveId);
        }
        public void Load()
        {
            Console.Clear();
            foreach (var item in logo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\t");

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var savedGames = connection.Query<dynamic>(@"
                SELECT 
                    gs.Id,
                    gs.WeekNow,
                    t.Name as TeamName,
                    d.FirstName + ' ' + d.LastName as DriverName
                FROM GameSaves gs
                JOIN Teams t ON gs.TeamId = t.Id
                JOIN Drivers d ON t.FirstNowDriverId = d.Id
                ORDER BY gs.Id DESC;
            ").ToList();

            if (!savedGames.Any())
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("There are no available saves.");
                Console.ResetColor();
                Thread.Sleep(2000);
                Menu();
                return;
            }

            Console.WriteLine("Select Save:");
            Console.WriteLine();

            int selectedIndex = 0;
            ConsoleKey key;
            do
            {
                Console.SetCursorPosition(0, logo.Count + 2);
                for (int i = 0; i < savedGames.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.WriteLine($"> {savedGames[i].DriverName} ({savedGames[i].TeamName}) - Неделя {savedGames[i].WeekNow}");
                    }
                    else
                    {
                        Console.WriteLine($"  {savedGames[i].DriverName} ({savedGames[i].TeamName}) - Неделя {savedGames[i].WeekNow}");
                    }
                }

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex - 1 + savedGames.Count) % savedGames.Count;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % savedGames.Count;
                }
            } while (key != ConsoleKey.Enter);

            var selectedSaveId = savedGames[selectedIndex].Id;
            Console.Clear();
            Games(selectedSaveId);
        }
        public void Games(int saveId)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            Console.Clear();
            var gameSave = connection.QueryFirstOrDefault<GameSave>(
                    sql: "SELECT * FROM GameSaves WHERE Id = @SaveId;",
                    param: new { SaveId = saveId });

                if (gameSave == null)
                {
                    Console.WriteLine("Error: The selected game save could not be found.");
                    System.Threading.Thread.Sleep(2000);
                    Menu();
                    return;
                }

                var driver = connection.QueryFirstOrDefault<Driver>(
                    sql: "SELECT * FROM Drivers d WHERE d.GameSaveId = @GameSaveId;",
                    param: new { GameSaveId = gameSave.Id });

                if (driver == null)
                {
                    Console.WriteLine("Error: Driver data for this save could not be found.");
                    System.Threading.Thread.Sleep(2000);
                    Menu();
                    return;
                }

                var driverCharacteristic = connection.QueryFirstOrDefault<DriverCharacteristics>(
                    sql: "SELECT * FROM DriverCharacteristics WHERE Id = @CharacteristicsId;",
                    param: new { CharacteristicsId = driver.CharacteristicsId });

                if (driverCharacteristic == null)
                {
                    Console.WriteLine("Error: Driver characteristics for this driver could not be found.");
                    System.Threading.Thread.Sleep(2000);
                    Menu();
                    return;
                }

                bool isRaceWeek = connection.ExecuteScalar<bool>(
                    sql: "SELECT IsReac FROM Calendars WHERE SeasonId = @SeasonId AND WeekNumber = @WeekNow;",
                    param: new { SeasonId = gameSave.SeasonId, WeekNow = gameSave.WeekNow });

            

            string[] gameMenuItems = new string[3];
                gameMenuItems[0] = isRaceWeek ? "Play race" : "Skip week";
                gameMenuItems[1] = "Upgrade player";
                gameMenuItems[2] = "Exit";

                int selectedIndex = 0;
                ConsoleKey key;
                do
                {
                    Console.Clear();
                    System.Console.WriteLine($"{driver.FirstName} {driver.LastName}\t\t{driver.DriverNumber}");
                    System.Console.WriteLine($"Rating\t\t\t{driverCharacteristic.Rating}");
                    System.Console.WriteLine($"Weak\t\t\tPoint");
                    System.Console.WriteLine($"{gameSave.WeekNow}\t\t\t{driverCharacteristic.Points}");
                    Console.SetCursorPosition(0, Console.CursorTop);
                for (int i = 0; i < gameMenuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {gameMenuItems[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {gameMenuItems[i]}");
                    }
                    }

                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        selectedIndex = (selectedIndex - 1 + gameMenuItems.Length) % gameMenuItems.Length;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        selectedIndex = (selectedIndex + 1) % gameMenuItems.Length;
                    }
                    Console.Clear();
                    for (int i = 0; i < gameMenuItems.Length; i++)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop + i);
                        Console.Write(new string(' ', Console.WindowWidth));
                    }
                    
                } while (key != ConsoleKey.Enter);
                
                switch (selectedIndex)
                {
                    case 0:
                        if (isRaceWeek)
                        {
                            PlayRace(saveId);
                        }
                        else
                        {
                            Console.WriteLine("Skipping week...");
                            int newEx = driverCharacteristic.Ex + 10;
                            int newLevel = driverCharacteristic.Level;
                            int newPoints = driverCharacteristic.Points;

                            if (newEx >= newLevel * 10)
                            {
                                newLevel++;
                                newPoints++;
                                newEx = 0;
                                Console.WriteLine("Level up! You gained a skill point!");
                            }
                            connection.Execute(
                                sql: "UPDATE DriverCharacteristics SET Ex = @Ex, Level = @Level, Points = @Points WHERE Id = @Id;",
                                param: new { Id = driverCharacteristic.Id, Ex = newEx, Level = newLevel, Points = newPoints });

                            connection.Execute(
                                sql: "UPDATE GameSaves SET WeekNow = WeekNow + 1 WHERE Id = @Id;",
                                param: new { Id = gameSave.Id });

                            Thread.Sleep(1000);
                            Games(saveId);
                        }
                        break;
                    case 1:
                        UpgradePlayer(saveId);
                        break;
                    case 2:
                        Menu();
                        return;   
                }
            }
        

            private void PlayRace(int saveId)
            {
                Console.Clear();
                Console.WriteLine("This is a race week! The race simulation logic would go here.");
                System.Threading.Thread.Sleep(2000);
                
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Execute(
                    sql: "UPDATE GameSaves SET WeekNow = WeekNow + 1 WHERE Id = @Id;",
                    param: new { Id = saveId });
            }

            private void UpgradePlayer(int saveId)
            {
                using var connection = new SqlConnection(connectionString);
            connection.Open();
            
            var gameSave = connection.QueryFirstOrDefault<GameSave>("SELECT * FROM GameSaves WHERE Id = @Id", new { Id = saveId });
            if (gameSave == null) return;

            var team = connection.QueryFirstOrDefault<Team>("SELECT * FROM Teams WHERE Id = @Id", new { Id = gameSave.TeamId });
            if (team == null) return;

            var driver = connection.QueryFirstOrDefault<Driver>("SELECT * FROM Drivers WHERE Id = @Id", new { Id = team.FirstNowDriverId });
            if (driver == null) return;

            var driverCharacteristics = connection.QueryFirstOrDefault<DriverCharacteristics>("SELECT * FROM DriverCharacteristics WHERE Id = @Id", new { Id = driver.CharacteristicsId });
            if (driverCharacteristics == null) return;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Driver Upgrade Menu ---");
                Console.WriteLine($"Upgrade Points: {driverCharacteristics.Points}");
                Console.WriteLine("\nCurrent Characteristics:");
                Console.WriteLine($"1. Qualifying Rating: {driverCharacteristics.QualifyingRating}");
                Console.WriteLine($"2. Speed Rating: {driverCharacteristics.SpeedRating}");
                Console.WriteLine($"3. Defense Rating: {driverCharacteristics.DefenseRating}");
                Console.WriteLine($"4. Overtaking Rating: {driverCharacteristics.OvertakingRating}");
                Console.WriteLine($"5. Concentration Rating: {driverCharacteristics.ConcentrationRating}");
                Console.WriteLine($"Overall Rating: {driverCharacteristics.Rating}");

                Console.WriteLine("\nEnter the number of the characteristic to upgrade (or '0' to exit):");
                string? input = Console.ReadLine();
                int option = 0;
                int.TryParse(input, out option);

                if (option == 0)
                {
                    Games(saveId);
                    return;
                }

                if (option < 1 || option > 5)
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    System.Threading.Thread.Sleep(2000);
                    continue;
                }

                Console.WriteLine("How many points to spend?");
                string? pointsInput = Console.ReadLine();
                int pointsToSpend = 0;
                int.TryParse(pointsInput, out pointsToSpend);

                if (pointsToSpend <= 0 || pointsToSpend > driverCharacteristics.Points)
                {
                    Console.WriteLine("Insufficient points or invalid amount. Please try again.");
                    System.Threading.Thread.Sleep(2000);
                    continue;
                }
                
                switch (option)
                {
                    case 1:
                        driverCharacteristics.QualifyingRating += pointsToSpend;
                        break;
                    case 2:
                        driverCharacteristics.SpeedRating += pointsToSpend;
                        break;
                    case 3:
                        driverCharacteristics.DefenseRating += pointsToSpend;
                        break;
                    case 4:
                        driverCharacteristics.OvertakingRating += pointsToSpend;
                        break;
                    case 5:
                        driverCharacteristics.ConcentrationRating += pointsToSpend;
                        break;
                }
                
                driverCharacteristics.Points -= pointsToSpend;

                driverCharacteristics.Rating = (driverCharacteristics.QualifyingRating + 
                                                driverCharacteristics.SpeedRating + 
                                                driverCharacteristics.DefenseRating + 
                                                driverCharacteristics.OvertakingRating + 
                                                driverCharacteristics.ConcentrationRating) / 5;
                
                try
                {
                    string sql = @"UPDATE DriverCharacteristics SET
                                 Rating = @Rating,
                                 QualifyingRating = @QualifyingRating,
                                 SpeedRating = @SpeedRating,
                                 DefenseRating = @DefenseRating,
                                 OvertakingRating = @OvertakingRating,
                                 ConcentrationRating = @ConcentrationRating,
                                 Points = @Points
                                 WHERE Id = @Id;";
                    connection.Execute(sql, driverCharacteristics);
                    Console.WriteLine($"Characteristic successfully upgraded! Points remaining: {driverCharacteristics.Points}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during saving: {ex.Message}");
                }
                
                System.Threading.Thread.Sleep(2000);
                Games(saveId);
            }
                
            }
        
    }
}
