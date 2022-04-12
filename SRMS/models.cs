using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Administrator")]
    public class Administrator
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Table("Course")]
    public class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Level { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        public string Room { get; set; }
        public string Semester { get; set; }
        public string Notes { get; set; }
    }

    [Table("Enrollment")]
    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }
        public DateTime DateEntered { get; set; }
        public int Status { get; set; }
    }

    [Table("Faculty")]
    public class Faculty
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Major { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Table("Teaching")]
    public class Teaching
    {
        public int FacultyId { get; set; }
        public int CourseId { get; set; }
        public string LectureTime { get; set; }
        public string OfficeHour { get; set; }
        public DateTime DateEntered { get; set; }
    }
}