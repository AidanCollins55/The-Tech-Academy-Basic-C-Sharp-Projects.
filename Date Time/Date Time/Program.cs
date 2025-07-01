using System;

class Program
{
    static void Main()
    {
        // Get the current date and time from the system
        DateTime currentDateTime = DateTime.Now;

        // Print the current date and time to the console
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // Ask the user to input a number of hours to add
        Console.Write("\nEnter a number of hours to add: ");
        string userInput = Console.ReadLine(); // Read user input as a string

        // Convert the user input to an integer (assuming valid numeric input)
        int hoursToAdd = int.Parse(userInput);

        // Calculate the future time by adding the specified number of hours
        DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);

        // Print the calculated future date and time to the console
        Console.WriteLine("\nThe time in " + hoursToAdd + " hour(s) will be: " + futureDateTime);
    }
}