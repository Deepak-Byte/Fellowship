using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.AdapterDesign
{
    public class Customarclass
    {
        public void AdapterFuncation()
        {
            try
            {
                IAdapter adapter = new Client();
                foreach (string product in adapter.Getproductdetails())
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }
    }
}
