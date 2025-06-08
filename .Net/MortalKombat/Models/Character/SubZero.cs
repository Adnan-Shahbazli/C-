namespace MortalKombat.Models.Character.Base
{
    public class SubZero : Character
    {
        protected override void CharacterAttack()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("*\t*\t*");
            Console.ResetColor();
        }
        protected override void CharacterDefence()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("|");
            Console.ResetColor();
        }
        protected override void CharacterDamage()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write(this.Skin);
                Thread.Sleep(400);
                Console.Clear();
                System.Console.Write("");
                Thread.Sleep(400);
            }
        }

        protected override void XRay(char button)
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("--------------------------->");
            Console.ResetColor();

        }
        protected override void Fatality(string combination, char skin2)
        {
            System.Console.Write(this.Skin);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("\t\t\t\t[");
            Console.ResetColor();
            System.Console.WriteLine(skin2);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("]");
            Console.ResetColor();
        }

        protected SubZero(int hp, int attack, int defence, char xRayAttack, string fatalityCombination)
        {
            Hp = hp;
            Attack = attack;
            Defence = defence;
            XRayAttack = xRayAttack;
            FatalityCombination = fatalityCombination;
        }
    }
}