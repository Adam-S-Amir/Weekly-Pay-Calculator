using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nAdam $ Amir\n");
        Console.Write("What's your name: ");
        string? name = Console.ReadLine();
        Console.Write("Gimme your annual salary: $");
        if (double.TryParse(Console.ReadLine(), out double annualSalary))
        {
            double weeklyPay = annualSalary / 52;
            Console.WriteLine($"What's good, {name}? Your weekly pay is probably sum like: ${weeklyPay:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
