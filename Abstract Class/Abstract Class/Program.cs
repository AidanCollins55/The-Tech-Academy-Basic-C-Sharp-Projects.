using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Employee class
        Employee employee = new Employee();

        // Set the first name and last name properties
        employee.FirstName = "Sample";   // Assign "Sample" to FirstName
        employee.LastName = "Student";   // Assign "Student" to LastName

        // Call the SayName method, which will output the full name
        employee.SayName(); // Expected output: "Name: Sample Student"
    }
}
