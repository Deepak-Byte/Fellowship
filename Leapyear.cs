using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Leapyear
    {
        Utility utility = new Utility();
        public void leapyear()
        {
            Console.WriteLine("enter the year your want chech : ");
            int year = int.Parse(Console.ReadLine());
            utility.leapyr(year);
            Console.WriteLine();
        }
    }
}
