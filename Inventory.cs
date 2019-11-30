using System;
using System.Collections.Generic;
using System.Text;

namespace DEEPAKKPASI
{
   public class Inventory
    {
        String type;
        String nameofItem;
        int weight;
        int price;

        public string NameofItem { get => nameofItem; set => nameofItem = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
    }
}
