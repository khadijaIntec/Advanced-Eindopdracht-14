using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14.Models
{
    public class Bezoeker
    {
        private readonly string VoorNaam;

        public string Voornaam { get; set; }
        public string FamilieNaam { get; set; }
        public DateTime GeboorteDatum { get; private set; }
        public static string Geboortedatum { get; private set; }

        public Bezoeker(string voornaam, string familieNaam)
        {
            FamilieNaam = familieNaam;
            Voornaam = VoorNaam;
        }

        public Bezoeker()
        {
            CollectieBeb.Leden.Add(new Lid(Voornaam, FamilieNaam, GeboorteDatum));
            Console.WriteLine("Registratie voltooid, u staat op de Ledenlijst");

        }

        public void RegistreerLid()
        {

            Console.WriteLine("Geef je Geboortedatum:");
            Lid nieuwLid = NieuwLid;

            List<string> nieuweLeden = new List<string>();
            nieuweLeden.Add(nieuwLid.voorNaam);
            nieuweLeden.Add(nieuwLid.FamilieNaam);
            nieuweLeden.Add(nieuwLid.Geboortedatum);
            Console.WriteLine($"{Voornaam} {FamilieNaam} Geboren op:{nieuwLid.Geboortedatum}\nPROFICIAT: Je bent geregistreerd als Lid!");



        }

        //private static  Lid GetNieuwLid()
        //{
        //    throw new NotImplementedException();
        //}

        private static Lid NieuwLid
        {
            get
            {
                //return new Lid
                {
                    Geboortedatum = Console.ReadLine();
                }
            }
        }

        public void ZoekItem()
        {
            Console.WriteLine("Hoe wil je item zoeken:\nA) titel\nB) Op item Id");

            ConsoleKey instructionKeyZoekItem = Console.ReadKey().Key;
            Console.Clear();
            switch (instructionKeyZoekItem)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Geef titel zoekopdract:\n");
                    string titelZoekOpdracht = Console.ReadLine();


                    foreach (var item in CollectieBeb.ItemsInCollectie)
                    {

                        if (item.Titel != titelZoekOpdracht)
                        {
                            Console.WriteLine($"Helaas is het gezochte item met titel {titelZoekOpdracht} niet in de collectie van de bibliotheek");

                        }
                        else
                        {
                            Console.WriteLine($"De gevraagde titel {titelZoekOpdracht} zit in de collectie van de bibliotheek");

                            break;
                        }
                    }

                    break;

                case ConsoleKey.B:
                    Console.WriteLine("Geef item Id zoekopdracht\n");
                    int itemIdZoekOpdracht = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in CollectieBeb.ItemsInCollectie)
                    {
                        if (item.ItemId == itemIdZoekOpdracht)
                        {
                            Console.WriteLine($"Het gevraagde item met ID {itemIdZoekOpdracht} zit in de collectie van de bibliotheek");

                            break;
                        }
                        else
                        {
                            Console.WriteLine($" Het gezochte item met ID {itemIdZoekOpdracht} Niet in de collectie van de bibliotheek");
                        }
                    }
                    break;
            }
        }

    }
}


        
    


    
