using System;

public class MathProcessor
{
    // Method 1: Takes an integer, adds 10 to it, and returns the result
    public int ProcessInput(int number)
    {
        return number + 10;
    }

    // Method 2: Takes a decimal, multiplies it by 2, and returns the integer part of the result
    public int ProcessInput(decimal number)
    {
        return (int)(number * 2);
    }

    // Method 3: Takes a string, converts it to an integer if possible,
    // subtracts 3 from it, and returns the result
    public int ProcessInput(string input)
    {
        // Try to parse the string to an integer
        if (int.TryParse(input, out int result))
        {
            return result - 3;
        }
        else
        {
            // If conversion fails, throw an exception
            throw new ArgumentException("Input string is not a valid integer.");
        }
    }
}