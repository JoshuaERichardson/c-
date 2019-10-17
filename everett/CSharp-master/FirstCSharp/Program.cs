using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to interpolate
            string place = "Coding Dojo";
            //Interpolated string, note the $
            string message = $"Hello {place}";
            // Displaying final message
            Console.WriteLine(message);
        }
    }
}
