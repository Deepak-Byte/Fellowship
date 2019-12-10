using System;

namespace Structural_Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("---------------------------WELCOME TO STRUCTURE TO PATTERN------------------------------");
                    Console.WriteLine("1: Adapter design pattern");
                    Console.WriteLine("2: Facade design pattern");
                    Console.WriteLine("3: Proxy design pattern");
                    Console.WriteLine("4: To exit a program");
                    int userchoice = int.Parse(Console.ReadLine());
                    switch (userchoice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("wrong input entering by you");
                            break;

                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }
    }
}
