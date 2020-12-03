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
            Medlemmar();
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

        public static void Meny()
        {
            Console.WriteLine("Vad vill du göra\n1. Lista gruppens deltagare.\n2. Lista upp 10 generella detaljer om varje medlem.\n3. Ta bort en person.");

        }

        public static void Medlemmar()
        {
            Medlem Andrei = new Medlem("Andrei K", 26, "12:e januari", "Carbonara", "Two Steps from Hell", "The Lord of the Rings", "Resa", "Oliver", "Stenbock", "Instant olive detection", "Problemlösning");
            Console.WriteLine($"{Andrei.Namn} {Andrei.Ålder} {Andrei.Mat} {Andrei.Band} {Andrei.Film} {Andrei.Älskar} {Andrei.Hatar} {Andrei.Stjärntecken} {Andrei.Superkraft} {Andrei.Driv}");
        }
    }
}