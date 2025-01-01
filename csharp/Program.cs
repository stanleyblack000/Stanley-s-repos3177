// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, stanleyblack");

// namespace SimpleTable
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // string name;
//             // Console.WriteLine("what is your name?");
//             // name = Console.ReadLine();
//             // Console.WriteLine("Hello, {0}!", name);
//             // Console.ReadLine();

//             //             Console.WriteLine("\t\tGPA CALCULATOR");
//             //             Console.WriteLine("COURSE & CODE\tCOURSE UNIT\tGRADE\tGRADE-UNIT\tWEIGHT PT\tREMARK");

//             //             Console.WriteLine("MTH101\t\t 5 \t\t  B \t 4 \t\t 20 \t\t Very Good ");
//             //             Console.WriteLine("MTH101\t\t 3 \t\t  A \t 5 \t\t 15 \t\t Excelent ");
//             //             Console.WriteLine("MTH101\t\t 5 \t\t  C \t 3 \t\t 15 \t\t Good ");
//             //             Console.WriteLine("MTH101\t\t 5 \t\t  B \t 4 \t\t 20 \t\t Very Good ");
//             //             Console.WriteLine("MTH101\t\t 3 \t\t  F \t 0 \t\t0 \t\t Fail ");

//             //             Console.WriteLine("\t\t  \t  \t  \t  \t ");

//             //             Console.WriteLine("Total \t\t 3 \t\t   \t 0 \t\t0 \t\t ");
//             Console.WriteLine("Please input student course name and click Enter");
//             string courseCode = Console.ReadLine();

//             Console.WriteLine("Please input course code and click Enter");
//             int courseUnit = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Please input course score and click Enter");
//             int courseScore = Convert.ToInt32(Console.ReadLine());

//         }
//     }
// }

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using FirstConsoleApp.Models;  //this line of code references the model folder and links namespace
using FirstConsoleApp.Utilities; // this line of code references the Utilities folder and links namespace

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args) // allowsyou to use input from command line as data
        {
            var courses = new List<Course>(); // creates empty list name courses to store multiple course object data
            var printTable = new PrintTable(); //to print course details and gpa

            for (int i = 0; i < 5; i++)
            {
                var course = new Course();

                Console.Write("Enter Course Code (e.g MTH101): ");
                course.Code = Console.ReadLine();

                Console.Write("Enter Course Unit: ");
                course.Unit = int.Parse(Console.ReadLine());

                Console.Write("Enter Course Score: ");
                course.Score = int.Parse(Console.ReadLine());

                if (course.Score >= 70)
                {
                    course.Grade = "A";
                    course.GradeUnit = 5;
                    course.Remark = "Excellent!";
                }
                else if (course.Score >= 60)
                {
                    course.Grade = "B";
                    course.GradeUnit = 4;
                    course.Remark = "Very Good";
                }
                else if (course.Score >= 50)
                {
                    course.Grade = "C";
                    course.GradeUnit = 3;
                    course.Remark = "Good";
                }
                else if (course.Score >= 45)
                {
                    course.Grade = "D";
                    course.GradeUnit = 2;
                    course.Remark = "Fair";
                }
                else if (course.Score >= 40)
                {
                    course.Grade = "E";
                    course.GradeUnit = 1;
                    course.Remark = "Pass";
                }
                else
                {
                    course.Grade = "F";
                    course.GradeUnit = 0;
                    course.Remark = "Fail";
                }

                course.WeightPoint = course.Unit * course.GradeUnit;
                courses.Add(course);// This line of code allows you to add course details to the course list so the program can keep track.
            }

            int totalWeightPoint = 0, totalCourseUnit = 0; //initializing them to 0 because i'm trying to get the summations below

            foreach (var course in courses)
            {
                totalWeightPoint += course.WeightPoint;//this will add the prev totalweightPoint and current weightpoint
                totalCourseUnit += course.Unit;
            }

            double gpa = (double)totalWeightPoint / totalCourseUnit; // gpa formula. double because i want it in decimal
            printTable.Print(courses, gpa);

            if (gpa >= 4.50)
            {
                Console.WriteLine("First Class!");
            }
            else if (gpa >= 3.50)   // else if will range the value from 3.50 to 4.50
            {
                Console.WriteLine("Second Class Upper!");
            }
            else if (gpa >= 2.00)
            {
                Console.WriteLine("Second Class Lower!");
            }
            else if (gpa >= 1.00)
            {
                Console.WriteLine("Third Class!");
            }
            else
            {
                Console.WriteLine("This child don pass our school power oh");
            }

        }
    }
}





