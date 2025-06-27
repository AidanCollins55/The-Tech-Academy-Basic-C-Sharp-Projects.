using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathAction class to use its method
        MathAction action = new MathAction();

    
        // Pass in two numbers directly (positional parameters)
        action.PerformOperation(4, 10); // 4 will be squared, 10 will be printed

        
        // This way we specify the name of each parameter
        action.PerformOperation(firstNumber: 7, secondNumber: 3); // 7 will be squared, 3 will be printed
    }
}

