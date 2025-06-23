using System;

class Program
{
    static void Main()
    {
        // Print headers
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");
        Console.WriteLine(); // Add a blank line for better readability

        // Ask and store information
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do you need help with anything? Please answer “true” or “false.” ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Were there any positive experiences you’d like to share? Please give specifics. ");
        string positiveExperiences = Console.ReadLine();

        Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
        string additionalFeedback = Console.ReadLine();

        Console.Write("How many hours did you study today? ");
        double hoursStudied = Convert.ToDouble(Console.ReadLine());

        // Closing message
        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}
