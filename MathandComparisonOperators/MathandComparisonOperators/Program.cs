using System;

class Program
{
    static void Main()
    {
        // MULTIPLY BY 50
        Console.Write("Enter a number to multiply by 50: ");
        // Read user input and convert it to a long for large number support
        long input1 = Convert.ToInt64(Console.ReadLine());
        // Multiply the input by 50
        long result1 = input1 * 50;
        // Output the result
        Console.WriteLine("Result: " + result1);
        Console.WriteLine(); // Blank line for readability

        // ADD 25
        Console.Write("Enter a number to add 25 to: ");
        // Read and convert user input to long
        long input2 = Convert.ToInt64(Console.ReadLine());
        // Add 25 to the input
        long result2 = input2 + 25;
        // Output the result
        Console.WriteLine("Result: " + result2);
        Console.WriteLine();

        // DIVIDE BY 12.5
        Console.Write("Enter a number to divide by 12.5: ");
        // Read and convert input to double to preserve decimal precision
        double input3 = Convert.ToDouble(Console.ReadLine());
        // Divide the input by 12.5
        double result3 = input3 / 12.5;
        // Output the result
        Console.WriteLine("Result: " + result3);
        Console.WriteLine();

        // CHECK IF GREATER THAN 50
        Console.Write("Enter a number to check if it is greater than 50: ");
        // Read and convert input to integer
        int input4 = Convert.ToInt32(Console.ReadLine());
        // Check if the input is greater than 50 and return a boolean
        bool isGreaterThan50 = input4 > 50;
        // Output the result
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);
        Console.WriteLine();

        // DIVIDE BY 7 AND GET REMAINDER
        Console.Write("Enter a number to divide by 7 and find the remainder: ");
        // Read and convert input to integer
        int input5 = Convert.ToInt32(Console.ReadLine());
        // Use the modulus operator to find the remainder
        int remainder = input5 % 7;
        // Output the remainder
        Console.WriteLine("Remainder when divided by 7: " + remainder);
    }
}