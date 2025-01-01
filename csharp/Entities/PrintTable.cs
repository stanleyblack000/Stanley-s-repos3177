using System;
using System.Collections.Generic;
using FirstConsoleApp.Models; // 

namespace FirstConsoleApp.Utilities // 
{
    public class PrintTable
    {
        public void Print(List<Course> courses, double gpa)
        {
            Console.WriteLine("\n| Course and Code | Course Unit | Grade | Grade Unit | Weight Pt | Remark       |");

            foreach (var course in courses)
            {
                Console.WriteLine($"| {course.Code,-15} | {course.Unit,-11} | {course.Grade,-5} | {course.GradeUnit,-10} | {course.WeightPoint,-9} | {course.Remark,-12} |");
            }
            Console.WriteLine("|----------------|-------------|-------|------------|-----------|--------------|");
            Console.WriteLine($"\nGPA: {gpa:F2}");
        }
    }
}