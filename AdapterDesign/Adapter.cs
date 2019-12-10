using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.AdapterDesign
{
    public class Adapter
    {
        public List<string> ListOfProductDetails()
        {
            //// Use List as generic collection type
            List<string> news = new List<string>();
            try
            {
                Console.WriteLine("Industrial News");
                Console.WriteLine("Television News");
                Console.WriteLine("Educational News");
                Console.WriteLine("Share Market News");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return news;
        }
    }
}
