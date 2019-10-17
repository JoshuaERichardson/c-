using System;

namespace human
{
    public class Samurai: Human
    {
        public Samurai(string name): base(name)
        {
            this.health = 200;
        }

        public Samurai DeathBlow(Human deathBlowTarget)
        {
            if (deathBlowTarget.health < 50)
            {
                deathBlowTarget.health = 0;
                Console.WriteLine("Attacked target at critical health! {0}'s health reduced to {1}", deathBlowTarget.name, deathBlowTarget.health);
            }
            else
            {
                Attack(deathBlowTarget);
                Console.WriteLine($"{deathBlowTarget.name}'s health was not critical. Dealt regular attack to target.");
            }
            return this;
        }

        public Samurai Medidate()
        {
            health = 200;
            Console.WriteLine($"{name} used meditate. Restored to full health.");
            displayInfo();
            return this;
        }
    }
}