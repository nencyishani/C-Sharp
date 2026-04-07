using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;   // This will cause an error
            Console.WriteLine("Result: " + c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }

        Console.WriteLine("Program continues...");
    }
}
