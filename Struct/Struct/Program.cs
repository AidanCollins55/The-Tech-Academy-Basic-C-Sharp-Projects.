using System; // Import the System namespace for basic system functions

// Define a struct named 'Number'
public struct Number
{
    // Declare a property called 'Amount' of type decimal
    public decimal Amount;
}

class Program
{
    // Main method – entry point of the application
    static void Main(string[] args)
    {
        // Create a new instance of the Number struct
        Number myNumber;

        // Assign a decimal value to the Amount property
        myNumber.Amount = 123.45m;

        // Print the value of the Amount property to the console
        Console.WriteLine("The amount is: " + myNumber.Amount);
    }
}