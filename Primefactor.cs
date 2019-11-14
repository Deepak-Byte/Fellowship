using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Primefactor
    {
        public void factor()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter the number you want find the prime factor : ");
            int number = int.Parse(Console.ReadLine());
            int result=utility.primeofactor(number);
            Console.WriteLine(result);
            Console.WriteLine("");
        }

    }
}
