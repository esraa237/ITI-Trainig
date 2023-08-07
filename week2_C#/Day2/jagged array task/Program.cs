using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of classes :");
            int n=int.Parse(Console.ReadLine());

            int[][] jarr=new int[n][];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("How many students in class " + (i + 1));
                int z = int.Parse(Console.ReadLine());

                jarr[i] = new int[z];

                for (int j = 0; j < z; j++)
                {
                    Console.WriteLine("What is the degree of student " + (j+1) + ":");
                    jarr[i][j] = int.Parse(Console.ReadLine());
                }
            }
             int[]sum=new int[jarr.Length];
            for (int x = 0; x< jarr.Length; x++)
            {
                for(int y = 0; y < jarr[x].Length; y++)
                {
                    sum[x] +=jarr[x][y];
                }
            }
            for (int w = 0; w < jarr.Length; w++)
            {
                Console.WriteLine("sum of degrees of class " + (w + 1) + " : " + sum[w] );
                Console.WriteLine("average of degrees of class " + (w+ 1) + " : " + sum[w]/jarr[w].Length);
            }
            Console.ReadKey();

        }
    }
}
