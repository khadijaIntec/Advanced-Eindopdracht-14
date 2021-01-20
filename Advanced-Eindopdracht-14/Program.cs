using Advanced_Eindopdracht_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14
{
    public enum SoortItem
    {
        Boek,
        Stripverhaal,
        DVD,
        CD
    }
    class Program
    {
        public static object nieuweItemCollectie { get; private set; }

        static void Main(string[] args)
        {
            Bezoeker nieuweBezoeker = new Bezoeker();
            //nieuweItemCollectieBeb = new CollectieBeb();


            Item testNieuwItem = new Item();
            testNieuwItem.soorItem = SoortItem.Boek;
            testNieuwItem.ItemId = 1;
            testNieuwItem.Titel = "De GVR";
            testNieuwItem.Auteur = "Shaquille O'neil";
            testNieuwItem.Jaartal = 2000;
            testNieuwItem.Uitgeleend = true;
            testNieuwItem.Afgevoerd = false;

            Item nieuwItem002 = new Item();
            nieuwItem002.soorItem = SoortItem.DVD;
            nieuwItem002.ItemId = 2;
            nieuwItem002.Titel = "The Last Dance";
            nieuwItem002.Auteur = "Michael Jordan";
            nieuwItem002.Jaartal = 1995;
            nieuwItem002.Uitgeleend = false;
            nieuwItem002.Afgevoerd = false;




            // KEUZE MENU
            Console.WriteLine("Hallo en welkom in onze vernieuwde Bibliotheek-console\n" +
                "Hoe wilt u zich aanmelden:\nA)LID\nB)MEDEWERKER\nC)BEZOEKER");

            ConsoleKey instructionKey = Console.ReadKey().Key;
            Console.Clear();
            switch (instructionKey)
            {
              // SWITCH CASE LIDMENU
                case ConsoleKey.A:
                    Console.WriteLine("A)LID:\n");
                    break;


                // SWITCH CASE MEDEWERKERMENU
                case ConsoleKey.B:
                    Console.WriteLine("B)MEDEWERKER:\n");
                    break;


                // SWITCH CASE BEZOEKERMENU
                case ConsoleKey.C:
                    break;
                    //Console.WriteLine("C)BEZOEKER:\n");
                    Console.WriteLine("Geef je familienaam:");
                    nieuweBezoeker.FamilieNaam = Console.ReadLine();
                    Console.WriteLine("\nGeef je voornaam:");
                    nieuweBezoeker.Voornaam = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(nieuweBezoeker.Voornaam);
                    Console.WriteLine("Wat wil je doen:\n" +
                        "A-->Registreer als Lid\n" +
                        "B-->Zoek een Item op Titel of op item Id\n" +
                        "C-->Toon overzichten");
                    ConsoleKey instructionKeyBezoeker = Console.ReadKey().Key;
                    Console.Clear();
                    switch (instructionKeyBezoeker)
                    {
                        case ConsoleKey.A:

                        case ConsoleKey.B:
                            Console.WriteLine("B)Zoek een Item op titel of ItemId\n");

                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("C)Toon overzichten\n");

                            break;
                    }


            }


            Console.ReadLine();
        }
    }
}
