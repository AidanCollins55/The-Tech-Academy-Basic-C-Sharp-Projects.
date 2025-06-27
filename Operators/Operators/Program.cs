using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the first Employee object and assign values
        Employee employee1 = new Employee()
        {
            Id = 101,
            FirstName = "John",
            LastName = "Doe"
        };

        // Instantiate the second Employee object and assign values
        Employee employee2 = new Employee()
        {
            Id = 101, // Same Id as employee1 to test equality
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the two Employee objects using the overloaded "==" operator
        if (employee1 == employee2)
        {
            Console.WriteLine("Employees are equal (same Id).");
        }
        else
        {
            Console.WriteLine("Employees are NOT equal (different Ids).");
        }

        // Also test the "!=" operator
        if (employee1 != employee2)
        {
            Console.WriteLine("Employees are NOT equal (using !=).");
        }
        else
        {
            Console.WriteLine("Employees are equal (using !=).");
        }
    }
}