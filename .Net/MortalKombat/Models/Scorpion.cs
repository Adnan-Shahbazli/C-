namespace MortalKombat.Models.Character.Base
{
    public class Scorpion : Character
    {

        protected override void CharacterAttack()
        {
            System.Console.Write($"{this.Skin}\t\t");
            System.Console.WriteLine("--------------------------->");
        }
        protected override void CharacterDefence()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("/\\");
            Console.ResetColor();
        }
        protected override void CharacterDamage()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write(this.Skin);
                Thread.Sleep(400);
                Console.Clear();
                Thread.Sleep(400);
            }
        }

        protected override void XRay(char button)
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("--------------------------->");
            Console.ResetColor();

        }
        protected override void Fatality(string combination, char skin2)
        {
            if (combination == this.FatalityCombination)
            {
                System.Console.WriteLine("Fatality");
                Thread.Sleep(400);
                Console.Clear();
                System.Console.WriteLine($"{this.Skin}\t\t\t\t{skin2}");
                Thread.Sleep(400);
                Console.Clear();
                System.Console.WriteLine($"\t{this.Skin}\t\t\t{skin2}");
                Thread.Sleep(400);
                Console.Clear();
                System.Console.WriteLine($"\t\t{this.Skin}\t\t{skin2}");
                Thread.Sleep(400);
                Console.Clear();
                System.Console.WriteLine($"\t\t\t{this.Skin}\t{skin2}");
                Thread.Sleep(400);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"\t\t\t\t{skin2}");
                Console.ResetColor();
                System.Console.WriteLine($"\t{this.Skin}");
            }
        }

        protected Scorpion(int hp, int attack, int defence, char xRayAttack, string fatalityCombination)
        {
            Hp = hp;
            Attack = attack;
            Defence = defence;
            XRayAttack = xRayAttack;
            FatalityCombination = fatalityCombination;
        }
    }
}