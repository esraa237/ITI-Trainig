namespace EmployeeLibrary
{
    public enum Gender { Female, Male, NotMention };
    public class Human
    {
        public string Name { get; set; }
        private int age;

        private Gender g;
        public Gender G
        {
            set { g = value; }
            get { return g; }
        }
        public int Age
        {
            set
            {
                if (value >= 18 && value < 60) age = value;
                else age=0;
            }
            get
            {
                return age;
            }
        }
        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            if (gender == "F" || gender == "f") G = Gender.Female;
            else if (gender == "M" || gender == "m") G = Gender.Male;
            else G = Gender.NotMention;
        }


        public override string ToString()
        {
            return $"Name:{Name}\nAge:{age}\nGender:{G}\n";
        }
    }
    public class Employee : Human
    {
        private static int counter = 1;
        public int ID;
        public int Salary;
        public Employee(string name, int salary, int ag, string gen) : base(name, ag, gen)
        {
            ID = counter++;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ID:{ID}\nName:{Name}\nGender:{G}\nAge:{Age}\nSalary:{Salary}\n---------------------------------------\n";
        }
    }
}