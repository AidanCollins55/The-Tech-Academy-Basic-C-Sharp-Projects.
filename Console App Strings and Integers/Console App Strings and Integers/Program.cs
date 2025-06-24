using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers to be divided
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user to enter a number to divide each list element by
        Console.Write("Enter a number to divide each number in the list by: ");
        string userInput = Console.ReadLine(); // Read input from the user

        try
        {
            // Try to parse the input string into an integer
            int divisor = int.Parse(userInput);

            // Loop through each number in the list
            foreach (int num in numbers)
            {
                // Perform the division and display the result
                int result = num / divisor;
                Console.WriteLine($"{num} divided by {divisor} is {result}");
            }
        }
        catch (DivideByZeroException dbze)
        {
            // Handle the specific case when dividing by zero
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine("Detailed error message: " + dbze.Message);
        }
        catch (FormatException fe)
        {
            // Handle the case where the input is not a valid integer (e.g. user entered a string)
            Console.WriteLine("Error: You must enter a numeric value.");
            Console.WriteLine("Detailed error message: " + fe.Message);
        }
        catch (Exception e)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Detailed error message: " + e.Message);
        }

        // This message will print regardless of whether an error occurred
        Console.WriteLine("Program has exited the try/catch block and continued execution.");

        // Wait for the user to press a key before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
