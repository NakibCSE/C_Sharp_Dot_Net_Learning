public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName +" " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee 
{
    public float HourlyRate;
}

public class A : PartTimeEmployee
{
    
}

public class Program
{
    public static void Main(string[] args)
    {
        FullTimeEmployee employee = new FullTimeEmployee();
        employee.FirstName = "Nakib";
        employee.LastName = "Khan";
        employee.YearlySalary = 1000000;
        employee.PrintFullName();

        PartTimeEmployee employee1 = new PartTimeEmployee();
        employee1.FirstName = "Riaz";
        employee1.LastName = "Uddin";
        employee1.HourlyRate = 10;
        employee1.PrintFullName();

        A a1 = new A();
        a1.PrintFullName();
    }
}