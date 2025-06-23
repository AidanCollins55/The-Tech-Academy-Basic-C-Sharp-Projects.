using System;
using System.Collections.Generic; // Needed for using List<T>

class Program
{
    static void Main()
    {
        // ===== STRING ARRAY EXAMPLE =====
        // Create a one-dimensional array of strings
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };

        Console.WriteLine("Select an index (0-4) to display a color from the array:");
        // Read user input and convert it to an integer
        int colorIndex;
        bool validColorInput = int.TryParse(Console.ReadLine(), out colorIndex);

        // Check if input is valid and index is within array bounds
        if (validColorInput && colorIndex >= 0 && colorIndex < colors.Length)
        {
            Console.WriteLine("Color at index " + colorIndex + ": " + colors[colorIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. That color does not exist.");
        }

        Console.WriteLine(); // Blank line for spacing

        // ===== INTEGER ARRAY EXAMPLE =====
        // Create a one-dimensional array of integers
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Select an index (0-4) to display a number from the array:");
        int numberIndex;
        bool validNumberInput = int.TryParse(Console.ReadLine(), out numberIndex);

        // Check for valid input and valid index
        if (validNumberInput && numberIndex >= 0 && numberIndex < numbers.Length)
        {
            Console.WriteLine("Number at index " + numberIndex + ": " + numbers[numberIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. That number does not exist.");
        }

        Console.WriteLine(); // Blank line for spacing

        // ===== STRING LIST EXAMPLE =====
        // Create a List of strings
        List<string> animals = new List<string> { "Dog", "Cat", "Elephant", "Zebra", "Lion" };

        Console.WriteLine("Select an index (0-4) to display an animal from the list:");
        int animalIndex;
        bool validAnimalInput = int.TryParse(Console.ReadLine(), out animalIndex);

        // Check if index is within bounds of the list
        if (validAnimalInput && animalIndex >= 0 && animalIndex < animals.Count)
        {
            Console.WriteLine("Animal at index " + animalIndex + ": " + animals[animalIndex]);
        }
        else
        {
            Console.WriteLine("Invalid index. That animal does not exist.");
        }
    }
}