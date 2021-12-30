using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class InputData
    {       

        public static Course CreateCourse()
        {
            int id;
            string title;
            string stream;
            string type;
            DateTime startDate;
            DateTime endDate;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE COURSE:     (EX : C#, Java)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            title = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE STREAM:     (EX : CB18, CB19)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            stream = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE TYPE:       (EX : Part-Time, Full-Time)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            type = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE START-DATE: (EX : 2021-8-21)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            string input = Console.ReadLine();
            DateTime.TryParse(input, out startDate);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE END-DATE: (EX : 2021-8-21)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            string input2 = Console.ReadLine();
            DateTime.TryParse(input2, out endDate);
            Console.ResetColor();



            Course c = new Course(title, stream, type, startDate, endDate);


            return c; 
            
        }

        public static Student CreateStudent()
        {
            string firstName;
            string lastName;
            DateTime dateOfBirth;
            int tuitionFees;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FIRST NAME:     (EX : Alexandros)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            firstName = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LAST NAME:     (EX : Argyriou)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            lastName = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DATE OF BIRTH:       (EX : 1995-07-25)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            string input = Console.ReadLine();
            DateTime.TryParse(input, out dateOfBirth);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TUITION FEES: (EX : 3500)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            tuitionFees = Convert.ToInt32( Console.ReadLine());


            Student s = new Student(firstName, lastName, dateOfBirth, tuitionFees);
            return s;

        }

        public static Trainer CreateTrainer()
        {
            

            string firstName;
            string lastName;
            string subject;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FIRST NAME:     (EX : Alexandros)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            firstName = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LAST NAME:     (EX : Argyriou)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            lastName = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SUBJECT:     (EX : Python)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            subject = Console.ReadLine();

            Trainer t = new Trainer(firstName, lastName, subject);

            return t;

        }

        public static Assignment CreateAssignment()
        {
            string title;
            string description;
            DateTime subDate;
            int oralMark;
            int totalMark;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE TITLE:     (EX : Web site)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            title = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE DESCRIPTION:     (EX : Build a website with html-css)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            description = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE SUBMISSION DATE:       (EX : 2021-08-15)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            string input = Console.ReadLine();
            DateTime.TryParse(input, out subDate);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE ORAL-MARK: (EX : 75)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            oralMark = Convert.ToInt32( Console.ReadLine());
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CHOOSE TOTAL-MARK: (EX : 100)");
            Console.WriteLine();
            Console.Write("CHOOSE: ");
            Console.ResetColor();
            totalMark = Convert.ToInt32(Console.ReadLine());

            Assignment a = new Assignment(title, description, subDate, oralMark, totalMark);
            return a;

        }
    }

   
}



 


  

