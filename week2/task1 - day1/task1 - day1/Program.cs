using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1___day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1

            //int x, y;
            //Console.WriteLine("Write the First number : ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write the Second number : ");
            //y = int.Parse(Console.ReadLine());
            //if (x > y) Console.WriteLine("Max num : " + x);
            //else if (x < y) Console.WriteLine("Max num : " + y);
            //else Console.WriteLine("The two numbers are equal.");
            //Console.ReadKey();

            //task2

            //int x, y;
            //Console.WriteLine("Write the First number : ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write the Second number : ");
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine("SUM : " + (x + y));
            //Console.WriteLine("AVG : " + (x + y) / 2);
            //Console.ReadKey();

            //task3

            //int x, y;
            //Console.WriteLine("Write the First number : ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write the Second number : ");
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Choose the operation : ");
            //Console.WriteLine("Write 1 for the sum. \nWrite 2 for getting the max num . \nWrite 3 for getting min num. ");
            //int mode = int.Parse(Console.ReadLine());
            //if (mode == 1)
            //{
            //    Console.WriteLine("SUM : "+ (x + y));
            //}
            //else if (mode == 2)
            //{
            //    if (x > y) Console.WriteLine("Max num : " + x);
            //    else if (x < y) Console.WriteLine("Max num : " + y);
            //    else Console.WriteLine("The two numbers are equal.");
            //}
            //else if(mode == 3)
            //{
            //    if (x > y) Console.WriteLine("Min num : " + y);
            //    else if (x < y) Console.WriteLine("Min num : " + x);
            //    else Console.WriteLine("The two numbers are equal.");
            //}
            //Console.ReadKey();

            //task4

            //double x, y;
            //Console.WriteLine("Write the First number : ");
            //x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Write the Second number : ");
            //y = double.Parse(Console.ReadLine());
            //Console.WriteLine("Choose the operator {+,-,*,/} ");
            //char op = char.Parse(Console.ReadLine());
            //if (op == '+') Console.WriteLine("SUM : " + (x + y));
            //else if (op == '-') Console.WriteLine("Sub : " + (x - y));
            //else if (op == '*') Console.WriteLine("MULti : " + (x * y));
            //else if (op == '/') Console.WriteLine("DEV : " + (x / y));
            //else Console.WriteLine("invalid operator");
            //Console.ReadKey();

            //task5

            int col, row = 1;
            Console.WriteLine("Enter the odd size of the box: ");
            int size = int.Parse(Console.ReadLine());
            if (size % 2 == 0) Console.WriteLine("the size must be odd");
            else
            {
                col = size / 2 + 1;
                int colDistance = Console.WindowWidth / (size + 1);
                int rowDistance = Console.WindowHeight / (size + 1);
                for (int i = 1; i <= size * size; i++)
                {
                    Console.SetCursorPosition(col * colDistance, row * rowDistance);
                    Console.WriteLine(i);
                    if (i % size == 0)
                    {
                        row++;
                        if (row > size)
                        {
                            row = 1;
                        }
                    }
                    else
                    {
                        col--;
                        if (col < 1)
                        {
                            col = size;
                        }
                        row--;
                        if (row < 1)
                        {
                            row = size;
                        }
                    }

                }
            }
            Console.ReadKey();

        }
    }
}
