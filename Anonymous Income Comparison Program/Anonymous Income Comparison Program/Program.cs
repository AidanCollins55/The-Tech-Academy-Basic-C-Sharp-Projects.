using System;

class Program
{
    static void Main()
    {
        // Display the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine(); // Blank line for better readability

        // ===== PERSON 1 =====
        Console.WriteLine("Person 1");

        // Prompt and read hourly rate for Person 1, converted to decimal for accuracy in financial data
        Console.Write("Hourly Rate: ");
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

        // Prompt and read hours worked per week for Person 1
        Console.Write("Hours worked per week: ");
        decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine(); // Blank line between persons

        // ===== PERSON 2 =====
        Console.WriteLine("Person 2");

        // Prompt and read hourly rate for Person 2
        Console.Write("Hourly Rate: ");
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

        // Prompt and read hours worked per week for Person 2
        Console.Write("Hours worked per week: ");
        decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine(); // Blank line before salary output

        // ===== CALCULATE ANNUAL SALARIES =====

        // Calculate annual salary by multiplying hourly rate * hours/week * 52 weeks/year
        decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
        decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

        // Display the annual salary for Person 1
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        // Display the annual salary for Person 2
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        Console.WriteLine(); // Blank line before comparison

        // Compare salaries and determine if Person 1 earns more than Person 2
        bool doesPerson1MakeMore = annualSalary1 > annualSalary2;

        // Display the comparison result
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(doesPerson1MakeMore);
    }
}