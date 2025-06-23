using System;
using System.Text; // Required to use StringBuilder

class Program
{
    static void Main()
    {
        // ===== STRING CONCATENATION =====
        // Define three individual strings
        string part1 = "The quick brown fox";
        string part2 = " jumps over";
        string part3 = " the lazy dog.";

        // Concatenate the strings together into one sentence
        string fullSentence = part1 + part2 + part3;

        // Output the concatenated result
        Console.WriteLine("Concatenated Sentence:");
        Console.WriteLine(fullSentence);
        Console.WriteLine(); // Add a blank line for readability

        // ===== CONVERT TO UPPERCASE =====
        // Convert the sentence to all uppercase letters
        string upperCaseSentence = fullSentence.ToUpper();

        // Output the uppercase version
        Console.WriteLine("Uppercase Version:");
        Console.WriteLine(upperCaseSentence);
        Console.WriteLine(); // Add a blank line for readability

        // ===== STRINGBUILDER EXAMPLE =====
        // Initialize a StringBuilder to construct a paragraph
        StringBuilder paragraph = new StringBuilder();

        // Append sentences one at a time
        paragraph.Append("Today is a beautiful day. ");      // First sentence
        paragraph.Append("The sun is shining brightly. ");   // Second sentence
        paragraph.Append("Birds are chirping all around. "); // Third sentence
        paragraph.Append("It's a perfect day for learning C#!"); // Fourth sentence

        // Output the complete paragraph
        Console.WriteLine("Built Paragraph with StringBuilder:");
        Console.WriteLine(paragraph.ToString());
    }
}