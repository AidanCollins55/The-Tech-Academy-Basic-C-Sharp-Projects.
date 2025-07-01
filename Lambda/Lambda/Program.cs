using System;                // Provides basic system functions
using System.Collections.Generic; // Provides access to the List<T> class
using System.Linq;           // Enables LINQ and lambda expressions

// Define an Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id;           // Unique identifier for the employee
    public string FirstName; // Employee's first name
    public string LastName;  // Employee's last name
}

class Program
{
    // Main method – entry point of the console application
    static void Main(string[] args)
    {
        // Create a list of employees and populate it with 10 employee objects
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Emily", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Michael", LastName = "White" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Miller" },
            new Employee { Id = 7, FirstName = "Chris", LastName = "Davis" },
            new Employee { Id = 8, FirstName = "Anna", LastName = "Wilson" },
            new Employee { Id = 9, FirstName = "David", LastName = "Clark" },
            new Employee { Id = 10, FirstName = "Lisa", LastName = "Martinez" }
        };

        // Create a new list to hold employees named "Joe" using a foreach loop
        List<Employee> joesForEach = new List<Employee>(); // New empty list

        // Loop through each employee and check if their first name is "Joe"
        foreach (Employee emp in employees)
        {
            if (emp.FirstName == "Joe")
            {
                joesForEach.Add(emp); // Add matching employee to the list
            }
        }

        // Display the result of the foreach loop
        Console.WriteLine("Employees named Joe (foreach):");
        foreach (Employee joe in joesForEach)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName} (Id: {joe.Id})");
        }

        Console.WriteLine(); // Blank line for readability

        // Create a list of employees named "Joe" using a lambda expression
        List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        // Display the result of the lambda expression
        Console.WriteLine("Employees named Joe (lambda):");
        foreach (Employee joe in joesLambda)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName} (Id: {joe.Id})");
        }

        Console.WriteLine(); // Blank line for readability

        // Create a list of employees with Id greater than 5 using a lambda expression
        List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

        // Display employees with Id > 5
        Console.WriteLine("Employees with Id > 5:");
        foreach (Employee emp in idGreaterThanFive)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} (Id: {emp.Id})");
        }
    }
}
