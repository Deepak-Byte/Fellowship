using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Poweroftwo
    {
        public void findpower()
        {
            Utility utility = new Utility();
            Console.WriteLine("ENTER NUMBER OF POWER OF TWO YOU WANT : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("POWER OF TWO : ");
            utility.poweroftwo(number);
            Console.WriteLine();
        }

    }
}
