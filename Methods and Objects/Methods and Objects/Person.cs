using System;

// Define the Person class
public class Person
{
    // Property to hold the first name
    public string FirstName { get; set; }

    // Property to hold the last name
    public string LastName { get; set; }

    // Method to output the full name to the console
    public void SayName()
    {
        // Combines first and last name and prints to the console
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}
