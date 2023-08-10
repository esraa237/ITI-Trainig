using System.Collections;
using System.Reflection;

namespace Employeee
{
    //add the third sort method with delegate and add search class
    public enum Gender { Female, Male, NotMention };

    public class Employee : IComparable
    {
        public string Name { get; set; }
        private int age;
        public Gender G
        {
            set; get;
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
    /// <summary>
    /// sort by Icomparer
    /// </summary>
    public enum SortBy
    {
        ID, Age, Name, Salary
    }
    public class SortASC : IComparer<Employee>
    {
        public SortBy Sort { get; set; }
        public int Compare(Employee emp1, Employee emp2)
        {
            switch (Sort)
            {
                case SortBy.ID:
                    return emp1.ID.CompareTo(emp2.ID);
                    break;
                case SortBy.Age:
                    return emp1.Age.CompareTo(emp2.Age);
                    break;
                case SortBy.Name:
                    return emp1.Name.CompareTo(emp2.Name);
                    break;
                case SortBy.Salary:
                    return emp1.Salary.CompareTo(emp2.Salary);
                    break;
            }
            return 0;

        }
    
    }
    public class SortDEC : IComparer<Employee>
    {
        public SortBy Sort { get; set; }
        public int Compare(Employee emp1, Employee emp2)
        {
            switch (Sort)
            {
                case SortBy.ID:
                    return -1 * (emp1.ID.CompareTo(emp2.ID));
                    break;
                case SortBy.Age:
                    return -1 * (emp1.Age.CompareTo(emp2.Age));
                    break;
                case SortBy.Name:
                    return -1 * (emp1.Name.CompareTo(emp2.Name));
                    break;
                case SortBy.Salary:
                    return -1 * (emp1.Salary.CompareTo(emp2.Salary));
                    break;
            }
            return 0;

        }
    }

   /// <summary>
   /// third method for sorting
   /// </summary>
    public class Comparison
    {
        public static SortBy sort { get; set; }
        public static int Comp_ASC (Employee e1,Employee e2)
        {
            switch (sort)
            {
                case SortBy.ID:
                    return e1.ID.CompareTo(e2.ID);
                    break;
                case SortBy.Age:
                    return e1.Age.CompareTo(e2.Age);
                    break;
                case SortBy.Name:
                    return e1.Name.CompareTo(e2.Name);
                    break;
                case SortBy.Salary:
                    return e1.Salary.CompareTo(e2.Salary);
                    break;
                default: 
                    return -1;
            }

        }
        public static int Comp_DEC(Employee e1, Employee e2)
        {
            switch (sort)
            {
                case SortBy.ID:
                    return -1*(e1.ID.CompareTo(e2.ID));
                    break;
                case SortBy.Age:
                    return -1*(e1.Age.CompareTo(e2.Age));
                    break;
                case SortBy.Name:
                    return -1*(e1.Name.CompareTo(e2.Name));
                    break;
                case SortBy.Salary:
                    return -1*(e1.Salary.CompareTo(e2.Salary));
                    break;
                default:
                    return -1;
            }

        }
    }
    /// <summary>
    /// searching
    /// </summary>
    public delegate bool findEmp(Employee e); 
    public enum SearchWith
    {
        Name,ID,Age,Salary
    }
    public class Search
    {
        public static SearchWith with;
        public static string S_name;
        public static int S_id;
        public static int age1,age2,salary1,salary2;
       

        public static bool Mycompare(Employee e) { 
            switch (with)
            {
                case SearchWith.Name:
                    return e.Name == S_name;
                    break;
                case SearchWith.ID:
                    return e.ID == S_id;
                    break;
                case SearchWith.Age:
                    return (e.Age > age1 && e.Age < age2);
                    break;
                case SearchWith.Salary:
                    return (e.Salary > salary1 && e.Salary < salary2);
                    break;
                default: return false;
            }

        }
        public static List<Employee> Where(List<Employee> ls,findEmp del)
        {
            List<Employee> Res = new List<Employee>();
            foreach (Employee e in ls)
            {
                if (del(e))
                {
                    Res.Add(e);
                }
            }
            return Res;
        }
    }
}