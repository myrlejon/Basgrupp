using System;
using System.Collections.Generic;

namespace Basgrupp
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        public static void Welcome()
        {
            Console.WriteLine("Hej! Ange koden på basgruppen för att logga in.");
            string kodSvar = Console.ReadLine();
            if (kodSvar == "Götebuggarna" || kodSvar == "götebuggarna")
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
