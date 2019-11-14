using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalprogram
{
    class TwoDarray
    {

        public void Array()
        {
            Utility utility = new Utility();

            Console.WriteLine("enter size of array for integer ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            utility.ArrayInt(out array, m, n);

            Console.WriteLine("enter size of array for double ");
            int m1 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            Double[,] array1 = new Double[m, n];
            utility.Arraydouble(out array1, m1, n1);

            Console.WriteLine("enter size of array for boolean ");
            int m2 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            String[,] array2 = new String[m, n];
            utility.Arrayboolean(out array2, m2, n2);

            Console.WriteLine("your integer two D array ");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("your double two D array ");

            for (int k = 0; k < m1; k++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("{0}\t", array1[k, j]);


                }
                Console.WriteLine("");
            }

            Console.WriteLine("your boolean two D array ");

            for (int k = 0; k < m2; k++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write("{0}\t", array2[k, j]);

                    
                }
                Console.WriteLine("");
            }

        }
    }
}
