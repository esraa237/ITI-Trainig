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
            //task2 :simple calculator

            double x, y;
            Console.WriteLine("Write the First number : ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the Second number : ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the operator {+,-,*,/} ");
            char op = char.Parse(Console.ReadLine());
            if (op == '+') Console.WriteLine("SUM : " + (x + y));
            else if (op == '-') Console.WriteLine("Sub : " + (x - y));
            else if (op == '*') Console.WriteLine("MULti : " + (x * y));
            else if (op == '/') Console.WriteLine("DEV : " + (x / y));
            else Console.WriteLine("invalid operator");
            Console.ReadKey();
        }
    }
}