using System;

namespace human
{
    public class Ninja: Human
    {
        public Ninja(string name): base(name)
        {
            this.dexterity = 175;
        }


        public Ninja GetAway()
        {
            health -= 15;
            Console.WriteLine($"{name} got used GetAway.");
            displayInfo();
            return this;
        }

        public Ninja Steal(object stealTarget)
        {
            Attack(stealTarget);
            displayInfo();
            return this;
        }



    }
}