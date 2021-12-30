using System.Collections.Generic;
using System;
using System.Linq;

namespace AssignmentA
{
    public class Printings
    {
        
        public static void AllStudents(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"ID",-10}{"FIRST NAME",-20}{"LAST NAME",-25}{"DATE OF BIRTH",-25}{"TUITION FEES",-25}");
            Console.ResetColor();

            foreach (var student in students)
            {
                student.Print();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void AllTrainers(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"ID",-10}{"FIRST NAME",-20}{"LAST NAME",-25}{"SUBJECT",-25}");
            Console.ResetColor();

            foreach (var trainer in trainers)
            {
                trainer.Print();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void AllAssignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"ID",-10}{"TITLE",-50}{"DESCRIPTION",-50}{"SUBMISSION DATE",-25}{"ORAL MARK",-25}{"TOTAL MARK",-25}");
            Console.ResetColor();

            foreach (var assignment in assignments)
            {
                assignment.Print();

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void AllCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"ID",-10}{"TITLE",-20}{"STREAM",-25}{"TYPE",-25}{"START DATE",-25}{"END DATE",-25}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.Print();

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void StudentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"COURSES",-30}{"FIRST NAME",-25}{"LAST NAME",-30}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var student in course.Students)
                {
                    Console.Write($"{"",-30}");
                    student.PrintName();
                }
            }
        }

        public static void TrainersPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"COURSES",-30}{"FIRST NAME",-25}{"LAST NAME",-30}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var trainer in course.Trainers)
                {
                    Console.Write($"{"",-30}");
                    trainer.PrintName();
                }
            }
        }

        public static void AssignmentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"COURSES",-30}{"TITLE",-30}{"DESCRIPTION",-30}");
            Console.ResetColor();

            foreach (var course in courses)
            {
                course.PrintTitle();
                foreach (var assignment in course.Assignments)
                {
                    Console.Write($"{"",-30}");
                    assignment.PrintTitle();
                }
            }
        }

        public static void AssignmentsPerStudent(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"FIRST NAME",-30}{"LAST NAME",-30}");
                Console.ResetColor();
                Console.WriteLine($"{stu.FirstName,-30}{stu.LastName,-30}");
                Console.WriteLine();

                foreach (var course in stu.Courses)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("COURSE: ");
                    Console.ResetColor();
                    Console.Write(course.Title);                    
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{"TITLE",-20}{"DESCRIPTION"}");
                    Console.ResetColor();
                    Console.WriteLine();
                    foreach (var assignment in course.Assignments)
                    {                       
                        Console.WriteLine($"{assignment.Title,-20}{assignment.Description}");
                        Console.WriteLine();
                    }
                }
                
            }
        }
        

        public static void StudentsWithMoreCourses(List<Student> students,string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            foreach (var student in students)
            {
                if(student.Courses.Count() > 1)
                {                  
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{"FIRST NAME",-15}{"LAST NAME",-15}");
                    Console.ResetColor();                    ;
                    Console.WriteLine($"{student.FirstName,-15}{student.LastName,-15}");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("COURSES: ");
                    Console.ResetColor();

                    foreach (var course in student.Courses)
                    {                       
                        Console.WriteLine($"{course.Title}");                       
                    }
                }
            }
            Console.WriteLine();
        }

        public static void Error()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Choice...ERROR 404");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void StudentsSubmitAssignment(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("GIVE A DATE TO SEE WHICH OF THE STUDENTS HAVE TO SUBMIT ASSIGNMENTS");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            string input = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            DateTime date;
            DateTime.TryParse(input, out date);
            var newDate = date.DayOfWeek;
            DateTime startDate = date;
            DateTime endDate = date;
            switch (newDate)
            {
                case DayOfWeek.Sunday:
                    startDate = date.AddDays(-6);
                    endDate = date.AddDays(-2);
                    break;
                case DayOfWeek.Monday:
                    startDate = date;
                    endDate = date.AddDays(4);
                    break;
                case DayOfWeek.Tuesday:
                    startDate = date.AddDays(-1);
                    endDate = date.AddDays(3);
                    break;
                case DayOfWeek.Wednesday:
                    startDate = date.AddDays(-2);
                    endDate = date.AddDays(2);
                    break;
                case DayOfWeek.Thursday:
                    startDate = date.AddDays(-3);
                    endDate = date.AddDays(1);
                    break;
                case DayOfWeek.Friday:
                    startDate = date.AddDays(-4);
                    endDate = date;
                    break;
                case DayOfWeek.Saturday:
                    startDate = date.AddDays(-5);
                    endDate = date.AddDays(-1);
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"FIRST NAME",-20} {"LAST NAME",-10}");
            Console.ResetColor();
            Console.WriteLine();

            foreach (var assignment in assignments)
            {
                if(assignment.SubDateTime >= startDate && assignment.SubDateTime <= endDate)
                {
                    foreach (var course in assignment.Courses)
                    {
                        foreach (var stu in course.Students)
                        {
                            Console.WriteLine($"{stu.FirstName,-20} {stu.LastName,-10}");
                        }
                    }
                }
            }



        }

    }



}








