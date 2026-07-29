using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle: " + area);

    }
}