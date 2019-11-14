using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Harmonicnumber
    {

        public void harmonicnum()
        {
            Utility utility = new Utility();
            Console.WriteLine(" How much harmonic number you want");
            int number = int.Parse(Console.ReadLine());
            utility.harmonicnumber(number);
            Console.WriteLine();
        }
    }
}
