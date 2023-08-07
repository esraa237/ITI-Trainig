using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degree_of_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sum = new int[3];
            int[] s_sum =new int[4];
            int[,] arr = new int[3, 4];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Enter the 4 subject`s degree for student " + (i+1) + ": ");
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    sum[i] += arr[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s_sum[i] += arr[j,i];
                }
            }

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("The sum of degrees for student " + (i+1) +" : " + sum[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("The Average of degrees for subject " + (i+1) + " : " + (s_sum[i]/3));
            }
            Console.ReadKey();
        }
    }
}
