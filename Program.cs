using System;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    FirstName = "Sarah",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(1999, 5, 15),
                    Email = "sarah.johnson@example.com",
                    Major = "Computer Science",
                    EnrollmentDate = DateTime.Now,
                    AcademicStatus = "Active",
                    GPA = 3.85,
                    PhoneNumber = "555-0123"
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                Console.WriteLine($"Major: {student.Major}");
                Console.WriteLine($"Academic Status: {student.AcademicStatus}");
                Console.WriteLine($"GPA: {student.GPA}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}