using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Day9
{
    public delegate bool SortDelegate(int x, int y);
    internal class Program
    {
        static bool SortAsc(int x, int y)
        {
            return x > y;
        }
        static bool SortDec(int x, int y)
        {
            return x < y;
        }
        static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void bubbleSort(int[] arr, SortDelegate d)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (d(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
            static void Main()
            {
                int[] arr = new int[10] { 200, 40, 30, 550, 250, 106, 370, 70, 60, 10 };
                SortDelegate d=SortAsc;
                bubbleSort(arr,d);
                Console.WriteLine("ASC");
                foreach(int e in arr)
                {
                    Console.Write(e+" ");
                }
                d = SortDec;
                bubbleSort(arr, d);
                Console.WriteLine("\nDEC");
                foreach (int e in arr)
                {
                    Console.Write(e+" ");
                }


            }
    }
    
}