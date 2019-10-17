using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {

            Human Josh = new Human("Josh"); 
            Human Britt = new Human("Britt", 5, 5, 5, 150);


            Human merlin = new Wizard("Merlin");


            Human kins = new Ninja("Kins");
            kins.displayInfo();


            Human addison = new Samurai("Addison");

            (addison as Samurai).Medidate();
        }
    }
}