using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class TossCoin
    {
       
        public void CheckCoin()
        { Utility utility = new Utility();
            Console.WriteLine("enter number of time you want to reapet");
            int number = int.Parse(Console.ReadLine());
            utility.Flipcoin(number);
            Console.WriteLine("");

        }
    }
}
