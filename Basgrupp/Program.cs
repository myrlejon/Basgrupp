using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Basgrupp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändrar färg på konsollen så det ser lite mer trevligt ut.
            Console.Title = "Basgruppen";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Welcome();
            Medlemmar();
        }

        //Här är själva inloggningsmetoden. Användaren får tre försök till att skriva in rätt kod, sen om det misslyckas så stängs applikationen ner. 
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

        //Det här är själva "main" metoden som programmet kör efter inlogg.
        public static void Medlemmar()
        {
            //Här så sparar jag alla medlemmar, genom att införa klassen "Medlem" ifrån en annan fil (Medlem.cs) så kan jag spara alla variabler.

            List<String> medlemDetaljer = new List<String>() { };
            string[] namnDetaljer = { "Namn: ", "Ålder: ", "Mat: ", "Band: ", "Film: ", "Älskar: ", "Hatar: ", "Stjärntecken: ", "Superkraft: ", "Driv: " };

            Medlem Andrei = new Medlem("Andrei", 26, "12:e Januari", "Carbonara", "Two Steps from Hell", "The Lord of the Rings", "Resa", "Oliver", "Stenbock", "Instant olive detection", "Problemlösning");
            Medlem Jesper = new Medlem("Jesper", 28, "29:e Maj", "Lammracks", "Lars Winnerbäck", "Catch me if you can", "De enkla sakerna", "Folk som filmar på konserter", "Tvilling", "Teleportering", "Frihet");
            Medlem Leroy = new Medlem("Leroy", 32, "22:e Oktober", "Pizza", "We the best music", "Matrix", "Choklad", "Kaviar", "Våg", "Flyga", "Dynamiskt");
            Medlem MA = new Medlem("MA", 29, "13:e Mars", "Rårakor", "Modest Mouse", "Snatch", "Höst/Vinter", "Banan", "Fisk", "Mrs.Hindsight", "Skapande");
            Medlem Gurra = new Medlem("Gurra", 33, "17:e November", "Tacos", "Berliner Philharmoniker", "Star Wars", "J.S. Bach", "Schlager", "Skorpion", "Tala med hundvalpar", "Kreativitet");
            Medlem Jonna = new Medlem("Jonna", 30, "5:e Februari", "Pizza", "Full of hell", "Interstellar", "Musik", "Kött", "Vattumann", "Odödlig", "Tjurskallig");
            Medlem Linus = new Medlem("Linus", 27, "17:e Juli", "Fisksoppa", "Jack Moy", "The secret life of walter mitty", "Banan", "Senap", "Kräfta", "Andas under vatten", "Få ett riktigt skoj jobb");
            Medlem Nils = new Medlem("Nils", 21, "15:e Mars", "Pannkakor", "Beach Boys", "American Psycho", "Snö", "Slask", "Fisk", "Räkna med fingrarna", "Roligt");
            Medlem Yulrok = new Medlem("Yulrok", 38, "23:e april", "Musli", "Morcheeba", "The green book", "Ost", "Slöseri", "Oxen", "Tankeöverföring", "Biljett till 'Digital nomad' - livet");

            List<Medlem> medlemLista = new List<Medlem>() { Andrei, Jesper, Leroy, MA, Gurra, Jonna, Linus, Nils, Yulrok };



            //Här är själva menyn i en while loop. Kommentarer för respektive alternativ nedanför.
            bool meny = true;
            while (meny)
            {
                Console.WriteLine("\nVad vill du göra?\n1. Lista gruppens deltagare.\n2. Lista upp 10 generella detaljer om varje medlem.\n3. Ta bort en person.\n4. Stäng ner programmet.");
                string menyInput = Console.ReadLine();
                int menyVal = Convert.ToInt32(menyInput);

                //Alternativ för att lista upp alla medlemmar i basgruppen. Notera att "i == medlemLista.Count - 1" finns för att undvika så att listan slutar med ett kommatecken.
                if (menyVal == 1)
                {
                    for (int i = 0; i < medlemLista.Count; i++)
                    {
                        if (i == medlemLista.Count - 1)
                        {
                            Console.WriteLine(medlemLista[i].Namn + ".");
                        }
                        else
                        {
                            Console.Write(medlemLista[i].Namn + ", ");
                        }
                    }
                }
                //Alternativ för att se 10 detaljer om varje medlem i basgruppen.
                else if (menyVal == 2)
                {
                    for (int i = 0; i < medlemLista.Count; i++)
                    {
                        Console.WriteLine(namnDetaljer[0] + medlemLista[i].Namn);
                        Console.WriteLine(namnDetaljer[1] + medlemLista[i].Ålder);
                        Console.WriteLine(namnDetaljer[2] + medlemLista[i].Mat);
                        Console.WriteLine(namnDetaljer[3] + medlemLista[i].Band);
                        Console.WriteLine(namnDetaljer[4] + medlemLista[i].Film);
                        Console.WriteLine(namnDetaljer[5] + medlemLista[i].Älskar);
                        Console.WriteLine(namnDetaljer[6] + medlemLista[i].Hatar);
                        Console.WriteLine(namnDetaljer[7] + medlemLista[i].Stjärntecken);
                        Console.WriteLine(namnDetaljer[8] + medlemLista[i].Superkraft);
                        Console.WriteLine(namnDetaljer[9] + medlemLista[i].Driv + "\n\n");
                    }
                }

                //Alternativ till att radera en medlem ifrån basgruppen.
                else if (menyVal == 3)
                {
                    Console.WriteLine("Skriv in namnet på medlemmen du vill ta bort.");
                    string deleteMember = Console.ReadLine();
                    foreach (var medlem in medlemLista)
                    {
                        if (deleteMember == medlem.Namn)
                        {
                            Console.WriteLine("Medlemmen har blivit borttagen ifrån basgruppen.");    
                            medlemLista.Remove(medlem);
                            break;
                        }
                    }
                }

                //Alternativ till att stänga ner programmet.
                else if (menyVal == 4)
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}