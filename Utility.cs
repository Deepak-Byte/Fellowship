using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;

//class ReadFriendRecords

namespace Algorithm_Programs
{
    class Utility
    {
        /// <summary>
        /// permutation program to print all possible combination
        /// </summary>
        /// <param name="str">it a name or number taken from the user</param>
        /// <param name="start">passing a intial value to the permutation function</param>
        /// <param name="last">passing the length of string </param>
        public void Permutaion(String str, int start, int last)
        {

            if (start == last)
            {
                Console.WriteLine(str);
            }

            else
            {
                for (int i = start; i < last; i++)
                {
                    str = swap(str, start, i);
                    Permutaion(str, start + 1, last);
                    str = swap(str, start, i);

                }
            }

        }

        public string swap(String str, int first, int last)
        {
            char temp;
            Char[] arr = str.ToCharArray();
            temp = arr[first];
            arr[first] = arr[last];
            arr[last] = temp;
            String str2 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str2 += arr[i];
            }
            return str2;

        }

        /****************************binary search word from list ***********************************/

        public void binarySearchwordList(String srword)
        {
            // FileStream inFile = new FileStream(@"H:\C#\Chapter.14\FriendInfo.txt", FileMode.Open, FileAccess.Read);
            //String rootFolder = @"C:\Users\admin\Desktop\new folder to scan";
            //String text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
            String text = System.IO.File.ReadAllText(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt is ");
            Console.WriteLine(text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");

            string[] words = text.Split(' ');

            //String[] sortarr= Array.Sort(words, StringComparer.InvariantCulture);

            for (int i = 0; i < words.Length; i++)                   //this is part for sorting the string  array
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    if (words[j].CompareTo(words[j + 1]) > 0)
                    {
                        String temp;
                        temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(" After binary sorting the string array ");
            Console.WriteLine();
            int l = 0, r = words.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = srword.CompareTo(words[m]);

                // Check if x is present at mid  
                if (res == 0)
                    Console.WriteLine("The word is found at index at " + m + " which is " + srword); ;

                // If x greater, ignore left half  
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half  
                else
                    r = m - 1;
            }


            Console.WriteLine();
        }

        /// <summary>
        /// this the is part of programm of for doing a insertion sort of string from txt files  
        /// </summary>

        public void insertSort()
        {
            //Reading the string and copying into the string text
            String text = System.IO.File.ReadAllText(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");
            System.Console.WriteLine("Contents of WriteText.txt ");         //ptinting the reading text
            Console.WriteLine(text);
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\admin\Desktop\new folder to scan\deepakkumar.txt");
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", lines);

            string[] words = text.Split(' ');              //spliting the string text into word  




            int i, j;
            String min;
            int len = words.Length; ;
            for (i = 0; i < len; i++)
            {
                min = words[i];
                for (j = 0; j < len; j++)
                {
                    if (words[i].CompareTo(j) > 0)
                    {
                        break;

                    }
                    words[j + 1] = words[j];

                }
                words[j + 1] = min;
            }
            Console.WriteLine("After insertion sorting");
            Console.WriteLine(words);
            Console.WriteLine();
        }

        /// <summary>
        /// Bubble sorting for integer array
        /// </summary>
        /// <param name="arr">array integer array from user</param>
        /// <param name="lenght">array size of integer array from user</param>
        public void bubbleSort(int[] arr, int lenght)
        {
            for (int i = 0; i < lenght - 1; i++)                   //this is part for sorting the string  array
            {
                for (int j = 0; j < lenght - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Your bubble sorted array is ");         //priting sorted array on screen
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        /// <summary>
        /// This is part of program for merge sorting the integer number
        /// </summary>
        /// <param name="arr">taking the integer array from  user</param>
        /// <param name="left">minmum limit of array passing</param>
        /// <param name="right">maximum limit of array passing</param>
        public void mergeSort(int[] arr, int left, int right)
        {

            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                mergeSort(arr, left, mid);                 //Used for dividing the left 
                mergeSort(arr, (mid + 1), right);          //Used for dividing the right
                DoMerge(arr, left, (mid + 1), right);      //Used for merging the sorted array
            }

        }
        /// <summary>
        /// Part of merge sort program for merging a sorted array
        /// </summary>
        /// <param name="numbers">Taking  array of sorted form</param>
        /// <param name="left">minimum limit of array</param>
        /// <param name="mid">midal limit of array</param>
        /// <param name="right">maximum limit of arrayy</param>

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        public void anagramDetection(String str)
        {
            char[] Array = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = Array.Length - 1; i > -1; i--)
            {
                reverse += Array[i];
            }
            Console.WriteLine(reverse);
            Console.WriteLine();
            if (str.Equals(reverse))
            {
                Console.WriteLine("Yes your  string is anagram");
            }
            else
            {
                Console.WriteLine("No your string is not anagram");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public void primenumRange()
        {

            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.Write(i + "\t");
                    count = 0;
                }
            }

            Console.WriteLine();

        }
        /// <summary>
        /// 
        /// </summary>
        public void primenumAnagram()
        {

            ArrayList a = new ArrayList();
            var strings = new ArrayList().Cast<string>().ToArray();

            var theString = string.Join(" ", strings);

            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    //Console.Write(i + "\t");
                    count = 0;
                    for (int k = 0; k < 500; k++)
                    {
                        a[k] = i;
                    }
                    primeWithPalindrom(i);

                }


            }
            primeWithAnagram();



        }

       s

        public void primeWithPalindrom(int num)
        {
            int num1 = num;
            int sum = 0;
            while (num != 0)
            {
                int r = num % 10;
                sum = sum * 10 + r;
                num /= 10;

            }
            if (sum == num1)
            {
                Console.WriteLine(sum);
            }
        }

        public void primeWithAnagram(String arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    String str1 = Integer.toString(arr[i]);
                    String str2 = Integer.toString(arr[j]);

                    char[] c1 = str1.toCharArray();
                    char[] c2 = str2.toCharArray();
                    Arrays.sort(c1);
                    Arrays.sort(c2);
                    if (Arrays.equals(c1, c2))
                    {
                        Console.WriteLine(str1 + " " + str2);
                    }
                }
            }
        }
    

    }
}
