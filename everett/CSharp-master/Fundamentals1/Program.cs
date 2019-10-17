using System;
using System.Linq;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOP PRINTS FROM 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
             //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");

                    }
                }
                //If you used modulus in the last step, try doing the same without using it.Vice - versa for those who didn't!
            int five = 5;
            int three = 3;
            for (int i = 1; i < 101; i++)
            {
                five--;
                three--;
                if (five == 0 && three == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;

                }else if(five == 0)

                {
                    Console.WriteLine("Buzz");
                    five = 5;
                }else if (three == 0)
                {
                    Console.WriteLine("Fizz");
                    three = 3;
                }

            }
            //Generate 10 random values and output the respective word, in relation to step three, for the generated values
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randVal = rand.Next();
                if(randVal%3==0 && randVal % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }else if (randVal % 3 == 0)
                {
                    Console.WriteLine("Fuzz");
                }else if (randVal % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

            }

        }
    }}