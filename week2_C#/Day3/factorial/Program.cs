using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static int fact(int num)
        {
            int res;
            if (num == 0) return 1;
            res = num * fact(num - 1);
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial: "+ fact(num));
            Console.ReadKey();
        }
    }
}
