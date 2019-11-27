//---------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//---------------------------------------------------------------------

namespace DataStrutrure.Orderdlist
{
    using System;
    
    /// <summary>
    /// this is main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            ////Actual program is start from here////
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("What operation you want to perform ");
                    Console.WriteLine("1: Do you want to STRING LINKED LIST");
                    Console.WriteLine("2: Do you want to INTEGER LINKED LIST ");
                    Console.WriteLine("Enter number 3 to exit the program ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            select();
                            break;
                        case 2:
                            Orderdlist.Orderedlist.Method1();
                            break;
                        case 3:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input entred");
                            break;
                    }
                }

            }
            catch (FormatException formate)
            {
                Console.WriteLine(formate.Message);
            }
            catch (Exception Normalfont)
            {
                Console.WriteLine(Normalfont.Message);
            }

            /*************************************To string operation****************************/
            void select()
            {
                LinkedList list = new LinkedList();
                //Inputoutput1 io1 = new Inputoutput1();
                string text = System.IO.File.ReadAllText(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");
                ////Display the file contents to the console. Variable text is a string.
                //System.Console.WriteLine("Contents of WriteText.txt is ");
                //Console.WriteLine(text);

                string[] words = text.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    list.Add(words[i]);
                }

                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("What operation you want to perform ");
                        Console.WriteLine("1: Do you want to add string");
                        Console.WriteLine("2: Do you want to remove a string and search string ");
                        Console.WriteLine("3: Do you want to search string or show list");
                        Console.WriteLine("Enter No 4 to exit a program");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Toadd();
                                break;
                            case 2:
                                Toremove();
                                break;
                            case 3:
                                Tosearch();
                                break;
                            case 4:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Wrong input entred");
                                break;
                        }
                    }

                }
                catch (FormatException formate)
                {
                    Console.WriteLine(formate.Message);
                }
                catch (Exception Normalfont)
                {
                    Console.WriteLine(Normalfont.Message);
                }
            }

            /////*************************************To add************************************/
            void Toadd()
            {
                LinkedList list = new LinkedList();
                Inputoutput io = new Inputoutput();
                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1: Do you want to add string at last");
                        Console.WriteLine("2: Do you want to add string at at index");
                        Console.WriteLine("Enter No 3 to exit a program");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                io.Add();
                                break;

                            case 2:
                                io.Addat();
                                break;

                            case 3:
                                flag = false;
                                break;

                            default:
                                Console.WriteLine("Wrong input ");
                                break;
                        }

                    }
                }
                catch (FormatException formate)
                {
                    Console.WriteLine(formate.Message);
                }
                catch (Exception Normalfont)
                {
                    Console.WriteLine(Normalfont.Message);
                }
            }

            /*************************************To  remove************************************/
            void Toremove()
            {
                LinkedList list = new LinkedList();
                Inputoutput io = new Inputoutput();
                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1: Do you want to remove");
                        Console.WriteLine("2: Do you want to check your string if present remove  than");
                        Console.WriteLine("3: Do you want to POP at last ");
                        Console.WriteLine("Enter No 4 to exit a program ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                               io.Delete();
                                break;

                            case 2:
                                io.Presentthanremove();
                                break;

                            case 3:
                                list.Pop();
                                break;

                            case 4:
                                flag = false;
                                break;

                            default:
                                Console.WriteLine("Wrong input ");
                                break;
                        }

                    }
                }
                catch (FormatException formate)
                {
                    Console.WriteLine(formate.Message);
                }
                catch (Exception Normalfont)
                {
                    Console.WriteLine(Normalfont.Message);
                }
            }

            /*************************************To display and check length************************************/
            void Tosearch()
            {
                LinkedList list = new LinkedList();
                Inputoutput io = new Inputoutput();
                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1: Do you want to check is list empty and also check it's length");
                        Console.WriteLine("2: Do you want to display a list ");
                        Console.WriteLine("Enter No 3 to exit");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                io.Checkempty();
                                break;

                            case 2:
                                list.Show();
                                break;

                            case 3:
                                flag = false;
                                break;

                            default:
                                Console.WriteLine("Wrong input ");
                                break;
                        }

                    }
                }
                catch (FormatException formate)
                {
                    Console.WriteLine(formate.Message);
                }
                catch (Exception Normalfont)
                {
                    Console.WriteLine(Normalfont.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
