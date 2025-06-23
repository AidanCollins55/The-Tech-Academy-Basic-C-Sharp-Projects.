using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ===== PART ONE ===== //
        // ===== ONE-DIMENSIONAL STRING ARRAY =====
        string[] greetings = { "Hello", "Welcome", "Hi", "Greetings", "Salutations" };

        // Ask the user to enter text to append to each array element
        Console.WriteLine("Enter text to append to each greeting:");
        string userAppend = Console.ReadLine();

        // Append user text to each string in the array (no output yet)
        for (int i = 0; i < greetings.Length; i++)
        {
            greetings[i] = greetings[i] + " " + userAppend;
        }

        // Print each updated string from the array
        Console.WriteLine("\nUpdated greetings:");
        for (int i = 0; i < greetings.Length; i++)
        {
            Console.WriteLine(greetings[i]);
        }

        // ===== PART TWO ===== //
        // ===== INFINITE LOOP EXAMPLE (FIXED) =====
        Console.WriteLine("\nCounting from 1 to 5 using a fixed infinite loop:");

        int counter = 1;

        // Infinite loop that has a working exit condition
        while (true)
        {
            Console.WriteLine("Counter: " + counter);
            counter++;

            if (counter > 5) // Fix: Break the loop after reaching 5
            {
                break; // Stops the infinite loop
            }
        }

        // ===== PART THREE ===== //
        // ===== LOOP WITH "<" COMPARISON OPERATOR =====
        Console.WriteLine("\nLoop using '<' to print numbers 0 through 4:");
        for (int i = 0; i < 5; i++) // Uses < comparison
        {
            Console.WriteLine(i);
        }

        // ===== LOOP WITH "<=" COMPARISON OPERATOR =====
        Console.WriteLine("\nLoop using '<=' to print numbers 0 through 5:");
        for (int i = 0; i <= 5; i++) // Uses <= comparison
        {
            Console.WriteLine(i);
        }

        // ===== PART FOUR ===== //
        // ===== UNIQUE LIST OF STRINGS & USER SEARCH =====
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };

        Console.WriteLine("\nEnter a color to search in the unique color list:");
        string colorInput = Console.ReadLine();

        bool matchFound = false;

        for (int i = 0; i < colors.Count; i++)
        {
            if (colors[i].Equals(colorInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match found at index {i}: {colors[i]}");
                matchFound = true;
                break; // Stop loop after first match is found
            }
        }

        if (!matchFound)
        {
            Console.WriteLine("That color is not on the list.");
        }

        // ===== PART FIVE ===== //
        // ===== DUPLICATE LIST & MULTIPLE MATCH SEARCH =====
        List<string> animals = new List<string> { "Dog", "Cat", "Dog", "Elephant", "Cat", "Lion" };

        Console.WriteLine("\nEnter an animal to search in the duplicate animal list:");
        string animalInput = Console.ReadLine();

        bool foundAny = false;

        for (int i = 0; i < animals.Count; i++)
        {
            if (animals[i].Equals(animalInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match at index {i}: {animals[i]}");
                foundAny = true;
            }
        }

        if (!foundAny)
        {
            Console.WriteLine("That animal is not on the list.");
        }

        // ===== PART SIX ===== //
        // ===== FOREACH LOOP TO IDENTIFY DUPLICATES =====
        List<string> letters = new List<string> { "A", "B", "C", "D", "C" };
        HashSet<string> seen = new HashSet<string>(); // Track seen items

        Console.WriteLine("\nChecking for duplicates in the list of letters:");
        foreach (string letter in letters)
        {
            if (seen.Contains(letter))
            {
                Console.WriteLine($"{letter} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{letter} - this item is unique");
                seen.Add(letter); // Add new unique item
            }
        }

        // ===== END =====
        Console.WriteLine("\nEnd of program. Press any key to exit.");
        Console.ReadKey();
    }
}