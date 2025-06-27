using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class to access its methods
        MathOperations mathOps = new MathOperations();

        // Ask the user to input a number
        Console.WriteLine("Enter a number to perform math operations on:");

        // Read the user input from the console and convert it to an integer
        string userInput = Console.ReadLine();
        int number;

        // Validate the input to ensure it's a valid integer
        if (int.TryParse(userInput, out number))
        {
            // Call the AddTen method and store the result
            int result1 = mathOps.AddTen(number);
            Console.WriteLine($"After adding 10: {result1}");

            // Call the MultiplyByTwo method and store the result
            int result2 = mathOps.MultiplyByTwo(number);
            Console.WriteLine($"After multiplying by 2: {result2}");

            // Call the SubtractFive method and store the result
            int result3 = mathOps.SubtractFive(number);
            Console.WriteLine($"After subtracting 5: {result3}");
        }
        else
        {
            // Notify the user if input is not a valid number
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}