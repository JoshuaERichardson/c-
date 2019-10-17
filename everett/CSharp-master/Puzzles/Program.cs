using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] numArray = new int[10];
            Random rInt = new Random();
            int max = numArray[0];
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rInt.Next(5,26);
                sum += numArray[i];
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }
            }
            Console.WriteLine($"Max value: {max}");
            Console.WriteLine($"Sum of values: {sum}");
            return numArray;
        }

        public static  string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rInt = new Random();
            int toss = rInt.Next(0,2);
            if (toss == 0)
            {
                Console.WriteLine("Heads");
                string result = "Heads";
                return result;
            }
            else
            {
                Console.WriteLine("Tails");
                string result = "Tails";
                return result;
            }
        }

        public static double TossMultipleCoins(int num)
        {
            int heads = 0;
            for (int i = 0; i < num; i++)
            {
                string result = TossCoin();
                if (result == "Heads")
                {
                    heads++;
                }
            }
            double ratio = (double)heads/num;
            Console.WriteLine($"Your heads to total toss ratio is: {ratio}");
            Console.WriteLine($"{ratio*100}% of your tosses have been heads!");
            return ratio;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>() {"Todd", "Tiffany", "Charile", "Geneva", "Sydney"};
            Random rInt = new Random();
            for (int i = 0; i < names.Count; i++)
            {
                int randNum = rInt.Next(0, names.Count);
                string temp = names[i];
                names[i] = names[randNum];
                names[randNum] = temp;
            }
            Console.WriteLine("Here is your new order:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
                if (names[i].Length <= 5)
                {
                    names.Remove(names[i]);
                }
            }
            return names;
        }
    }
}