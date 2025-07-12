using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApp
{


    class Program
    {
        static void Main()
        {
            using (var context = new SchoolContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Add a student
                var student = new Student
                {
                    FullName = "Alice Johnson",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }
        }
    }
}
