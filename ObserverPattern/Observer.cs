using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Design_Patterns.ObserverPattern
{
    public class Observer
    {
        public static void ObserverFunction()
        {
            try
            {
                //// create Instance od an CompanyClass class.
                Company company = new Company("Capgemini", 100);
                company.Attach(new Inventory("Attach"));
                company.Detach(new Inventory("Detach"));

                company.Price = 100;
                company.Price = 200;
                company.Price = 300;
                company.Price = 400;

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
