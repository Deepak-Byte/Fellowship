using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Utility
    {

        /************************repalce string********************************************************/
        public void Replacestring(string username, string name)
        {

            string replace = username.Replace("<<username>>", name);
            Console.WriteLine(replace);
        }


        /************************flip coin********************************************************/
        public void Flipcoin(int number)
        {
            int head = 0;
            int tail = 0;
            for (int i=0;i<number;i++)
            {
                
                Random rnd = new Random();
                int month = rnd.Next(1, 13);
                if (month > 6)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
           }
            double headpercentage = (head * 100) / number;
            double tailpercentage = 100 - headpercentage;
            Console.WriteLine("head percentage"+ headpercentage);
            Console.WriteLine("head percentage" + tailpercentage);


        }


        /************************power of two********************************************************/
        public void poweroftwo(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int RESULTS = (int)  Math.Pow(2, i);
                Console.WriteLine(RESULTS);
            }
        }


        /************************harmonic number********************************************************/
        public void harmonicnumber(int number)
        {
           Double sum  = 0; 
           for (int i=1;i<number;i++)
            {
                sum = sum + (1.0 / i);

                //Console.Write(1/i+"+");
            }
            Console.WriteLine("the sum of all harmonic number is : "+sum);
        }


        /************************prime factor********************************************************/
        public int primeofactor(int number)
        {
            for (int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                    number /= i;

                }
            }
            if (number > 2)
            {
                return number;
            }
            return number;
        }

        /************************leap year program********************************************************/

        public void leapyr(int year)
        { 
            if (year%4==0 && (year%400==0 || year!=0))
            {
                Console.WriteLine("It is leap year"); ;
            }
            else
            {
                Console.WriteLine("It is not leap year");
            }
        }

    }
}
