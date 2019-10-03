using System;
using System.Collections.Generic;

namespace ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffet = new Buffet();
            var myNinja = new Ninja();
            myNinja.Eat(buffet.Serve());
            myNinja.Eat(buffet.Serve());
            myNinja.Eat(buffet.Serve());

            Console.WriteLine("Hello World!");
        }
        interface IConsumable
        {
            string Name {get; set;}
            int Calories {get; set;}
            bool IsSpicy {get; set;}
            bool IsSweet {get; set;}
            string GetInfo();
        }
        class Food : IConsumable
        {
            public string Name {get;set;}
            public int Calories {get;set;}
            public bool IsSpicy {get;set;}
            public bool IsSweet {get;set;}
            public string GetInfo()
            {
                return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
            }
            public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
            {
                this.Name = Name;
                this.Calories = Calories;
                this.IsSpicy = IsSpicy;
                this.IsSweet = IsSweet;
            }
        }
        class Drink : IConsumable
        {
            public string Name {get;set;}
            public int Calories {get;set;}
            public bool IsSpicy {get;set;}
            public bool IsSweet {get;set;}
            public string GetInfo()
            {
                return $"{Name} (Drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet? ALWAYS! {IsSweet}";
            }
            public Drink(string Name, int Calories, bool IsSpicy)
            {
                this.Name = Name;
                this.Calories = Calories;
                this.IsSpicy = IsSpicy;
                this.IsSweet = true;
            }
        }
        class Buffet
        {
            public List<Food> Menu;

            public Buffet()        //constructor
            {
                Menu = new List<Food>()
                {
                    new Food("Pizza", 1000, false, false),
                    new Food("Shrimp", 200, true, true),
                    new Food("Steak", 350, false, false),
                    new Food("Cake", 800, false, true),
                    new Food("Coffee", 15, false, false),
                    new Food("Sweet Tea", 125, false, true),
                    new Food("Just all the food mixed together", 8000, true, true)
                };
            }
            public Food Serve()
            {
                Random random = new Random();
                int randInt = random.Next(0, Menu.Count);
                return Menu[randInt];
            }
        }
        abstract class Ninja
        {
            protected int calorieIntake = 0;
            public List<IConsumable> ConsumptionHistory;
            public Ninja()
            {
                calorieIntake = 0;
                ConsumptionHistory = new List<IConsumable>();
            }
            public abstract bool IsFull {get;}
            public abstract void Consume(IConsumable item);
            // public List<Food> FoodHistory = new List<Food>();
            // public bool IsFull(int calorieIntake)
            // {
            //     if (calorieIntake < 1200)
            //     {
            //         return false;
            //     }
            //     else
            //     {
            //         return true;
            //     }
            // }
            // public void Eat(Food food)
            // {
            //     if (IsFull(calorieIntake))   // if false run
            //     {
            //         System.Console.WriteLine("This little fattie went to the market");
            //     }
            //     else
            //     {
            //         calorieIntake += food.Calories;
            //         FoodHistory.Add(food);
            //         System.Console.WriteLine($"O good yum yum food: {food.Name}.  Spicy: {food.IsSpicy}.  Sweet: {food.IsSpicy}");
            //     }
            // }
        }
        class SweetTooth : Ninja
        {
            if(Ninja.calorieIntake < 1500)
            {
                
            }
        }
    }
}
