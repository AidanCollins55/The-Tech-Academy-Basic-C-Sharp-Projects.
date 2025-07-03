using System;

namespace ConstructorChainingExample
{
    // Main class of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class using the single-parameter constructor
            Person person = new Person("John");

            // Call method to display person's info
            person.DisplayInfo();

            // Create an instance of the Person class using the two-parameter constructor
            Person anotherPerson = new Person("Jane", 28);

            // Call method to display person's info
            anotherPerson.DisplayInfo();

            // Keep console window open
            Console.ReadLine();
        }
    }

    // Class to demonstrate constructor chaining
    class Person
    {
        // Constant value to represent a default age
        private const int DEFAULT_AGE = 30;

        // Auto-implemented properties for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor that takes only a name
        public Person(string name) : this(name, DEFAULT_AGE) // Chaining to the two-parameter constructor
        {
            // No additional code needed here because chaining handles initialization
        }

        // Constructor that takes both name and age
        public Person(string name, int age)
        {
            // 'var' keyword is used to infer the type (string in this case)
            var upperName = name.ToUpper(); // Convert name to uppercase for demonstration

            // Set property values
            Name = upperName;
            Age = age;
        }

        // Method to display the person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}