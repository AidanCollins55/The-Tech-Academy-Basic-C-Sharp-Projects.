using System;

namespace AgeToBirthYearApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome! Let's calculate your birth year.");

            // Ask the user to input their age
            Console.Write("Please enter your age: ");

            try
            {
                // Read the input from the user
                string input = Console.ReadLine();

                // Try converting the input string to an integer
                int age = int.Parse(input);

                // Check if the entered age is less than or equal to zero
                if (age <= 0)
                {
                    // Display a custom error message for invalid age
                    Console.WriteLine("Age must be a positive number greater than zero.");
                }
                else
                {
                    // Get the current year
                    int currentYear = DateTime.Now.Year;

                    // Calculate the birth year
                    int birthYear = currentYear - age;

                    // Display the result
                    Console.WriteLine($"You were likely born in {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // Handle the case where input is not a number
                Console.WriteLine("Invalid input. Please enter a numeric value for your age.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            // Pause the program before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
