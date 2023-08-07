namespace EmployeeL;

public enum Gender { Female, Male, NotMention };
public class Employee
{
    public string Name;
    public int ID;
    private static int counter = 1;
    public int Salary;
    private int age;
    private readonly Gender g;


    public Employee(string name, int salary, int age, string gender)
    {
        ID = counter++;
        Name = name;
        Salary = salary;
        this.age = age;
        if (gender == "F" || gender == "f") g = Gender.Female;
        else if (gender == "M" || gender == "m") g = Gender.Male;
        else g = Gender.NotMention;

    }
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
    public void DisplayData()
    {
        Console.WriteLine("\nThe ID: " + ID + "\nThe Name of Employe: " + Name + "\nThe Salary : " + Salary);
        Console.WriteLine("Gender: " + g + "\nAge: " + age);

    }


}