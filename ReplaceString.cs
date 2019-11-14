using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{

    public class Replacestring
    {
        public void ReplaceString()
        {
            try
            {
                Utility utility = new Utility();

                string finalstring = "hello <<username>> , how are you ?";

                Console.WriteLine("enter the username you want to replace");

                string name = Console.ReadLine();

                utility.Replacestring(finalstring, name);

            }
            catch (FormatException e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("my axception format exception");
            }
            Console.WriteLine("");
        }
    }

}
