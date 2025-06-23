using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine(); // Blank line for readability

        // ===== GET PACKAGE WEIGHT =====
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // If weight is over 50, reject the package
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // ===== GET PACKAGE DIMENSIONS =====
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if dimensions are too large (sum > 50)
        double dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program
        }

        // ===== CALCULATE SHIPPING QUOTE =====
        // Formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you.");
    }
}