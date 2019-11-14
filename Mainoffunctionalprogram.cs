using System;

namespace Functionalprogram
{
    class Mainoffunctionalprogram
    {
        static void Main(string[] args)
        {
            Label2:
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("what operation you wnat to perform in functional program");
                    Console.WriteLine("1: two D array : ");
                    Console.WriteLine("2: sum of three equal to zero : ");
                    Console.WriteLine("3: distance formula for elcudin");
                    Console.WriteLine("4: Qudratic : ");
                    Console.WriteLine("5: wind chill : ");
                    Console.WriteLine("6: to exit proram press ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                              TwoDarray twodarray = new TwoDarray();
                              twodarray.Array();
                              break;
                        case 2:
                              Sumofthreezero sumof = new Sumofthreezero();
                              sumof.sumofthreezero();
                              break;
                        case 3:
                              Distanceformula disform = new Distanceformula();
                              disform.distanceformula();
                              break;
                        case 4:
                              Quadraticequestion quad = new Quadraticequestion();
                              quad.quadraticequestion();
                              break;
                        case 5:
                              Windchill wind = new Windchill();
                              wind.wind();
                              break;
                        case 6:
                             flag = false;
                             break;
                        default:
                             Console.WriteLine("wrong input enterd press 6 to exit ");
                             break;
                    }



                }
            }catch(FormatException formate)
            {
                Console.WriteLine(formate.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Label2;
            }



        }
    }
}
