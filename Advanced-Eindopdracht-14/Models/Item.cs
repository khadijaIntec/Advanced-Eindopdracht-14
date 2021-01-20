using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14.Models
{
    public class Item
    {
        //Enum
        public SoortItem SoortItem { get; set; }
        public int ItemId { get; set; }
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Regisseur { get; private set; }
        public int Jaartal { get; set; }
        public bool Uitgeleend { get; set; }
        public bool Afgevoerd { get; set; }
        public bool Gereserveerd { get; set; }
        public string RegieAuteurUitvoerder { get; internal set; }
        public SoortItem soorItem { get; internal set; }
        public object Uitvoerder { get; private set; }

        private static int[] itemCounter = new int[Enum.GetNames(typeof(SoortItem)).Length];
        public Item(SoortItem soortItem, string titlel, string maker, int jaartal, bool uitgeleend, bool gereserveerd, bool afgevoerd)
        {
            SoortItem = soortItem;
            Titel = titlel;
            Auteur = maker;
            Regisseur = maker;
            Jaartal = jaartal;
            itemCounter[(int)SoortItem]++;
            Uitgeleend = uitgeleend;
            Gereserveerd = gereserveerd;
            Afgevoerd = afgevoerd;
        }


        public Item(SoortItem soortItem, string titlel, string maker, int jaartal, bool uitgeleend, bool gereserveerd, bool afgevoerd, string manualID)
        {
            SoortItem = soortItem;
            Titel = titlel;
            Auteur = maker;
            Regisseur = maker;
            Jaartal = jaartal;
            itemCounter[(int)SoortItem]++;
            Uitgeleend = uitgeleend;
            Gereserveerd = gereserveerd;
            Afgevoerd = afgevoerd;
        }

        public Item()
        {
        }

        public void LeenUit()
    {
        Uitgeleend = true;
    }
    public void BrengTerug()
    {
        Uitgeleend = false;
    }
    public void VoerAf()
    {
        Afgevoerd = true;
    }
    public void SetReservatie(bool res)
    {
        Gereserveerd = res;
    }
    public override string ToString()
    {
        switch (SoortItem)
        {
            case SoortItem.Boek:
                return $"ID:{ItemId}\nSoort:{SoortItem}\nTitel:{Titel}\nAuteur:{Auteur}\nJaartal:{Jaartal}";
            case SoortItem.Stripverhaal:
                return $"ID:{ItemId}\nSoort:{SoortItem}\nTitel:{Titel}\nAuteur:{Auteur}\nJaartal:{Jaartal}";
            case SoortItem.DVD:
                return $"ID:{ItemId}\nSoort:{SoortItem}\nTitel:{Titel}\nRegisseur:{Regisseur}\nJaartal:{Jaartal}";
            case SoortItem.CD:
                return $"ID:{ItemId}\nSoort:{SoortItem}\nTitel:{Titel}\nUitvoerder:{Uitvoerder}\nJaartal:{Jaartal}";
            default:
                throw new Exception("Ingegeven enum SoortItem bestaat niet!");
        }
    }
    private string generateID(SoortItem soortItem, int counter)
    {
        string id = "";
        int idNoLength = 4;
        string prefix = "";
        switch (soortItem)
        {
            case SoortItem.Boek:
                prefix = "B1";
                break;
            case SoortItem.Stripverhaal:
                prefix = "S1";
                break;
            case SoortItem.DVD:
                prefix = "DVD";
                break;
            case SoortItem.CD:
                prefix = "CD";
                break;
            default:
                throw new Exception("Ingegeven enum bestaat niet!");
        }
        if (counter.ToString().Length > idNoLength)
        {
            idNoLength = counter.ToString().Length;
        }
        id = prefix + new String('0', idNoLength - counter.ToString().Length) + counter.ToString(); 
        return id;
    }
}
}

    
