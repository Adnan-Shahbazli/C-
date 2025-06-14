

namespace MortalKombat.Models.Characters.Base
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
            set
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
            set
            {
                fatalityCombination = value;
            }
        }
        public virtual void ShowXRayAttack()
        {
            if (XRayPercent == 0)
            {
                System.Console.WriteLine("\t\t\t░|░|░");
            }
            else if (XRayPercent == 1)
            {
                System.Console.WriteLine("\t\t\t▓|▒|░");
            }
            else if (XRayPercent == 2)
            {
                System.Console.WriteLine("\t\t\t▓|▓|▒");
            }
            else if (XRayPercent == 3)
            {
                System.Console.WriteLine("\t\t\t▓|▓|▓");
            }
        }
        public virtual void CharacterAttackLeft()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Attack");
            Console.ResetColor();
        }
        public virtual void CharacterAttackRight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Attack");
            Console.ResetColor();
        }
        public virtual void CharacterDefenceLeft()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Defence");
            Console.ResetColor();
        }
        public virtual void CharacterDefenceRight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Defence");
            Console.ResetColor();
        }
        public virtual void CharacterDamage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Damage");
            Console.ResetColor();
        }
        public void Damage(Character Player1, Character Player2, int attack, int defence)
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
                Console.ResetColor();
                if (Player2.Hp - (attack - defence) < 0)
                {
                    Player2.Hp = 0;
                }
                else
                {
                    Player2.Hp -= attack - defence;
                }
                
            }
        }
        public virtual void XRay()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have X-Ray!");
            Console.ResetColor();
        }
        public virtual void Fatality(string combination, char skin2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("You don't have Fatality!");
            Console.ResetColor();
        }
        public virtual void Show()
        {
            System.Console.WriteLine("This class don't have show method");
        }
    }
}