using MortalKombat.Models.Characters.Base;

namespace MortalKombat.Models.Game
{
    public class Gameplay
    {
        SubZero subZero = new SubZero(100, 12, 10, 35, "zero", 'Z');
        Scorpion scorpion = new Scorpion(100, 13, 9, 35, "pion", 'S');
        Jack jack = new Jack(100, 20, 5, 40, "ck", 'J');
        public void choice()
        {
            System.Console.Write("1)");
            subZero.Show();
            System.Console.Write("2)");
            scorpion.Show();
            System.Console.Write("3)");
            jack.Show();
            System.Console.WriteLine("Choose a character number:");
        }
        public void move()
        {

        }
    }
}