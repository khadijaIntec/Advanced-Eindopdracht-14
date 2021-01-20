using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14.Models
{
   public class Lid : Bezoeker
    {
        //internal readonly string Wachtwoord;

        public string Geboortedatum { get; set; }

        public List<Item> ItemsUitgeleend { get; set; }
        public string GeboorteDatum { get; }
        public object GeboorteDatum1 { get; }

        public Lid(string voorNaam, string familieNaam, DateTime geboorteDatum1, string geboorteDatum, string wachtwoord) : base(voorNaam, familieNaam)
        {
            GeboorteDatum = geboorteDatum;
        }

        public Lid(string voornaam, string familieNaam, object geboorteDatum) : base(voornaam, familieNaam)
        {
            GeboorteDatum1 = geboorteDatum;
        }
    }
}
