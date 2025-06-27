using System;

// Define a class named MathAction
public class MathAction
{
    // This is a void method that takes two integers as input parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first number (e.g., square it)
        int result = firstNumber * firstNumber;

        // Display the result of the math operation
        Console.WriteLine($"The square of the first number ({firstNumber}) is: {result}");

        // Display the second number
        Console.WriteLine($"The second number is: {secondNumber}");
    }
}