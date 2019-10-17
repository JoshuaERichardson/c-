using System;

namespace human
{
    public class Human
    {
        public string name;
        public int strength, intelligence, dexterity, health;
        public Human(string name)
        {

            this.name = name;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        
        public Human Attack(Human attackTarget)
        {
            attackTarget.health -= 5 * strength;
            Console.WriteLine($"{attackTarget.name} was attacked. Health is now at {attackTarget.health}");
            return this;
        }
        
        public Human Attack(object attackTarget)
        {
            if (attackTarget is Human)
            {
                Human temp = attackTarget as Human;
                temp.health -= 5 * strength;
                temp.displayInfo();
            }
            else
            {
                Console.WriteLine("You can only attack humans!");
            }
            return this;
        }

        public Human displayInfo()
        {
            Console.WriteLine($"name: {this.name}, strength: {strength}, intelligence: {intelligence}, dexterity: {dexterity}, health: {health}");
            return this;
        }
    }
}