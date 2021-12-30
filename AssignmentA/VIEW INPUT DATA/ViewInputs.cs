using System;

namespace AssignmentA
{
    public class ViewInputs
    {

        public static void Course()
        {
            CourseService cs = new CourseService();
            var allCourses = cs.GetCourse();
            string input;
            do
            {
                var course = InputData.CreateCourse();
                cs.CreateCourse(course);
                Console.Clear();
                Console.WriteLine("IF YOU WANT TO CONTINUE ADDING PRESS ANY BUTTON,ELSE PRESS e");
                input = Console.ReadLine().ToLower();
            } while (input != "e");
            

            Printings.AllCourses(allCourses, "ALL COURSES");
        }

        public static void Student()
        {
            StudentService ss = new StudentService();
            var allStudents = ss.GetStudent();

            string input;
            do
            {
                var student = InputData.CreateStudent();
                ss.CreateStudent(student);
                Console.Clear();
                Console.WriteLine("IF YOU WANT TO CONTINUE ADDING PRESS ANY BUTTON,ELSE PRESS e");
                input = Console.ReadLine().ToLower();
            } while (input != "e");


            Printings.AllStudents(allStudents, "ALL COURSES");
        }

        public static void Trainer()
        {
            TrainerService ts = new TrainerService();
            var allTrainers = ts.GetTrainer();

            string input;
            do
            {
                var trainer = InputData.CreateTrainer();
                ts.CreateTrainer(trainer);
                Console.Clear();
                Console.WriteLine("IF YOU WANT TO CONTINUE ADDING PRESS ANY BUTTON,ELSE PRESS e");
                input = Console.ReadLine().ToLower();
            } while (input != "e");


            Printings.AllTrainers(allTrainers, "ALL COURSES");
        }

        public static void Assignment()
        {
            AssignmentService an = new AssignmentService();
            var allAssignments = an.GetAssignment();

            string input;
            do
            {
                var assignment = InputData.CreateAssignment();
                an.CreateAssignment(assignment);
                Console.Clear();
                Console.WriteLine("IF YOU WANT TO CONTINUE ADDING PRESS ANY BUTTON,ELSE PRESS e");
                input = Console.ReadLine().ToLower();
            } while (input != "e");


            Printings.AllAssignments(allAssignments, "ALL COURSES");
        }


    }

    











}



 


  

