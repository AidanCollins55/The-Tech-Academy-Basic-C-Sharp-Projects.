using System;

// Define an abstract class named Person
public abstract class Person
{
    // Properties for first and last names
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName to be implemented by derived classes
    public abstract void SayName();
}