
using System;

// Employee class inherits from Person and implements the IQuittable interface
public class Employee : Person, IQuittable
{
    // Override the SayName method inherited from Person
    public override void SayName()
    {
        // Display the full name of the employee
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Custom logic for quitting – this can be anything
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}