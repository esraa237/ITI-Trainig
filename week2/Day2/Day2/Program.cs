using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operations with array
            Console.WriteLine("Enter the number of numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers: ");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            int min = arr[0], max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (min > arr[i]) min = arr[i];
                if (max < arr[i]) max = arr[i];
            }
            Console.WriteLine("SUM: " + sum + " , AVG: " + sum / n + " , Min: " + min + " , Max: " + max);
            Console.ReadKey();
        }
    }
}