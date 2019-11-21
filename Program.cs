//---------------------------------------------------------------------
// <copyright file="Program.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//---------------------------------------------------------------------

namespace DataStrutrure
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

            LinkedList  list = new LinkedList ();
            //LinkedList<int> list = new LinkedList<int>();
            //list.Add(12);
            //list.Add(25);

            //list.Show();
            //list.Insert(66, 1);
            //list.Show();
            //list.Remove(2);
            //list.Add(55);
            //list.Show();

            string text = System.IO.File.ReadAllText(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");
            ////Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt is ");
            //Console.WriteLine(text);

            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i]);
            }

            ////Actual program is start from here////
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("What operation you want to perform ");
                    Console.WriteLine("1: Do you want to add string");
                    Console.WriteLine("2: Do you want to remove a string ");
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

            /////*************************************To add************************************/
            void Toadd()
            {
                LinkedList list = new LinkedList();
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
                                Console.WriteLine("Enter your string to add");
                                string words = Console.ReadLine();
                                list.Add(words);
                                break;

                            case 2:
                                Console.WriteLine("Enter your string to add");
                                string word = Console.ReadLine();
                                Console.WriteLine("Enter at which location you want to add");
                                int index = int.Parse(Console.ReadLine());
                                list.Insert(word, index);
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
                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("1: Do you want to remove");
                        Console.WriteLine("2: Do you want to check your string if present remove  than");
                        Console.WriteLine("Enter No 3 to exit a program ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("What element you want to delete enter it's position");
                                int position = int.Parse(Console.ReadLine());
                                list.Remove(position);
                                break;
                            case 2:
                                Console.WriteLine("Enter your seraching word");
                                string data = Console.ReadLine();
                                bool b = list.Search(data);
                                if (b == true)
                                    Console.WriteLine("element found");
                                else
                                    Console.WriteLine("element not found");
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

            /*************************************To display and check length************************************/
            void Tosearch()
            {
                LinkedList list = new LinkedList();
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
                                Console.WriteLine(list.IsEmpty() + "Your file is empty");
                                Console.WriteLine(list.IsEmpty());
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
