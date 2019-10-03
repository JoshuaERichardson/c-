using System;

namespace human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health
        {
            get { return health; }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            this.health = 50;
            this.Intelligence = 25;
        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            health += dmg;
            System.Console.WriteLine($"Wizard {Name} healed for {dmg} health!");
            return target.health;
        }   
        public int Heal(Human target)
        {
            int healed = Intelligence * 10;
            target.health += healed;
            System.Console.WriteLine($"{Name} healed {target.Name} for {healed} damage!");
            return target.health;
        }
    }
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            this.Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.health -= dmg;
            Random rnd = new Random();
            int backStabChance = rnd.Next(1,6);
            string backStabResult;
            if(backStabChance == 1)
            {
                target.health -= 10;
                backStabChance.ToString();
                backStabResult = "backstabbed for an additional 10 damage";
            }
            else
            {
                backStabResult = "failed the backstab";
            }
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg}.  After sneaking around the opponent, the ninja {backStabResult} ");
            return target.health;
        }
        public int Steal(Human target)
        {
            if(target.health >= 5)
            {
                this.health += 5;
                target.health -= 5;
            }
            else
            {
                this.health += target.health;
                target.health -= target.health;
            }
            return target.health;
        }
    }
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            this.health = 200;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.health <= 50)
            {
                target.health -= target.health;
                System.Console.WriteLine($"Samurai {Name} delivered a killing blow!");
            }
            return target.health;
        }
        public int Meditate()
        {
            this.health = 200;
            System.Console.WriteLine($"Samurai {Name} healed to full!");
            return this.health;
        }

    }


}
