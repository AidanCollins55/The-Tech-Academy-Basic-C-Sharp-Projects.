using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathProcessor class to use its methods
        MathProcessor processor = new MathProcessor();

        // -------- Integer Input --------
        // Declare an integer variable
        int intInput = 5;
        // Call the method that takes an int and display the result
        int intResult = processor.ProcessInput(intInput);
        Console.WriteLine($"Integer input ({intInput}) + 10 = {intResult}");

        // -------- Decimal Input --------
        // Declare a decimal variable
        decimal decimalInput = 7.5m;
        // Call the method that takes a decimal and display the result
        int decimalResult = processor.ProcessInput(decimalInput);
        Console.WriteLine($"Decimal input ({decimalInput}) * 2 = {decimalResult}");

        // -------- String Input --------
        // Declare a string representing an integer
        string stringInput = "15";
        // Call the method that takes a string, converts and subtracts 3
        int stringResult = processor.ProcessInput(stringInput);
        Console.WriteLine($"String input (\"{stringInput}\") - 3 = {stringResult}");

        // Uncomment below to see error handling in action
        // string invalidInput = "abc";
        // int errorResult = processor.ProcessInput(invalidInput);
    }
}