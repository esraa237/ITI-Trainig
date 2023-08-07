
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day3_iti
{
    enum Gender { Female, Male ,NotMention };
    struct Employee
    {
        public string Name;
        public int ID;
        public int Salary;
        public Gender g;
        public void display(int i)
        {
            Console.WriteLine("The Name of Employee"+(i+1)+": " +Name+ "\nThe ID : " +ID  + "\nThe Salary : " + Salary);
            Console.WriteLine("Gender: " +g);
            Console.ReadKey();
        }
    }
    internal class Program
    {   
        public static Employee[] add(ref int n)
        {
            Console.WriteLine("Enter the number of employees : ");
            n = int.Parse(Console.ReadLine());
            Employee[] emp1=new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Name of Employee"+(1+i)+": ");
                emp1[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the ID : ");
                emp1[i].ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Salary: ");
                emp1[i].Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter (F // M) ....F for female ,M for male : ");
                string gender = Console.ReadLine();
                if (gender == "F" || gender == "f") emp1[i].g = Gender.Female;
                else if (gender == "M" || gender == "m") emp1[i].g = Gender.Male;
                else emp1[i].g = Gender.NotMention;
            }
                return emp1;
        }
        
        static void Main(string[] args)
        {
            Employee[] emp2=new Employee[0];
            int numOfEmp=0;
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
        
            do {
                Console.ResetColor();
                Console.Clear();
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(x, Console.WindowHeight - 2);
                    Console.WriteLine("*");
                }
                for (int y = 0; y < Console.WindowHeight-2; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("*");
                    Console.SetCursorPosition(Console.WindowWidth-1, y);
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
                        if (highlight < 0) highlight = menu.Length-1;
                        break;
                    case ConsoleKey.DownArrow:
                        highlight++;
                        if(highlight == menu.Length) highlight = 0;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    case ConsoleKey.Home:
                        highlight=0;
                        break;
                    case ConsoleKey.End:
                        highlight=menu.Length-1;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0:
                                emp2=add(ref numOfEmp);
                                break;
                            case 1:
                                Console.WriteLine("------------There Are " + numOfEmp + " Employees------------");
                                for (int i = 0; i < numOfEmp; i++)
                                {
                                    emp2[i].display(i);
                                }
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
