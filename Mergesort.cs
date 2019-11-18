using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Mergesort
    {
        Utility utility = new Utility();
        public void mergeSort()
        {
            Console.WriteLine("Enter araay size ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Know enter the element of array ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            utility.mergeSort(array ,0 ,size-1);



        }
    }

}
