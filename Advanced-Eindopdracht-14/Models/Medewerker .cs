using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14.Models
{
    public class Medewerker : Lid
    {
        public Medewerker(string voornaam, string familienaam, DateTime geboorteDatum, string gebruikersnaam, string wachtwoord) : base(voornaam, familienaam, geboorteDatum, gebruikersnaam, wachtwoord)
        {
        }
        public static void PromoveerLidNaarMedewerker(Lid lid)
        {
            //CollectieBeb.Leden.Add(new Medewerker(lid.Voornaam, lid.FamilieNaam, lid.geboorteDatum, lid.gebruikersnaam, lid.Wachtwoord));
            CollectieBeb.Leden.Remove(lid);

        }
        public static void VoerItemAf(Item item)
        {
            CollectieBeb.AfgevoerdeItems.Add(item);
            CollectieBeb.ItemsInCollectie.Remove(item);
            item.VoerAf();

        }
        public static void VoegItemToe(Item item)
        {
            CollectieBeb.ItemsInCollectie.Add(item);

        }
        static public void GeefOverzichtMedewerkers()
        {
            foreach (var item in CollectieBeb.Leden)
            {
                if (item is Medewerker)
                {
                    Console.WriteLine(item + "\n");
                }
               
            }
            }

        private static void VoegItemToe1()
        {
            string titel;
            string regieauteuruitvoerder;
            string itemId;
            string soortitem;
            int jaartal;
            bool uitgeleend;
            bool afgevoerd;

            Console.WriteLine("Item toevoegen aan collectie" +
                "\nVoer item gegevens in:" +
                "\nTitel:");
            titel = Console.ReadLine();
            Console.WriteLine("Maker:");
            regieauteuruitvoerder = Console.ReadLine();
            Console.WriteLine("Item Id:");
            itemId = Console.ReadLine();
            Console.WriteLine("Soort Item:lukt of niet");
            soortitem = Console.ReadLine();

            Console.WriteLine("Jaartal:");
            jaartal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uitgeleed(true/false):");
            uitgeleend = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Afgevoerd(true/false):");
            afgevoerd = Convert.ToBoolean(Console.ReadLine());

            Item item003 = new Item()
            {
                Titel = titel,
                RegieAuteurUitvoerder = regieauteuruitvoerder,
                Jaartal = jaartal,
                Uitgeleend = uitgeleend,
                Afgevoerd = afgevoerd
            };
            CollectieBeb.ItemsInCollectie.Add(item003);

        }
        public void VoegItemToe()
        {
            string titel;
            string regieauteuruitvoerder;
            string itemId;
            string soortitem;
            int jaartal;
            bool uitgeleend;
            bool afgevoerd;

            Console.WriteLine("Item toevoegen aan collectie" +
                "\nVoer item gegevens in:" +
                "\nTitel:");
            titel = Console.ReadLine();
            Console.WriteLine("Maker:");
            regieauteuruitvoerder = Console.ReadLine();
            Console.WriteLine("Item Id:");
            itemId = Console.ReadLine();
            Console.WriteLine("Soort Item:lukt nog niet");          
            soortitem = Console.ReadLine();


            Console.WriteLine("Jaartal:");
            jaartal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uitgeleed(true/false):");
            uitgeleend = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Afgevoerd(true/false):");
            afgevoerd = Convert.ToBoolean(Console.ReadLine());

            Item item003 = new Item()                                     
            {
                Titel = titel,
                RegieAuteurUitvoerder = regieauteuruitvoerder,
       
                Jaartal = jaartal,
                Uitgeleend = uitgeleend,
                Afgevoerd = afgevoerd
            };

            CollectieBeb.ItemsInCollectie.Add(item003);
           
        }
    }
    }



