using System;

namespace DayOfWeekApp
{
    // Define an enum to represent the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.Write("Enter the current day of the week: ");
            string userInput = Console.ReadLine();

            try
            {
                // Try to parse the user input to the DaysOfWeek enum
                // The second parameter (true) allows case-insensitive parsing
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Display the parsed day
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (Exception)
            {
                // If parsing fails, display a custom error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open until the user presses a key
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
