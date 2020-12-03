using System;
using System.Collections.Generic;
using System.Threading;

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
            bool loop = true;
            int loginAttempts = 3;
            Console.WriteLine("Hej! Ange koden på basgruppen för att logga in.");
            while (loop)
            {
                string kodSvar = Console.ReadLine();
                if (kodSvar == "Götebuggarna" || kodSvar == "götebuggarna")
                {
                    Console.WriteLine("Korrekt!");
                    loop = false;
                }
                else
                {
                    loginAttempts--;
                    Console.WriteLine("Fel! " + loginAttempts + " försök kvar!");
                    if (loginAttempts == 0)
                    {
                        Console.WriteLine("Applikationen stängs ner.");
                        System.Environment.Exit(1);
                    }
                }
            }
        }
    }
}
