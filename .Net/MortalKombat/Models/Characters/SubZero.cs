namespace MortalKombat.Models.Characters.Base

{
    public class SubZero : Character
    {
        public override void CharacterAttackLeft()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("*\t*\t*");
            Console.ResetColor();
        }
        public override void CharacterAttackRight()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("*\t*\t*");
            Console.ResetColor();
            System.Console.WriteLine($"\t\t{this.Skin}");
        }
        public override void CharacterDefenceLeft()
        {
            System.Console.Write($"{this.Skin}\t\t");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("|");
            Console.ResetColor();
        }
        public override void CharacterDefenceRight()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("|");
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

        public override void XRay(char button)
        {
            if (button == this.XRayButton)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                System.Console.Write($"{this.Skin}\t\t");
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("--------------------------->");
                Console.ResetColor();
            }

        }
        public override void Fatality(string combination, char skin2)
        {
            if (combination == this.FatalityCombination)
            {
                System.Console.WriteLine("Fatality");
                Console.Clear();
                Thread.Sleep(400);
                System.Console.Write(this.Skin);
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("\t\t\t\t[");
                Console.ResetColor();
                System.Console.WriteLine(skin2);
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("]");
                Console.ResetColor();
            }
        }

        public void Show()
        {
            System.Console.WriteLine("Name:  Sub-Zero");
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

        public SubZero(int hp, int attack, int defence, int xRayAttack, string fatalityCombination, char skin)
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