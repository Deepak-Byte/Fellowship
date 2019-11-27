//---------------------------------------------------------------------
// <copyright file="Inputoutput.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//---------------------------------------------------------------------
namespace DataStrutrure
{
    using System;

    /// <summary>
    /// This is Inputoutput class.
    /// </summary>
    public class Inputoutput
    {
        
        public void Add()
        {
            try
            {
                LinkedList list = new LinkedList();
                Console.WriteLine("Enter your string to add");
                string words = Console.ReadLine();
                list.Add(words);
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }


        /// <summary>
        /// Addats this instance.
        /// </summary>
        public void Addat()
        {
            try
            {
                LinkedList list = new LinkedList();
                Console.WriteLine("Enter your string to add");
                string word = Console.ReadLine();
                Console.WriteLine("Enter at which location you want to add");
                int index = int.Parse(Console.ReadLine());
                list.Insert(word, index);
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            try
            {
                LinkedList list = new LinkedList();
                Console.WriteLine("What element you want to delete enter it's position");
                int position = int.Parse(Console.ReadLine());
                list.Remove(position);
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }

        /// <summary>
        /// Presentthanremoves this instance.
        /// </summary>
        public void Presentthanremove()
        {
            try
            {
                LinkedList list = new LinkedList();
                Console.WriteLine("Enter your seraching word");
                string data = Console.ReadLine();
                bool b = list.Search(data);
                if (b == true)
                    Console.WriteLine("element found");
                else
                    Console.WriteLine("element not found");
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }

        /// <summary>
        /// Checkempties this instance.
        /// </summary>
        public void Checkempty()
        {
            try
            {
                LinkedList list = new LinkedList();
                Console.WriteLine(list.IsEmpty() + "Your file is empty");
            }
            catch (FormatException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E1)
            {
                Console.WriteLine(E1.Message);
            }
        }
    }
}
