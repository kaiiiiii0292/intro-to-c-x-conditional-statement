using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose [A] Area, [P] Perimeter, [X] Exit: ");
        char choice = char.ToUpper(Console.ReadLine()[0]);

        switch (choice)
        {
            case 'A':
                Console.WriteLine($"Area: {Math.PI * r * r:F2}");
                break;
            case 'P':
                Console.WriteLine($"Perimeter: {2 * Math.PI * r:F2}");
                break;
            case 'X':
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}