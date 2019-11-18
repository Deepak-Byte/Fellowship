using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Bubblesort
    {
        Utility utility = new Utility();
        public void bubbleSort()
        {
            Console.WriteLine("Enter number of element you need to enter");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Know enter the element of array ");
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            utility.bubbleSort(array , length);
        }
    }
}
