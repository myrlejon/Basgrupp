using System;
using System.Collections.Generic;
using System.Threading;

namespace Basgrupp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändrar färg på konsollen så det ser lite mer trevligt ut.
            Console.Title = "Basgruppen";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Black;
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

            Medlem Andrei = new Medlem("Andrei K", 26, "12:e Januari", "Carbonara", "Two Steps from Hell", "The Lord of the Rings", "Resa", "Oliver", "Stenbock", "Instant olive detection", "Problemlösning");
            string AndreiDetaljer = $"Namn: {Andrei.Namn}\nÅlder: {Andrei.Ålder}\nMat: {Andrei.Mat}\nBand: {Andrei.Band}\nFilm: {Andrei.Film}\nÄlskar: {Andrei.Älskar}\nHatar: {Andrei.Hatar}\nStjärntecken: {Andrei.Stjärntecken}\nSuperkraft: {Andrei.Superkraft}\nDriv: {Andrei.Driv}\n";

            Medlem Jesper = new Medlem("Jesper P", 28, "29:e Maj", "Lammracks", "Lars Winnerbäck", "Catch me if you can", "De enkla sakerna", "Folk som filmar på konserter", "Tvilling", "Teleportering", "Frihet");
            string JesperDetaljer = $"Namn: {Jesper.Namn}\nÅlder: {Jesper.Ålder}\nMat: {Jesper.Mat}\nBand: {Jesper.Band}\nFilm: {Jesper.Film}\nÄlskar: {Jesper.Älskar}\nHatar: {Jesper.Hatar}\nStjärntecken: {Jesper.Stjärntecken}\nSuperkraft: {Jesper.Superkraft}\nDriv: {Jesper.Driv}\n";

            Medlem Leroy = new Medlem("Leroy", 32, "22:e Oktober", "Pizza", "We the best music", "Matrix", "Choklad", "Kaviar", "Våg", "Flyga", "Dynamiskt");
            string LeroyDetaljer = $"Namn: {Leroy.Namn}\nÅlder: {Leroy.Ålder}\nMat: {Leroy.Mat}\nBand: {Leroy.Band}\nFilm: {Leroy.Film}\nÄlskar: {Leroy.Älskar}\nHatar: {Leroy.Hatar}\nStjärntecken: {Leroy.Stjärntecken}\nSuperkraft: {Leroy.Superkraft}\nDriv: {Leroy.Driv}\n";

            Medlem MA = new Medlem("MA Lin", 29, "13:e Mars", "Rårakor", "Modest Mouse", "Snatch", "Höst/Vinter", "Banan", "Fisk", "Mrs.Hindsight", "Skapande");
            string MADetaljer = $"Namn: {MA.Namn}\nÅlder: {MA.Ålder}\nMat: {MA.Mat}\nBand: {MA.Band}\nFilm: {MA.Film}\nÄlskar {MA.Älskar}\nHatar: {MA.Hatar}\nStjärntecken: {MA.Stjärntecken}\nSuperkraft: {MA.Superkraft}\nDriv: {MA.Driv}\n";

            Medlem Gurra = new Medlem("Gurra M", 33, "17:e November", "Tacos", "Berliner Philharmoniker", "Star Wars", "J.S. Bach", "Schlager", "Skorpion", "Tala med hundvalpar", "Kreativitet");
            string GurraDetaljer = $"Namn: {Gurra.Namn}\nÅlder: {Gurra.Ålder}\nMat: {Gurra.Mat}\nBand: {Gurra.Band}\nFilm: {Gurra.Film}\nÄlskar {Gurra.Älskar}\nHatar: {Gurra.Hatar}\nStjärntecken: {Gurra.Stjärntecken}\nSuperkraft: {Gurra.Superkraft}\nDriv: {Gurra.Driv}\n";

            Medlem Jonna = new Medlem("Jonna W", 30, "5:e Februari", "Pizza", "Full of hell", "Interstellar", "Musik", "Kött", "Vattumann", "Odödlig", "Tjurskallig");
            string JonnaDetaljer = $"Namn: {Jonna.Namn}\nÅlder: {Jonna.Ålder}\nMat: {Jonna.Mat}\nBand: {Jonna.Band}\nFilm: {Jonna.Film}\nÄlskar {Jonna.Älskar}\nHatar: {Jonna.Hatar}\nStjärntecken: {Jonna.Stjärntecken}\nSuperkraft: {Jonna.Superkraft}\nDriv: {Jonna.Driv}\n";

            Medlem Linus = new Medlem("Linus N", 27, "17:e Juli", "Fisksoppa", "Jack Moy", "The secret life of walter mitty", "Banan", "Senap", "Kräfta", "Andas under vatten", "Få ett riktigt skoj jobb");
            string LinusDetaljer = $"Namn: {Linus.Namn}\nÅlder: {Linus.Ålder}\nMat: {Linus.Mat}\nBand: {Linus.Band}\nFilm: {Linus.Film}\nÄlskar {Linus.Älskar}\nHatar: {Linus.Hatar}\nStjärntecken: {Linus.Stjärntecken}\nSuperkraft: {Linus.Superkraft}\nDriv: {Linus.Driv}\n";

            Medlem Nils = new Medlem("Nils O", 21, "15:e Mars", "Pannkakor", "Beach Boys", "American Psycho", "Snö", "Slask", "Fisk", "Räkna med fingrarna", "Roligt");
            string NilsDetaljer = $"Namn: {Nils.Namn}\nÅlder: {Nils.Ålder}\nMat: {Nils.Mat}\nBand: {Nils.Band}\nFilm: {Nils.Film}\nÄlskar {Nils.Älskar}\nHatar: {Nils.Hatar}\nStjärntecken: {Nils.Stjärntecken}\nSuperkraft: {Nils.Superkraft}\nDriv: {Nils.Driv}\n";

            Medlem Yulrok = new Medlem("Yulrok", 38, "23:e april", "Musli", "Morcheeba", "The green book", "Ost", "Slöseri", "Oxen", "Tankeöverföring", "Biljett till 'Digital nomad' - livet");
            string YulrokDetaljer = $"Namn: {Yulrok.Namn}\nÅlder: {Yulrok.Ålder}\nMat: {Yulrok.Mat}\nBand: {Yulrok.Band}\nFilm: {Yulrok.Film}\nÄlskar {Yulrok.Älskar}\nHatar: {Yulrok.Hatar}\nStjärntecken: {Yulrok.Stjärntecken}\nSuperkraft: {Yulrok.Superkraft}\nDriv: {Yulrok.Driv}\n";

            List<Medlem> MedlemLista = new List<Medlem>() { Andrei, Jesper, Leroy, MA, Gurra, Jonna, Linus, Nils, Yulrok };
            string TioDetaljer = AndreiDetaljer + "\n" + JesperDetaljer + "\n" + LeroyDetaljer + "\n" + MADetaljer + "\n" + GurraDetaljer + "\n" + JonnaDetaljer + "\n" + LinusDetaljer + "\n" + NilsDetaljer + "\n" + YulrokDetaljer;


            //Här är själva menyn i en while loop. Kommentarer för respektive alternativ nedanför.
            bool meny = true;
            while (meny)
            {
                Console.WriteLine("Vad vill du göra?\n1. Lista gruppens deltagare.\n2. Lista upp 10 generella detaljer om varje medlem.\n3. Ta bort en person.\n4. Stäng ner programmet.");
                string menyInput = Console.ReadLine();
                int menyVal = Convert.ToInt32(menyInput);

                //Alternativ för att lista upp alla medlemmar i basgruppen.
                if (menyVal == 1)
                {
                    foreach (var medlem in MedlemLista)
                    {
                        Console.WriteLine(medlem.Namn);
                    }
                }
                //Alternativ för att se 10 detaljer om varje medlem i basgruppen.
                else if (menyVal == 2)
                {
                    Console.WriteLine(TioDetaljer);
                }

                //Alternativ till att radera en medlem ifrån basgruppen.
                else if (menyVal == 3)
                {
                    Console.WriteLine("Skriv in namnet på medlemmen du vill ta bort.");
                    var deleteMember = Console.ReadLine();
                    if (deleteMember == "Andrei" || deleteMember == "Andrei k"){MedlemLista.Remove(Andrei);}
                    else if (deleteMember == "Jesper" || deleteMember == "Jesper P"){MedlemLista.Remove(Jesper);}
                    else if (deleteMember == "Leroy"){MedlemLista.Remove(Leroy);}
                    else if (deleteMember == "MA" || deleteMember == "MA Lin"){MedlemLista.Remove(MA);}
                    else if (deleteMember == "Gurra" || deleteMember == "Gurra M"){MedlemLista.Remove(Gurra);}
                    else if (deleteMember == "Jonna" || deleteMember == "Jonna W"){MedlemLista.Remove(Jonna);}
                    else if (deleteMember == "Linus" || deleteMember == "Linus N"){MedlemLista.Remove(Linus);}
                    else if (deleteMember == "Nils" || deleteMember == "Nils O"){MedlemLista.Remove(Nils);}
                    else if (deleteMember == "Yulrok"){MedlemLista.Remove(Yulrok);}
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