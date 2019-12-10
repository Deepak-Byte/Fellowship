using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.ObserverPattern
{
    public class Inventory:IInventory
    {
        string name;
        private Stock Stock;

        public Inventory(string name)
        {
            this.name = name;
        }
        public Stock stock
        {
            get
            {
                return this.Stock;
            }

            set
            {
                this.Stock = value;
            }
        }

        public void Update(Stock stock)
        {
            try
            {
                Console.WriteLine("Placed position {0} {1}'s" + "change to {2 : C}", this.name, this.stock.Symbol, this.stock.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
