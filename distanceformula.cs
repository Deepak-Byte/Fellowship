using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalprogram
{
    class Distanceformula
    {
        public void distanceformula()
        {
            Utility utility = new Utility();
            Console.WriteLine("ENTER THE VALUE OF TWO POINT NEED TO FIND DISTANCE : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            utility.distance(a,b);

        }
    }
}
