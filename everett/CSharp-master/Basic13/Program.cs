using System;

namespace Basic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Max value = {max}");
        }

        public static void GetAverage(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            int avg = total / numbers.Length;
            Console.WriteLine($"Your average is: {avg}");
        }

        public static int[] OddArray()
        {
            int[] NewArray = new int[128];
            int count = 0;
            for (int i = 1; i <= 255; i+=2)
            {
                NewArray[count] = i;
                count++;
            }
            return NewArray;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num > y)
                {
                    total++;
                }
            }
            return total;
        }

        public static int[] SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public static int[] EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int total = 0;
            int max = numbers[0];
            int min = numbers[0];
            foreach (int num in numbers)
            {
                total += num;
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
            }
            int avg = total / numbers.Length;
            Console.WriteLine($"Max value: {max}");
            Console.WriteLine($"Min value: {min}");
            Console.WriteLine($"Average: {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
                Console.WriteLine(numbers[i]);
            }
            numbers[numbers.Length-1] = 0;
            Console.WriteLine(numbers[numbers.Length-1]);
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] newArray = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    newArray[i] = "Dojo";
                }
                else
                    newArray[i] = numbers[i];
                Console.WriteLine(newArray[i]);
            }
            return newArray;
        }
    }
}