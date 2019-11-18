using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Anagramdetection
    {
        Utility utility = new Utility();
        public void anagramDetection()
        {
            Console.WriteLine("Enter your string need to check");
            String str = Console.ReadLine();
            utility.anagramDetection(str);
        }
    }
}
