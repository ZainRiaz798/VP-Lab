using System;
using System.Collections.Generic;

public class StudentClass
{
    protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };

    protected class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public GradeLevel Year { get; set; }
        public List<int> ExamScores { get; set; }
    }

    protected static List<Student> students = new List<Student>
    {
        new Student { FirstName = "Zain", LastName = "Riaz", Id = 120, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 99, 82, 81, 79 } },
        new Student { FirstName = "Maauz", LastName = "Mansoor", Id = 121, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 90, 65, 81, 99 } },
        new Student { FirstName = "Sarib", LastName = "Aaqil", Id = 122, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 55, 61, 81, 97 } },
        new Student { FirstName = "Zahid", LastName = "Zafar", Id = 123, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 33, 55, 65, 71 } },
        new Student { FirstName = "Hasnain", LastName = "Naseer", Id = 124, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 66, 65, 60, 65 } },
        new Student { FirstName = "Bilal", LastName = "Talib", Id = 125, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 90, 92, 91, 93 } },
        new Student { FirstName = "Ahmad", LastName = "Yasin", Id = 126, Year = GradeLevel.SecondYear, ExamScores = new List<int> { 77, 90, 83, 87 } }
    };

    // Main method
    public static void Main(string[] args)
    {
        // Example of how to use the StudentClass
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.FirstName} {student.LastName}, ID: {student.Id}, Year: {student.Year}");
            Console.WriteLine($"Exam Scores: {string.Join(", ", student.ExamScores)}");
        }
    }
}