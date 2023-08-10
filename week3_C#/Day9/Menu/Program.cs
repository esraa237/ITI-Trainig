
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Employeee;


//ADD the Sort Method
namespace Day9
{
    static public class Extension
    {
        //public static void displayArr(this Employee[] arr)
        //{

        //    if (arr.Length == 0)
        //    {
        //        Console.WriteLine("no employees");
        //        Console.ReadKey();
        //        return;
        //    }
        //    foreach (Employee e in arr)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
        public static void displaylist(this List<Employee> ls)
        {
            foreach (Employee e in ls)
            {
                Console.WriteLine(e);
            }
        }
    }
    internal class Program
    {
        
        public static void add(ref int n, ref List<Employee> emp2)
        {
            Console.WriteLine("Enter the number of employees : ");
            n = int.Parse(Console.ReadLine());
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
                emp2.Add(new Employee(name, salary, age, gender));
            }
        }

        static void Main(string[] args)
        {
            int numOfEmp = 0;
            //Employee[] emp2 = new Employee[numOfEmp];
            List<Employee> emp3 = new List<Employee>();
            bool flag = true;
            int highlight = 0;
            string[] menu = new string[]
            {
                "  New  ",
                "Display",
                " Sort  ",
                "Search ",
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
                            case 0://new
                                add(ref numOfEmp, ref emp3);
                                break;
                            case 1://display
                                Console.WriteLine("------------There Are " + numOfEmp + " Employees------------");
                                emp3.displaylist();
                                Console.ReadKey();
                                break;
                            case 2://sort
                                Console.WriteLine("Enter 1-->for the first method(comparer) \n2-->for the second method(Comparision)");
                                int choice1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Choose the type of sort\n 1 --> for ASC \n 2 --> for DEC\n Your choice: ");
                                int choice = int.Parse(Console.ReadLine());
                                Console.WriteLine("1--> SortBy ID\n2--> SortBy Name\n3--> SortBy Age\n4--> SortBy Salary");
                                int sortby = int.Parse(Console.ReadLine());
                                switch (choice1)
                                {
                                    case 1://1.comparer
                                        switch (choice)
                                        {
                                            case 2:
                                                SortDEC Dec = new SortDEC();
                                                switch (sortby)
                                                {
                                                    case 1:
                                                        Dec.Sort = SortBy.ID;
                                                        break;
                                                    case 2:
                                                        Dec.Sort = SortBy.Name;
                                                        break;
                                                    case 3:
                                                        Dec.Sort = SortBy.Age;
                                                        break;
                                                    case 4:
                                                        Dec.Sort = SortBy.Salary;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Sort failed");
                                                        break;
                                                }
                                                emp3.Sort(Dec);
                                                Console.WriteLine("Sort Done");
                                                Console.ReadKey();
                                                break;
                                            case 1:
                                                SortASC Asc = new SortASC();
                                                switch (sortby)
                                                {
                                                    case 1:
                                                        Asc.Sort = SortBy.ID;
                                                        break;
                                                    case 2:
                                                        Asc.Sort = SortBy.Name;
                                                        break;
                                                    case 3:
                                                        Asc.Sort = SortBy.Age;
                                                        break;
                                                    case 4:
                                                        Asc.Sort = SortBy.Salary;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Sort failed");
                                                        break;

                                                        emp3.Sort(Asc);
                                                        Console.WriteLine("Sort Done");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case 2://2.comparison
                                        Comparison<Employee> com;
                                        switch (sortby)
                                        {
                                            case 1:
                                                Comparison.sort = SortBy.ID;
                                                break;
                                            case 2:
                                                Comparison.sort = SortBy.Name;
                                                break;
                                            case 3:
                                                Comparison.sort = SortBy.Age;
                                                break;
                                            case 4:
                                                Comparison.sort = SortBy.Salary;
                                                break;
                                            default:
                                                Console.WriteLine("Sort failed");
                                                break;
                                        }
                                        switch (choice)
                                        {
                                            case 1:
                                                com = Comparison.Comp_ASC;
                                                emp3.Sort(com);
                                                Console.WriteLine("Sort Done");
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                com = Comparison.Comp_DEC;
                                                emp3.Sort(com);
                                                Console.WriteLine("Sort Done");
                                                Console.ReadKey();
                                                break;
                                        }
                                        break;
                                }
                                break;
                            case 3://search
                                Console.WriteLine("1--> Search With ID\n2--> Search With Name\n3--> Search With Age\n4--> Search With Salary");
                                int searchWith = int.Parse(Console.ReadLine());
                                switch (searchWith)
                                {
                                    case 2:
                                        Console.WriteLine("Enter Name :");
                                        Search.S_name = Console.ReadLine();
                                        Search.with = SearchWith.Name;
                                        break;
                                    case 1:
                                        Console.WriteLine("Enter ID :");
                                        Search.S_id = int.Parse(Console.ReadLine());
                                        Search.with = SearchWith.ID;
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter two ages that you want to search between them \n( repect the order):");
                                        Search.age1 = int.Parse(Console.ReadLine());
                                        Search.age2 = int.Parse(Console.ReadLine());
                                        Search.with = SearchWith.Age;
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter two Salaries that you want to search between them \n( repect the order):");
                                        Search.salary1 = int.Parse(Console.ReadLine());
                                        Search.salary2 = int.Parse(Console.ReadLine());
                                        Search.with = SearchWith.Salary;
                                        break;
                                }
                                List<Employee> result = Search.Where(emp3, Search.Mycompare);
                                result.displaylist();
                                Console.ReadKey();
                                break;
                            case 4://exit
                                flag = false;
                                break;
                        }
                        break;

                }

            } while (flag);


        }
    }
}
