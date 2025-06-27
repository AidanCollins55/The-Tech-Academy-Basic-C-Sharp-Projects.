using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Employee object and initialize its properties
        Employee employee = new Employee
        {
            FirstName = "Sample",   // Set the first name
            LastName = "Student",   // Set the last name
            Id = 1                  // Set the employee ID (optional for this task)
        };

        // Call the SayName method inherited from the Person class
        employee.SayName(); // Output: "Name: Sample Student"
    }
}