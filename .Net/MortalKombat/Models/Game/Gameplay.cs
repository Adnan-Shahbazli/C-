using MortalKombat.Models.Characters.Base;

namespace MortalKombat.Models.Game
{
    public class Gameplay
    {
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        Character characterSetting;
        Character[] characters = new Character[3];

        public void menu()
        {
            while (true)
            {
                System.Console.WriteLine("⠠⣤⡄⠄⣤⡤⢠⣤⣤⣤⢠⣤⠤⣤⡀⣤⣤⣤⡄⠄⣤⣤⠄⠄⢤⣤⠄⠄⠄⠄\n⠄⣿⣧⢀⣿⡇⢸⡇⠄⣿⢸⣿⠄⢸⡇⠄⣿⡇⠄⢠⣿⢻⡆⠄⢸⣿⠄⠄⠄⠄\n⠄⣿⢻⣿⢹⡇⢸⡇⠄⣿⢸⣿⠻⣯⡁⠄⣿⡇⠄⣼⠷⠾⣿⠄⢸⣿⠄⠄⠄⠄\n⢠⣿⡈⠟⢸⣇⠸⣷⣶⡿⢸⣿⠄⢸⣿⢀⣿⡇⠰⣿⠄⠄⣿⠆⢸⣿⣤⣤⠇⠄\n⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄\n⠐⣿⢀⣼⠟⠄⣾⠛⢻⣷⢸⣷⠄⢰⣿⠁⢸⣿⠛⣿⠄⠄⣼⣿⡆⢸⠛⣿⠛⠇\n⠄⣿⣾⣇⠄⠄⣿⠄⢸⣿⢸⣿⣧⣼⣿⠄⢸⣿⠶⣿⠄⢰⣿⢸⣧⠄⠄⣿⠄⠄\n⠄⣿⠈⢻⣆⠄⣿⠄⢸⣿⢸⣿⢻⡇⣿⠄⢸⣿⠄⣿⠄⣸⡏⠉⢿⡆⠄⣿⠄⠄\n⠘⠛⠂⠐⠛⠃⠙⠛⠛⠋⠘⠛⠈⠄⠛⠂⠚⠛⠛⠛⠐⠛⠄⠄⠚⠛⠐⠛⠂⠄");
                System.Console.WriteLine("\t1.Play\n\t2.Setting");
                string choiceGameMode = Console.ReadLine();
                if (choiceGameMode == "1")
                {
                    Console.Clear();
                    choice();
                }
                else if (choiceGameMode == "2")
                {
                    Console.Clear();
                    setting();
                }
                else
                {
                    System.Console.WriteLine("I don't understand you. Please write again after 2 second");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
        public void setting()
        {
            while (true)
            {
                System.Console.WriteLine($"1)xRayButton\t\t\t\t\t\t\t\t{characterSetting.XRayButton}\n2)Sub-Zero Fatality\t\t\t\t\t\t\t{characters[0].FatalityCombination}\n3)Scorpion Fatality\t\t\t\t\t\t\t{characters[1].FatalityCombination}\n4)Jack Fatality \t\t\t\t\t\t\t{characters[2].FatalityCombination}");
                System.Console.Write("Enter any number to change button or 0 to exit:");
                string choiceButton = Console.ReadLine();
                Console.Clear();
                if (choiceButton == "1")
                {
                    System.Console.WriteLine("Enter any button");
                    System.Console.Write($"{characterSetting.XRayButton}\t");
                    characterSetting.XRayButton = Convert.ToChar(Console.ReadLine());
                }
                else if (choiceButton == "2")
                {
                    System.Console.WriteLine("Enter any button");
                    System.Console.Write($"{characters[0].FatalityCombination}\t");
                    characters[0].FatalityCombination = Console.ReadLine();
                }
                else if (choiceButton == "3")
                {
                    System.Console.WriteLine("Enter any button");
                    System.Console.Write($"{characters[1].FatalityCombination}\t");
                    characters[1].FatalityCombination = Console.ReadLine();
                }
                else if (choiceButton == "4")
                {
                    System.Console.WriteLine("Enter any button");
                    System.Console.Write($"{characters[2].FatalityCombination}\t");
                    characters[2].FatalityCombination = Console.ReadLine();
                }
                else if (choiceButton == "0")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("I don't understand you. Please write again after 2 second");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                Thread.Sleep(300);
                Console.Clear();
            }
            menu();
        }
        public void choice()
        {
            for (int i = 0; i < characters.Length; i++)
            {
                System.Console.Write($"{i + 1})");
                characters[i].Show();
            }
            for (int choice = 0; ;)
            {
                System.Console.Write("Choose a first character number:");
                string choiceString = Console.ReadLine();
                choice = Convert.ToInt32(choiceString);
                if (choice > 0 && choice < 4)
                {
                    choice = Convert.ToInt32(choiceString);
                    Player1 = choice - 1;
                    Console.Clear();
                    break;
                }
                else
                {
                    System.Console.WriteLine("I don't understand you. Please write again after 2 second");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            for (int i = 0; i < characters.Length; i++)
                {
                    System.Console.Write($"{i + 1})");
                characters[i].Show();
                }
            for (int choice = 0; ;)
            {
                System.Console.Write("Choose a second character number:");
                string choiceString = Console.ReadLine();
                choice = Convert.ToInt32(choiceString);
                if (choice > 0 && choice < 4)
                {
                    choice = Convert.ToInt32(choiceString);
                    Player2 = choice - 1;
                    Console.Clear();
                    break;
                }
                else
                {
                    System.Console.WriteLine("I don't understand you. Please write again after 2 second");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            move();
        }
        public void move()
        {
            for (; ; )
            {
                Random random = new Random();
                int actionNumber = random.Next(2);
                string actionPlayer2;
                if (actionNumber == 0)
                {
                    actionPlayer2 = "1";
                }
                else if (actionNumber == 1)
                {
                    actionPlayer2 = "2";
                }
                else
                {
                    actionPlayer2 = "1";
                }
                characters[Player1].ShowXRayAttack();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{characters[Player1].Hp}\t\t\t\t\t\t\t\t{characters[Player2].Hp}");
                Console.ResetColor();
                System.Console.WriteLine($"{characters[Player1].Skin}\t\t\t\t\t\t\t\t{characters[Player2].Skin}");   
                string choiceAction;
                while (true)
                {   
                     System.Console.WriteLine($"What do you want to do(1.Attack\\2.Defence\\{characters[Player1].XRayButton}.xRayButton)");
                    choiceAction = Console.ReadLine();
                    if (choiceAction == "1" || choiceAction == "2" || choiceAction == Convert.ToString(characters[Player1].XRayButton))
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("I don't understand you. Please write again after 2 second");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                if (choiceAction == "1" && actionPlayer2 == "1")
                {
                    characters[Player1].XRayPercent += 1;
                    characters[Player1].CharacterAttackLeft();
                    characters[Player2].CharacterAttackRight();
                    characterSetting.Damage(characters[Player1], characters[Player2], characters[Player1].Attack, 0);
                    characterSetting.Damage(characters[Player2], characters[Player1], characters[Player2].Attack, 0);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (choiceAction == "1" && actionPlayer2 == "2")
                {
                    characters[Player1].CharacterAttackLeft();
                    characters[Player2].CharacterDefenceRight();
                    characterSetting.Damage(characters[Player1], characters[Player2], characters[Player1].Attack, characters[Player2].Defence);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (choiceAction == "2" && actionPlayer2 == "1")
                {
                    characters[Player1].XRayPercent += 1;
                    characters[Player1].CharacterDefenceLeft();
                    characters[Player2].CharacterAttackRight();
                    characterSetting.Damage(characters[Player2], characters[Player1], characters[Player2].Attack, characters[Player1].Defence);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (choiceAction == "2" && actionPlayer2 == "2")
                {
                    characters[Player1].CharacterDefenceLeft();
                    characters[Player2].CharacterDefenceRight();
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (choiceAction == Convert.ToString(characters[Player1].XRayButton) && actionPlayer2 == "1" && characters[Player1].XRayPercent == 3)
                {
                    characters[Player1].XRay();
                    characters[Player2].CharacterAttackRight();
                    characterSetting.Damage(characters[Player1], characters[Player2], characters[Player1].XRayAttack, 0);
                    characterSetting.Damage(characters[Player2], characters[Player1], characters[Player2].Attack, 0);
                    characters[Player1].XRayPercent = 0;
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (choiceAction == Convert.ToString(characters[Player1].XRayButton) && actionPlayer2 == "2" && characters[Player1].XRayPercent == 3)
                {
                    characters[Player1].XRay();
                    characters[Player2].CharacterDefenceRight();
                    characterSetting.Damage(characters[Player1], characters[Player2], characters[Player1].XRayAttack, characters[Player2].Defence);
                    characters[Player1].XRayPercent = 0;
                    Console.Clear();
                }
                if (characters[Player1].Hp == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Game Over!");
                    Console.ResetColor();
                    Thread.Sleep(5000);
                    Console.Clear();
                    menu();
                }
                if (characters[Player2].Hp == 0)
                {
                    System.Console.Write("Enter fatality combination:");
                    string fatalityCombination = Console.ReadLine();
                    characters[Player1].Fatality(fatalityCombination, characters[Player2].Skin);
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Win");
                    Console.ResetColor();
                    Thread.Sleep(5000);
                    Console.Clear();
                    menu();
                }
                Console.Clear();
            }
        }

        public Gameplay()
        {
            characters[0] = new SubZero(100, 12, 10, 35, "zero", 'Z');
            characters[1] = new Scorpion(100, 13, 9, 35, "pion", 'S');
            characters[2] = new Jack(100, 20, 5, 40, "ck", 'J');
            characterSetting = characters[0];
        }
    }
}