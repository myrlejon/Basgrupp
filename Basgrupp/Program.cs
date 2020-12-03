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

        public static void Meny()
        {
            Console.WriteLine("Vad vill du göra\n1. Lista gruppens deltagare.\n2. Lista upp 10 generella detaljer om varje medlem.\n3. Ta bort en person.");

        }
    }

    class Medlem
    {
        private string namn;
        private int ålder;
        private int födelsedag;
        private string mat;
        private string band;
        private string film;
        private string älskar;
        private string hatar;
        private string stjärntecken;
        private string superkraft;
        private string driv;

        public Medlem()
        {

        }

        public Medlem(string namn, int ålder, int födelsedag, string mat, string band, string film, string älskar, string hatar, string stjärntecken, string superkraft, string driv)
        {
            this.namn = namn;
            this.ålder = ålder;
            this.födelsedag = födelsedag;
            this.mat = mat;
            this.band = band;
            this.film = film;
            this.älskar = älskar;
            this.hatar = hatar;
            this.stjärntecken = stjärntecken;
            this.superkraft = superkraft;
            this.driv = driv;
        }
    }
}
