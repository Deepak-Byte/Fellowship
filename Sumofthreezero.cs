using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalprogram
{
    class Sumofthreezero
    {
        Utility Utilty = new Utility();
        public void sumofthreezero()
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value in your array ");
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Utility.sumoftheenum(a ,size);
        }
    }
}
