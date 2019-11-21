namespace Algorithm_Programs
{
    using System;

    /// <summary>
    /// Program of Algorithm.
    /// </summary>
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
                    Console.WriteLine("1:  Permutations of string  ");
                    Console.WriteLine("2:  Binary Search the Word from Word List ");
                    Console.WriteLine("3:  Insertion Sort   ");
                    Console.WriteLine("4:  Bubble Sort ");
                    Console.WriteLine("5:  Merge Sort  ");
                    Console.WriteLine("6:  An Anagram Detection Example ");
                    Console.WriteLine("7:  Prime numbers range ");
                    Console.WriteLine("8:  Prime numbers range anagram ");
                    Console.WriteLine("9:  Rewrite Use Generics for Search and Sort Algorithms ");
                    Console.WriteLine("10: Question to find your number ");
                    Console.WriteLine("11: Completion time overshoots ");
                    Console.WriteLine("12: Message Demonstration using String Function and RegEx ");
                    Console.WriteLine("13: PRESS 13 TO EXIT");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Permutaionofstring permu = new Permutaionofstring();
                            permu.PermutaionofString();

                            break;

                        case 2:
                            BinarysearchwordList binarysear = new BinarysearchwordList();
                            binarysear.binarySearchwordList();

                            break;

                        case 3:
                            Insertionsortstring insersort = new Insertionsortstring();
                            insersort.insertionSortstring();
                            break;

                        case 4:
                            Bubblesort bubblesort = new Bubblesort();
                            bubblesort.bubbleSort();
                            break;

                        case 5:
                            Mergesort mergee = new Mergesort();
                            mergee.mergeSort();
                            break;

                        case 6:
                            Anagramdetection anagram = new Anagramdetection();
                            anagram.anagramDetection();
                            break;

                        case 7:
                            Primenumrange prinum = new Primenumrange();
                            prinum.primenumRange();
                            break;

                        case 8:
                            Primepalindrom primeanagram = new Primepalindrom();
                            primeanagram.primenumRangeanagram();
                            break;

                        case 9:
                            Searchsort ss = new Searchsort();
                            ss.SearchSort();
                            break;

                        case 10:
                            flag = false;
                            break;

                        case 11:
                            flag = false;
                            break;

                        case 12:
                            flag = false;
                            break;

                        case 13:
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
