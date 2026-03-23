using System;

class Person
{
   
    public string name;
    public int age;

    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}


class Student : Person
{
    public int marks; 

    public Student(string name, int age, int marks) : base(name, age)
    {
        this.marks = marks;
    }

    public void ShowStudent()
    {
        Console.WriteLine("Student Details:");
        Display();
        Console.WriteLine("Marks: " + marks);
    }
}


class Employee : Person
{
    public double salary; 

    public Employee(string name, int age, double salary) : base(name, age)
    {
        this.salary = salary;
    }

    public void ShowEmployee()
    {
        Console.WriteLine("Employee Details:");
        Display();
        Console.WriteLine("Salary: " + salary);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student s = new Student("Nency", 20, 85);
        Employee e = new Employee("Ishani", 30, 50000);

        s.ShowStudent();
        Console.WriteLine();
        e.ShowEmployee();
    }
}