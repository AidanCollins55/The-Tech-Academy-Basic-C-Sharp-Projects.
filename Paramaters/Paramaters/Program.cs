using System;
using System.Collections.Generic;

// Define a generic class Employee with a type parameter T
public class Employee<T>
{
    // Define a public property called "Things" that is a list of the generic type T
    public List<T> Things { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object with type parameter as string
        Employee<string> stringEmployee = new Employee<string>();

        // Assign a list of strings to the Things property
        stringEmployee.Things = new List<string> { "Laptop", "Notebook", "Pen" };

        // Instantiate an Employee object with type parameter as int
        Employee<int> intEmployee = new Employee<int>();

        // Assign a list of integers to the Things property
        intEmployee.Things = new List<int> { 101, 202, 303 };

        // Print out all the items in the Things list of the stringEmployee
        Console.WriteLine("String Employee's Things:");
        foreach (string item in stringEmployee.Things)
        {
            // Output each string item to the console
            Console.WriteLine(item);
        }

        // Print out all the items in the Things list of the intEmployee
        Console.WriteLine("\nInteger Employee's Things:");
        foreach (int item in intEmployee.Things)
        {
            // Output each integer item to the console
            Console.WriteLine(item);
        }
    }
}