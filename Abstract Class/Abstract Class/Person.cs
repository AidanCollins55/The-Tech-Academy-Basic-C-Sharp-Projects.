using System;

// Define an abstract class named Person
public abstract class Person
{
    // Property to hold the first name
    public string FirstName { get; set; }

    // Property to hold the last name
    public string LastName { get; set; }

    // Declare an abstract method named SayName
    // This method must be implemented by any class that inherits from Person
    public abstract void SayName();
}