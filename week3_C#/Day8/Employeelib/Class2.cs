using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{ //class for sorting list of refrences with Icomparer interface
    public enum SortBy
    {
        ID,Age,Name,Salary
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
        public class SortDEC : IComparer<Employee>
        {
            public SortBy Sort { get; set; }
            public int Compare(Employee emp1, Employee emp2)
            {
                switch (Sort)
                {
                    case SortBy.ID:
                        return -1*(emp1.ID.CompareTo(emp2.ID));
                        break;
                    case SortBy.Age:
                        return -1*(emp1.Age.CompareTo(emp2.Age));
                        break;
                    case SortBy.Name:
                        return -1*(emp1.Name.CompareTo(emp2.Name));
                        break;
                    case SortBy.Salary:
                        return -1*(emp1.Salary.CompareTo(emp2.Salary));
                        break;
                }
                return 0;

            }
        }
    }
}
