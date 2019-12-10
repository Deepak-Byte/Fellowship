using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.ObserverPattern
{
    public class Company:Stock
    {
        public Company(string symbol, int price) : base(symbol, price)
        {
        }
    }
}
