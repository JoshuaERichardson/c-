using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            string result = TossCoin();   // <------ result
            Console.WriteLine(result);
            TossMultipleCoins(15);
            ReturnsStrings();
        }
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] container = new int[10];
            for(int val = 0; val < 10; val++)
            {
                container[val] = rand.Next(5,26);
            }
            PrintMinMax(container);
        }
        public static void PrintMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int total = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                total += arr[i];
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The max is: {max}.  The min is {min}.  The total is: {total}");
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            int side = rand.Next(1,3);
            if(side == 1)
            {
                Console.WriteLine("Heads!");
                string result = "Heads!";
                return result;
            }
            else
            {
                Console.WriteLine("Tails....");
                string result = "Tails....";
                return result;
            }
        }
        public static double TossMultipleCoins(int num)
        {
            int headCount = 0;
            int tailsCount = 0;
            while (num > 0)
            {
                string thisToss = TossCoin();
                if(thisToss == "Heads!")
                {
                    headCount++;
                }
                else
                {
                    tailsCount++;
                }
                num--;
            }
            Console.WriteLine($"headCount = {headCount}.  tailsCount = {tailsCount}");
            double totalFlips = headCount + tailsCount;
            double headRatio = headCount / totalFlips;
            Console.WriteLine($"The percentage of heads you flipped is {headRatio}");
            return headRatio;
        }
        public static void ReturnsStrings()
        {
            List<string> names = new List<string>() {"Todd", "Chiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            int[] randInt = new int[names.Count];
            List<string> newNames = new List<string>();
            while(names.Count != 0)
            {
                int pulledName = rand.Next(0, names.Count);
                newNames.Add(names[pulledName]);
                Console.WriteLine(names[pulledName]);
                names.RemoveAt(pulledName);
            }
            while(newNames.Count != 0)
            {
                int i = 0;
                if(newNames[i].Length > 5)
                {
                    Console.WriteLine($"The Count of {newNames[i]} is {newNames[i].Length}");
                    names.Add(newNames[i]);
                }
                newNames.RemoveAt(i);
                i++;
            }
        }
    }   
}
