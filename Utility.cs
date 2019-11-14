using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Functionalprogram
{
    class Utility
    {
        public  void  ArrayInt (out int[,] array, int m, int n)
        {
            array = new int[m, n];

            Console.WriteLine();
            Console.WriteLine("Enter Integer Array");

			for (int i = 0; i<m; i++)
			{
				for (int j = 0; j<n; j++) 
				{
                    array[i, j] = Int32.Parse(Console.ReadLine());
                  
                }
                //Console.WriteLine("");
            }
            
        }

        public void Arraydouble(out Double[,] array1, int m1, int n1)
        {
            array1 = new Double [m1, n1];

            Console.WriteLine();
            Console.WriteLine("Enter double Array");

            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    array1[i, j] = Double.Parse(Console.ReadLine());
                    
                }
                //Console.WriteLine("");
            }
        }

        public void Arrayboolean(out String[,] array2, int m2, int n2)
        {
            array2 = new String [m2, n2];

            Console.WriteLine();
            Console.WriteLine("Enter boolean Array");

            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    array2[i, j] = Console.ReadLine();
                    //array2[i, j] = reader.ReadLine();


                }
                //Console.WriteLine("");
            }
        }

        public static void sumoftheenum ( int[] a,int size)
        {
            bool flag = true;
            for (int i = 0; i < size;i ++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    for (int k = j + 1; k < size; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            Console.WriteLine("first element{0}/t second element {1}/t third element{2}" ,a[i],a[j],a[k]);
                            flag = false;
                        }
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("no such elemenet found.");
            }
        }

        public void distance(double a,double b)
        {
            double start = a * a;
            double end = b * b;
            double sum = start + end;
            double result = Math.Sqrt(sum);
            Console.WriteLine("distance between two point is : "+result);
            
        }

        public void quadequestion(double a, double b, double c)
        {
            double a1 = Math.Sqrt((b * b) - (4 * a * c));
            double b1 = -b + a1;
            double b2 = -b - a1;
            double result1 = b1 / (2 * a);
            double result2 = b2 / (2 * a);
            Console.WriteLine("two possible : " + result1);
            Console.WriteLine("two possible : " + result2);
        }

        public void Windchillsum(double t, double v)
        {
            double result = 35.74 + 0.6215 * t - (0.4275 * t + 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("wind chill results will be : "+result);
        }

    }
}
