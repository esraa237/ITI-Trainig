using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    struct complex
    {
        public float real;
        public float img;
        public void display()
        {
            Console.WriteLine("Real: " + real + " ,Img: " + img);
        }

    }
    internal class Program
    {
        public static complex AddComplex(complex c1, complex c2)
        {
            complex c3;
            c3.real = c1.real + c2.real;
            c3.img = c1.img + c2.img;
            Console.WriteLine("-------ADD-------");
            return c3;
        }
        public static complex SubComplex(complex c1, complex c2)
        {
            complex c3;
            c3.real = c1.real - c2.real;
            c3.img = c1.img - c2.img;
            Console.WriteLine("---SUBSTRACTION---");
            return c3;
        }
        static void Main(string[] args)
        {
            complex c1;
            Console.WriteLine("Enter the real and imaginary of the complex num1: ");
            c1.real = float.Parse(Console.ReadLine());
            c1.img = float.Parse(Console.ReadLine());
            complex c2;
            Console.WriteLine("Enter the real and imaginary of the complex num2: ");
            c2.real = float.Parse(Console.ReadLine());
            c2.img = float.Parse(Console.ReadLine());
            complex c3 = AddComplex(c1, c2);
            c3.display();
            complex c4 = SubComplex(c1, c2);
            c4.display();
            Console.ReadKey();
        }
    }
}
