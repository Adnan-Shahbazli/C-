namespace MortalKombat.Models.Characters.Base
{
    public class Scorpion : Character
    {

        public override void CharacterAttackLeft()
        {
            System.Console.Write($"{this.Skin}\t\t");
            System.Console.Write("--------------------------->");
        }
        public override void CharacterAttackRight()
        {
            System.Console.Write("<---------------------------");
            System.Console.WriteLine($"\t\t{this.Skin}");
        }
        public override void CharacterDefenceLeft()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write("/\\");
            Console.ResetColor();
        }
        public override void CharacterDefenceRight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write("/\\");
            Console.ResetColor();
            System.Console.WriteLine($"\t\t{this.Skin}");
        }
        public override void CharacterDamage()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write(this.Skin);
                Thread.Sleep(400);
                Console.Clear();
                Thread.Sleep(400);
            }
        }

        public override void XRay()
        {
                System.Console.Write($"{this.Skin}\t\t");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Console.Write("--------------------------->");
                Console.ResetColor();
        }
        public override void Fatality(string combination, char skin2)
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
                System.Console.Write($"\t\t\t\t{skin2}");
                Console.ResetColor();
                System.Console.WriteLine($"\t{this.Skin}");
            }
        }

        public override void Show()
        {
            System.Console.WriteLine("Name:  Scorpion");
            System.Console.Write("Hp:      ");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{Hp}");
            Console.ResetColor();
            System.Console.Write("Damage:  ");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"{Attack}");
            Console.ResetColor();
            System.Console.Write("Defence: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine($"{Defence}");
            Console.ResetColor();
        }

        public Scorpion(int hp, int attack, int defence, int xRayAttack, string fatalityCombination, char skin)
        {
            Hp = hp;
            Attack = attack;
            Defence = defence;
            XRayAttack = xRayAttack;
            FatalityCombination = fatalityCombination;
            Skin = skin;
        }
    }
}