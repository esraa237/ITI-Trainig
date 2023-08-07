using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1: find max,average and sum of two numbers
            int x, y;
            Console.WriteLine("Write the First number : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the Second number : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("SUM : " + (x + y));
            Console.WriteLine("AVG : " + (x + y) / 2);
            if (x > y) Console.WriteLine("Max num : " + x);
            else if (x < y) Console.WriteLine("Max num : " + y);
            else Console.WriteLine("The two numbers are equal.");
            Console.ReadKey();
        }
    }
}
