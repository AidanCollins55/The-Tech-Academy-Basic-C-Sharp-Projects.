using System;

// Declare a static class so it cannot be instantiated
public static class MathHandler
{
    // Method 1: Void method that takes an integer and divides it by 2
    public static void DivideByTwo(int number)
    {
        int result = number / 2; // Divide input number by 2
        Console.WriteLine($"Half of {number} is: {result}"); // Display result
    }

    // Method 2: Method with an output parameter
    public static void MultiplyByFive(int input, out int result)
    {
        result = input * 5; // Multiply input by 5 and assign to output parameter
    }

    // Method 3: Method Overload. Same name, different parameter type
    public static void DivideByTwo(double number)
    {
        double result = number / 2.0; // Divide double by 2
        Console.WriteLine($"Half of {number} is: {result}"); // Display result
    }
}
