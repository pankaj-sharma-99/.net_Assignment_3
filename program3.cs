using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return 3.14 * radius * radius;
    }
}

class Rectangle : Shape
{
    double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(10, 4);

        Console.WriteLine("Circle Area: " +
                          circle.CalculateArea());

        Console.WriteLine("Rectangle Area: " +
                          rectangle.CalculateArea());
    }
}
