
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EmployeeL;



namespace Day5
{
    static public class Extension
    {
        public static void displayArr(this Employee[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("no employees");
                Console.ReadKey();
                return;
            }
            foreach (Employee e in arr)
            {
                e.DisplayData();
            }
        }
    }
    internal class Program
    {
        public static void add(ref int n, ref Employee[] emp1)
        {
            Console.WriteLine("Enter the number of employees : ");
            n = int.Parse(Console.ReadLine());
            emp1 = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Name of Employee" + (1 + i) + ": ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Salary: ");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter (F // M) ....F for female ,M for male : ");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter the Age: ");
                int age = int.Parse(Console.ReadLine());
                emp1[i] = new Employee(name, salary, age, gender);
            }
        }

        static void Main(string[] args)
        {
            int numOfEmp = 0;
            Employee[] emp2 = new Employee[numOfEmp];
            bool flag = true;
            int highlight = 0;
            string[] menu = new string[]
            {
                "  New  ",
                "Display",
                " Exit  "
            };
            int xDistance = Console.WindowWidth / 2;
            int yDistance = Console.WindowHeight / (menu.Length + 1);

            do
            {
                Console.ResetColor();
                Console.Clear();
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(x, Console.WindowHeight - 2);
                    Console.WriteLine("*");
                }
                for (int y = 0; y < Console.WindowHeight - 2; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(Console.WindowWidth - 1, y);
                    Console.WriteLine("*");
                }

                for (int i = 0; i < menu.Length; i++)
                {

                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(xDistance, (i + 1) * yDistance);
                    Console.WriteLine(menu[i]);

                }
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        highlight--;
                        if (highlight < 0) highlight = menu.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight++;
                        if (highlight == menu.Length) highlight = 0;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    case ConsoleKey.Home:
                        highlight = 0;
                        break;
                    case ConsoleKey.End:
                        highlight = menu.Length - 1;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                add(ref numOfEmp, ref emp2);
                                break;
                            case 1:
                                Console.WriteLine("------------There Are " + numOfEmp + " Employees------------");
                                emp2.displayArr();
                                Console.ReadKey();
                                break;
                            case 2:
                                flag = false;
                                break;
                        }
                        break;

                }

            } while (flag);


        }
    }
}
