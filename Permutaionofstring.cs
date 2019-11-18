using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Permutaionofstring
    {
        Utility utility = new Utility();
        public void PermutaionofString()
        {
            Console.WriteLine("Enter your string number");
            string input= Console.ReadLine();
            int len = input.Length;
            utility.Permutaion(input,0,len);
        }
    }
}
