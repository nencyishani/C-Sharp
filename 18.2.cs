using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 20;
            int b = 0;
            int c = a / b;
            Console.WriteLine("Result: " + c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Finally block always executes.");
        }
    }
}
