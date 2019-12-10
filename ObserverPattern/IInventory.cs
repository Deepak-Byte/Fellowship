using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.ObserverPattern
{
    public interface IInventory
    {
        void Update(Stock stock);
    }
}
