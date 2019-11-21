using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Regex
    {
        public void RegEx()
        {
            Utility utility = new Utility();
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your number ");
            int number = int.Parse(Console.ReadLine());
            utility.RegEx(name, number);
        }
    }
}
