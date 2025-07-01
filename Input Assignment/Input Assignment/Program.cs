using System;
using System.IO; // Needed for file operations

class Program
{
    static void Main()
    {
        // Define the path and name of the text file
        string filePath = "NumberLog.txt";

        // Prompt the user to enter a number
        Console.Write("Please enter a number: ");
        string userInput = Console.ReadLine(); // Read input as a string

        // Append the input to the text file
        // StreamWriter is used to write text to the file
        // 'true' parameter enables append mode so that existing data is not overwritten
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(userInput); // Write the input followed by a newline
        }

        // Inform the user that the number has been logged
        Console.WriteLine("\nNumber has been logged to the file.\n");

        // Read all contents of the file and print them
        // File.ReadAllText reads the entire content of the file as a single string
        string fileContents = File.ReadAllText(filePath);

        // Display the contents to the user
        Console.WriteLine("Contents of the log file:");
        Console.WriteLine(fileContents);
    }
}
