using System.Collections;
using System.Reflection;

namespace Employeelib
{
    //add sort array of class with Icomparable interface and compareTo method
    public enum Gender { Female, Male, NotMention };

    public class Employee :IComparable
    {
        public string Name { get; set; }
        private int age;
        public Gender G
        {
            set;get;
        }
        private static int counter = 1;
        public int ID;
        public int Salary;
        public int Age
        {
            set
            {
                if (value >= 18 && value < 60) age = value;
                else age = 0;
            }
            get
            {
                return age;
            }
        }
        public Employee(string name, int salary, int age, string gender)
        {
            Name = name;
            Age = age;
            if (gender == "F" || gender == "f") G = Gender.Female;
            else if (gender == "M" || gender == "m") G = Gender.Male;
            else G = Gender.NotMention;
            ID = counter++;
            Salary = salary;
        }

       

        public override string ToString()
        {
            return $"ID:{ID}\nName:{Name}\nGender:{G}\nAge:{Age}\nSalary:{Salary}\n---------------------------------------\n";
        }
        
        public int CompareTo(object? obj)
        {
           return this.Name.CompareTo((obj as Employee).Name);
           
        }
    }
}