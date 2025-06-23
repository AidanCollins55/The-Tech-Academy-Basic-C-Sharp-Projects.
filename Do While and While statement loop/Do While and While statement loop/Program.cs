using System;

class Program
{
    static void Main()
    {
        // WHILE LOOP EXAMPLE
        // Initialize a counter variable
        int counter = 0;

        // This while loop runs as long as the counter is less than 5
        // It performs a boolean comparison
        Console.WriteLine("While Loop: Counting from 0 to 4");

        while (counter < 5)
        {
            // Print current counter value
            Console.WriteLine("Counter: " + counter);

            // Increment the counter by 1 each time through the loop
            counter++;
        }

        Console.WriteLine(); // Blank line for spacing

        // DO-WHILE LOOP EXAMPLE
        // Reset counter to 5
        int doCounter = 5;

        // This do-while loop runs at least once, even if the condition is false at the start
        // It performs a boolean comparison: (doCounter < 5)
        Console.WriteLine("Do-While Loop: Will run once even though doCounter is 5");

        do
        {
            // Print current value of doCounter
            Console.WriteLine("doCounter: " + doCounter);

            // Increment doCounter by 1
            doCounter++;
        }
        while (doCounter < 5); // This condition is false on the first check

        // The loop still ran once because do-while checks the condition after the first run
    }
}
