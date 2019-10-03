using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Doo do doo dooooo");
            Nokia elevenhundred = new Nokia("1100", 60, "Metro PCS", "Ringgg rinnggg rinngggg");

            s8.DisplayInfo();
        }
        
    }
}
