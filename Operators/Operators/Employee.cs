using System;

// Define the Employee class
public class Employee
{
    // Property to hold employee ID
    public int Id { get; set; }

    // Property to hold first name
    public string FirstName { get; set; }

    // Property to hold last name
    public string LastName { get; set; }

    // Overload the "==" operator to compare two Employee objects based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both are null return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null return false
        if (emp1 is null || emp2 is null)
            return false;

        // Compare the Id values
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() for good measure (not strictly required here)
    public override bool Equals(object obj)
    {
        // Return false if object is null or not an Employee
        if (!(obj is Employee other))
            return false;

        return this.Id == other.Id;
    }

    // Override GetHashCode to match Equals (best practice)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}