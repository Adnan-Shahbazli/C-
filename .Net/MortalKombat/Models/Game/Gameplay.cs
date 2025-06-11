using MortalKombat.Models.Characters.Base;

namespace MortalKombat.Models.Game
{
    public class Gameplay
    {
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        Character[] characters = new Character[3];

        public void choice()
        {
            System.Console.Write("1)");
            subZero.Show();
            System.Console.Write("2)");
            scorpion.Show();
            System.Console.Write("3)");
            jack.Show();
            for (int choice = 0; !(choice > 0) || !(choice < 4);)
            {
                System.Console.WriteLine("Choose a character number:");
                string choiceString = Console.ReadLine();
                choice = Convert.ToInt32(choiceString);
                if


            }

        }
        public void move()
        {

        }

        public Gameplay()
        {
            characters[0] = new SubZero(100, 12, 10, 35, "zero", 'Z');
            characters[1] = new Scorpion(100, 13, 9, 35, "pion", 'S');
            characters[2] = new Jack(100, 20, 5, 40, "ck", 'J');
        }
    }
}