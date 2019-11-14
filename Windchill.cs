using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalprogram
{
    class Windchill
    {
        Utility utility = new Utility();
        public void wind()
        {
            double t, v;
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("enter value of temperature t and velocity v : ");
                 t = double.Parse(Console.ReadLine());
                 v = double.Parse(Console.ReadLine());
                if (t<50 && v<120 && v>3)
                {
                    flag = false;
                    //goto lable3;
                    utility.Windchillsum(t, v);
                }
                else
                {
                    flag = true;
                }
                
            }

            //lable3:
           

        }
    }
}
