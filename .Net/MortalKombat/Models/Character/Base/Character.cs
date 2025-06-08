namespace MortalKombat.Models.Character.Base
{
    public abstract class Character
    {
        private char skin;
        public char Skin
        {
            get
            {
                return skin;
            }
            protected set
            {
                skin = value;
            }
        }
        private int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hp can't be less 0", nameof(value));
                }
                hp = value;
            }
        }
        private int attack;
        public int Attack
        {
            get
            {
                return attack;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Attack can't be less 0", nameof(value));
                }
                attack = value;
            }
        }
        private int defence;
        public int Defence
        {
            get
            {
                return defence;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Defence can't be less 0", nameof(value));
                }
                defence = value;
            }
        }
        private char xRayButton = 'x';
        public char XRayButton
        {
            get
            {
                return xRayButton;
            }
            set
            {
                xRayButton = value;
            }
        }
        private int xRayPercent = 0;
        public int XRayPercent
        {
            get
            {
                return xRayPercent;
            }
            protected set
            {
                xRayPercent = value;
            }
        }
        private int xRayAttack;
        public int XRayAttack
        {
            get
            {
                return xRayAttack;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("XRay Attack can't be less 0", nameof(value));
                }
                xRayAttack = value;
            }
        }
        private string fatalityCombination;
        public string FatalityCombination
        {
            get
            {
                return fatalityCombination;
            }
            protected set
            {
                fatalityCombination = value;
            }
        }
        protected virtual void CharacterAttack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Attack");
            Console.ResetColor();
        }
        protected virtual void CharacterDefence()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Defence");
            Console.ResetColor();
        }
        protected virtual void CharacterDamage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Damage");
            Console.ResetColor();
        }
        protected void Damage(int hp, int attack, int defence)
        {
            if (defence > attack)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("The opponent parried your attack");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"You lose -{hp - (attack - defence)} hp");
                Console.ResetColor();
                Hp = hp - (attack - defence);
            }
        }
        protected virtual void XRay(char button)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have X-Ray!");
            Console.ResetColor();
        }
        protected virtual void Fatality(string combination, char skin2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Fatality!");
            Console.ResetColor();
        }
    }
}