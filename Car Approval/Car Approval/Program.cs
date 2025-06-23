using System;

class Program
{
    static void Main()
    {
        // Display the program title
        Console.WriteLine("Car Insurance Approval Program");
        Console.WriteLine(); // Blank line for better formatting

        // ===== ASK AGE =====
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // ===== ASK ABOUT DUI =====
        Console.Write("Have you ever had a DUI? (true/false): ");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine()); // Convert input to boolean

        // ===== ASK ABOUT SPEEDING TICKETS =====
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

        // ===== EVALUATE QUALIFICATIONS =====
        // Apply the business rules:
        // 1.) Must be over 15
        // 2.) Must NOT have a DUI (false)
        // 3.) Must have 3 or fewer speeding tickets
        bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

        // ===== OUTPUT RESULT =====
        Console.WriteLine(); // Blank line before result
        Console.WriteLine("Qualified for car insurance?");
        Console.WriteLine(isQualified); // Print true or false
    }
}