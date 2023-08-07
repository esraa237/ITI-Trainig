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

        {    //task3: box magix

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
