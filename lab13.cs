using System;

class Rectangle
{
    double length, width;

    
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length + " Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10, 5);

        r1.Display();
        r2.Display();
    }
}
