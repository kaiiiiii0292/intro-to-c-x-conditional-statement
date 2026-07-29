using System;

class Program
{
    static void Main()
    {
        int score = 75; // You can change this test value

        string result = (score >= 50) ? "Passed" : "Failed";
        Console.WriteLine(result);
    }
}