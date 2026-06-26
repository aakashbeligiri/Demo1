using System;

class Subtraction
{
    static double Subtract(double a, double b) => a - b;

    static void Main()
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out var x))
        {
            Console.WriteLine("Invalid input."); return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out var y))
        {
            Console.WriteLine("Invalid input."); return;
        }

        Console.WriteLine($"Result: {Subtract(x, y)}");
    }
}
