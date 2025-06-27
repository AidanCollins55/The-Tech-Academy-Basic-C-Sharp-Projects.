using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and set its properties
        Employee employee = new Employee()
        {
            FirstName = "Sample", // Assign first name
            LastName = "Student"  // Assign last name
        };

        // Call the SayName method on the Employee object
        employee.SayName(); // Output: Name: Sample Student

        // Demonstrate polymorphism:
        // Create an object of type IQuittable and assign it the Employee instance
        IQuittable quittableEmployee = employee;

        // Call the Quit method using the interface reference
        quittableEmployee.Quit(); // Output: Sample Student has quit the job.
    }
}