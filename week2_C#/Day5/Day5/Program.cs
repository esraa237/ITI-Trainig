using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of numbers");
            int n=int.Parse(Console.ReadLine());
            myStack myStack = new myStack(n);
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                myStack.push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("the numbers in the stack are: ");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine("the num "+(i+1) +" : "+ myStack.pop());
            }
            Console.ReadKey();
        }
    }
}
