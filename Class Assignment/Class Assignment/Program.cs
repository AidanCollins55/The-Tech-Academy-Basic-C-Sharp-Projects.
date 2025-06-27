using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.Write("Please enter an integer: ");
        string userInput = Console.ReadLine(); // Read input as string

        // Try to convert input to integer
        if (int.TryParse(userInput, out int userNumber))
        {
            // Call the DivideByTwo method with integer input
            MathHandler.DivideByTwo(userNumber); // Uses void method that prints result

            // Call the method with an output parameter
            MathHandler.MultiplyByFive(userNumber, out int multipliedResult);
            Console.WriteLine($"{userNumber} multiplied by 5 is: {multipliedResult}");

            // Demonstrate method overload using a double
            double userDouble = (double)userNumber + 0.5;
            MathHandler.DivideByTwo(userDouble); // Calls overloaded method
        }
        else
        {
            // Display an error message if input is invalid
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
