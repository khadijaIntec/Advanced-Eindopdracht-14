using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Eindopdracht_14.Models
{
    public static class CollectieBeb
    {
        public static List<Item> ItemsInCollectie { get; private set; }
        public static List<Item> AfgevoerdeItems { get; private set; }
        public static List<Lid> Leden { get; private set; }
        static CollectieBeb()
        {
            ItemsInCollectie = new List<Item>();
            AfgevoerdeItems = new List<Item>();
            Leden = new List<Lid>();
        }
    }
}