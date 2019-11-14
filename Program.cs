using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Label:
            try
            {

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("want operation you want to perform");
                    Console.WriteLine("1: replace string ");
                    Console.WriteLine("2: flip coin ");
                    Console.WriteLine("3: leap year  ");
                    Console.WriteLine("4: power of two ");
                    Console.WriteLine("5: harmonic number ");
                    Console.WriteLine("6: prime factor ");
                    Console.WriteLine("7: PRESS 6 TO EXIT");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                              Replacestring replacestring = new Replacestring();
                              replacestring.ReplaceString();
                              break;

                        case 2:
                              TossCoin flip = new TossCoin();
                              flip.CheckCoin();
                              break;

                        case 3:
                              Leapyear leapyear = new Leapyear();
                              leapyear.leapyear();
                              break;

                        case 4:
                               Poweroftwo powerof = new Poweroftwo();
                               powerof.findpower();
                               break;

                        case 5:
                               Harmonicnumber harmon = new Harmonicnumber();
                               harmon.harmonicnum();
                               break;

                        case 6:
                              Primefactor primefac = new Primefactor();
                              primefac.factor();
                              break;
                      
                        case 7:
                              flag = false;
                              break;

                       default:
                              Console.WriteLine("WRONG INPUT PLEASE ENTER CORRECT INPUT");
                              break;
                    }
                }

            }
            catch (FormatException format)
            {
                Console.WriteLine(format.Message);
                goto Label;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Label;
            }
        }
    }
}
