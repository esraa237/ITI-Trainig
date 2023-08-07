using System;

namespace EmployeeLibrary 
{
    enum Gender { Female, Male, NotMention };
    public class Employee
    {
        public string Name;
        public int ID;
        public int Salary;
        private Gender g;
        public Gender G{ init; get; }
        public Employee(string name, int id, int salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }
        public int Age { get; set; }
        public DisplayData(int i)
        {
            Console.WriteLine("The Name of Employee" + (i + 1) + ": " + Name + "\nThe ID : " + ID + "\nThe Salary : " + Salary);
            Console.WriteLine("Gender: " + g);
            Console.ReadKey();
        }


    }

}
    

