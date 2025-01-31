using System;

public class Employee
{
    private string name;
    private int id;
    private double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

public class EmployeeDetails
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee("John Doe", 101, 50000);
        emp.DisplayDetails();
    }
}
