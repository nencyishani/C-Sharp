using System;

class Employee
{
    int employeeId;
    string name;
    int salary;

    
    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0;
    }

    
    public Employee(int id, string n, int s)
    {
        employeeId = id;
        name = n;
        salary = s;
    }

   
    public int CalculateAnnualSalary()
    {
        return salary * 12;
    }

    
    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }

    static void Main()
    {
        Employee e1 = new Employee(101, "Nency", 20000);
        e1.Display();
    }
}