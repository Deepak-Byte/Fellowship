using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalprogram
{
    class Quadraticequestion
    {
        Utility utility = new Utility();
        public void quadraticequestion()
        {
            Console.WriteLine("enter the value point of A ,B and C : ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            utility.quadequestion(a, b, c);
        }
    }
}
