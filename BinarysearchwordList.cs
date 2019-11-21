using System;
namespace Algorithm_Programs
{
    class BinarysearchwordList
    {
        Utility utility = new Utility(); 
        public void binarySearchwordList()
        {
            Console.WriteLine("Enter the you want search ");
            String word = Console.ReadLine();
            utility.binarySearchwordList(word);

        }
    }
}
