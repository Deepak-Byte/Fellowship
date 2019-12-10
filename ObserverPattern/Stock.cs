using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.ObserverPattern
{
    public abstract class Stock
    {
        private string symbol;
        private int price;
        private List<IInventory> Inventories = new List<IInventory>();

        public Stock(string symbol1, int price1)
        {
            this.symbol = symbol1;
            this.price = price1;
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }

        public string Symbol
        {
            get { return this.symbol; }
        }

        public void Attach(IInventory inventoryInterface)
        {
            try
            {
                this.Inventories.Add(inventoryInterface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Detach(Inventory @interface)
        {
            try
            {
                this.Inventories.Remove(@interface);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Notify()
        {
            try
            {
                foreach (IInventory @interface in this.Inventories)
                {
                    @interface.Update(this);
                }

                Console.WriteLine(" ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
