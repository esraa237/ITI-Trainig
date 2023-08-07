using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day7
{
    public enum Gender { Female, Male, NotMention };

    public class Human
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Gender g;
        public Gender G
        {
            init; get;
        }
        public Human(string name, int age, string gender)
        {
            Name = name;
            this.age = age;
            if (gender == "F" || gender == "f") g = Gender.Female;
            else if (gender == "M" || gender == "m") g = Gender.Male;
            else g = Gender.NotMention;
        }


        public override string ToString()
        {
            return $"Name:{Name}\nAge:{age}\nGender:{g}\n";
        }
    }
    public class Employee : Human
    {
        public int ID;
        public int Salary;
        public Employee(int iD, int salary,string name,int a,string gen) :base(name,a,gen)
        {
            ID = iD;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nID:{ID}\nGender:{G}\nAge:{age}\nSalary:{Salary}\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Ahmed",20,"m");
            Console.WriteLine(h);
            Console.WriteLine("*************************");
            Human e = new Employee(1, 3000, "Esraa", 30, "f");
            Console.WriteLine(e);
        }
    }
}
