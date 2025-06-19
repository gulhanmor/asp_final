using System;

namespace StudentManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string AcademicStatus { get; set; }
        public double GPA { get; set; }
        public string PhoneNumber { get; set; }
    }
}