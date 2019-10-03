using System;

namespace firstCSharp
{
    class Program
    {
        // public static void GetAverage(int[] numbers)
        // {
        //     int total = 0;
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         total += numbers[i];
        //     }
        //     int avg = total / numbers.Length;
        //     Console.WriteLine($"Your average is: {avg}");
        // }
        public static void Sigma(int number)
        {
            int total = 0;
            for(int i = number; i>0; i--){
                total += i;
            }
            Console.WriteLine($"Your sigma is {total}");

        }
        public static void PrintNumbers(int number)
        {
            for(int i = 1; i <= number; i++)
                Console.WriteLine(i);
        }
        public static void PrintOdds(int number)
        {
            for(int i=1; i<= number; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum(int number)
        {
            int total = 0;
            for(int i=1; i<=number; i++)
            {
                total += i;
                Console.WriteLine($"New Number: {i} Sum: {total}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            int total = numbers[0];
            for(int i=1; i< numbers.Length; i++)
            {
                total += numbers[i];
                Console.WriteLine($"New Number: {i} Sum: {total}");
            }
        }
        public static void divisible(int number)
        {
            int i = 1;
            while (i <= number)
            {
                if(i%3 == 0 && i%5 != 0)
                {
                    Console.WriteLine($"The number {i} is divisible by three only!");
                }
                if(i%5 == 0 && i%3 != 0)
                {
                    Console.WriteLine($"The number {i} is divisible by five only!");
                }
                i++;
            }
        }
        // public static void LoopArray(int[] numbers)
        // {
        //     foreach(int i in numbers)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if(max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
        }
        public static void GetAverage(int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                total+=i;
            }
            total = total/numbers.Length;
            Console.WriteLine($"Your average is {total}");
        }
        public static int[] oddArray()
        {
            int[] container = new int[128];
            int oddCounter = 1;
            int indexed = 0;
            while(indexed <= 127)            
            {
                while(oddCounter <= 255)
                {
                    if(oddCounter%2 != 0)
                    {
                        container[indexed] = oddCounter;
                        indexed ++;
                    }
                    oddCounter++;
                }
            }
            for(int i = 0; i < container.Length; i++)
            {
                Console.WriteLine(container[i]);
            }
            Console.WriteLine(container);
            return container;
        }
        // public static void PrintContainer(int[] numbers)
        // {
        //     foreach(int indexed in numbers)
        //     {
        //         Console.WriteLine(numbers[indexed]);
        //     }
        // }

        public static void Main(string[] args)
        {
            // GetAverage([10, 15, 20]);
            Sigma(5);
            PrintNumbers(255);
            PrintOdds(11);
            PrintSum(15);
            LoopArray(new int[]{5, 10, 15});
            divisible(80);
            FindMax(new int[]{5, 10, 15});
            GetAverage(new int[]{5, 10, 15});
            oddArray();
        }
    }
}
