using System;

// Define a class named Employee that inherits from the abstract class Person
public class Employee : Person
{
    // Implement the abstract method SayName
    public override void SayName()
    {
        // Output the full name to the console in the required format
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}