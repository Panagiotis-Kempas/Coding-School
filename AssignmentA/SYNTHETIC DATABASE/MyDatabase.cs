using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class MyDatabase
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }

        public MyDatabase()
        {
            //Students
            Student s1 = new Student("Panagiotis", "Kempas", new DateTime(1996, 07, 21), 2500); s1.Id = 1;
            Student s2 = new Student("Labros", "Papadimitriou", new DateTime(1993, 11, 15), 3500); s2.Id = 2;
            Student s3 = new Student("Antonis", "Chamailidis", new DateTime(1992, 02, 11), 3000); s3.Id = 3;
            Student s4 = new Student("Spyros", "Dellis", new DateTime(1990, 06, 07), 2500); s4.Id = 4;
            Student s5 = new Student("Christos", "Dimitrakopoulos", new DateTime(1989, 04, 13), 3700); s5.Id = 5;
            Student s6 = new Student("Christos", "Karamolegkos", new DateTime(1991, 01, 27), 4000); s6.Id = 6;
            Student s7 = new Student("Konstantinos", "Dimitriou", new DateTime(1995, 03, 25), 3500); s7.Id = 7;
            Student s8 = new Student("Triantafilia", "Dwnou", new DateTime(1994, 04, 22), 2500); s8.Id = 8;
            Student s9 = new Student("Nikos", "Filiopoulos", new DateTime(1988, 05, 11), 2000); s9.Id = 9;
            Student s10 = new Student("Iosif", "Vasou", new DateTime(1990, 10, 30), 4500); s10.Id = 10;
            Student s11 = new Student("Vasiliki", "Kalantzi", new DateTime(1988, 12, 17), 2000); s11.Id = 11;
            Student s12 = new Student("Ioannis", "Karakasidis", new DateTime(1990, 08, 31), 3000); s12.Id = 12;
            Student s13 = new Student("Anna", "Kitou", new DateTime(1992, 11, 18), 2500); s13.Id = 13;
            Student s14 = new Student("Kostas", "Likos", new DateTime(1993, 01, 07), 4000); s14.Id = 14;
            Student s15 = new Student("Giannis", "Michailidis", new DateTime(1991, 08, 30), 3000); s15.Id = 15;
            Student s16 = new Student("Leonidas", "Mourikis", new DateTime(1985, 07, 25), 3500); s16.Id = 16;
            Student s17 = new Student("Natalia", "Papadatou", new DateTime(1994, 06, 08), 2500); s17.Id = 17;
            Student s18 = new Student("Androniki", "Theofylaktidou", new DateTime(1996, 05, 10), 4000); s18.Id = 18;
            Student s19 = new Student("Rafail", "Tsikriteas", new DateTime(1991, 02, 19), 3500); s19.Id = 19;
            Student s20 = new Student("Giannis", "Kyriakopoulos", new DateTime(1992, 04, 15), 3000); s20.Id = 20;
            Student s21 = new Student("Alexandra", "Alexandridou", new DateTime(1994, 05, 18), 2500); s21.Id = 21;
            Student s22 = new Student("Spyros", "Zaxos", new DateTime(1991, 09, 07), 4000); s22.Id = 22;
            Student s23 = new Student("Giorgos", "Xiwnis", new DateTime(1990, 06, 08), 2500); s23.Id = 23;
            Student s24 = new Student("Gwgw", "Ntintifa", new DateTime(1989, 11, 15), 4000); s24.Id = 24;
            Student s25 = new Student("Evelina", "Georgiou", new DateTime(1994, 08, 19), 2500); s25.Id = 25;
            Student s26 = new Student("Nikos", "Sideris", new DateTime(1991, 07, 21), 3000); s26.Id = 26;
            Student s27 = new Student("Antreas", "Patsima", new DateTime(1991, 08, 27), 2500); s27.Id = 27;
            Student s28 = new Student("Spyros", "Stamou", new DateTime(1992, 01, 15), 4000); s28.Id = 28;




            //Courses

            Course c1 = new Course("C#", "CB14", "Full-Time", new DateTime(2021, 06, 11), new DateTime(2021, 09, 30)); c1.Id = 1;
            Course c2 = new Course("C#", "CB14", "Part-Time", new DateTime(2021, 06, 10), new DateTime(2021, 12, 22)); c2.Id = 2;
            Course c3 = new Course("Java", "CB15", "Full-Time", new DateTime(2021, 06, 15), new DateTime(2021, 09, 29)); c3.Id = 3;
            Course c4 = new Course("Java", "CB15", "Part-Time", new DateTime(2021, 06, 18), new DateTime(2021, 12, 23)); c4.Id = 4;


            CourseStudent(c1, s1);
            CourseStudent(c1, s2);
            CourseStudent(c1, s3);
            CourseStudent(c1, s4);
            CourseStudent(c1, s5);
            CourseStudent(c1, s6);
            CourseStudent(c1, s7);
            CourseStudent(c2, s8);
            CourseStudent(c2, s9);
            CourseStudent(c2, s10);
            CourseStudent(c2, s11);
            CourseStudent(c2, s12);
            CourseStudent(c2, s13);
            CourseStudent(c2, s14);
            CourseStudent(c3, s15);
            CourseStudent(c3, s16);
            CourseStudent(c3, s17);
            CourseStudent(c3, s18);
            CourseStudent(c3, s19);
            CourseStudent(c3, s20);
            CourseStudent(c3, s21);
            CourseStudent(c4, s22);
            CourseStudent(c4, s23);
            CourseStudent(c4, s24);
            CourseStudent(c4, s25);
            CourseStudent(c4, s26);
            CourseStudent(c4, s27);
            CourseStudent(c4, s28);
            CourseStudent(c1, s25);
            CourseStudent(c2, s15);
            CourseStudent(c3, s10);
            CourseStudent(c4, s5);


            //Trainers

            Trainer t1 = new Trainer("Ektoras", "Gkatsos", "C#"); t1.Id = 1;
            Trainer t2 = new Trainer("Giorgos", "Pasparakis", "Java"); t2.Id = 2;
            Trainer t3 = new Trainer("Alexandros", "Papanikas", "C#"); t3.Id = 3;
            Trainer t4 = new Trainer("Themis", "Kalogirou", "OOP"); t4.Id = 4;
            Trainer t5 = new Trainer("Eleni", "Papadima", "Javascript"); t5.Id = 5;
            Trainer t6 = new Trainer("Thanasis", "Diwgenis", "HTML-CSS"); t6.Id = 6;
            Trainer t7 = new Trainer("Mixalhs", "Anagnwstou", "SQL"); t7.Id = 7;
            Trainer t8 = new Trainer("Zwh", "Andreou", "Python"); t8.Id = 8;


            TrainerCourse(c1, t1);
            TrainerCourse(c1, t2);
            TrainerCourse(c2, t3);
            TrainerCourse(c2, t4);
            TrainerCourse(c3, t5);
            TrainerCourse(c3, t6);
            TrainerCourse(c4, t7);
            TrainerCourse(c4, t8);

            TrainerCourse(c1, t8);
            TrainerCourse(c1, t7);
            TrainerCourse(c2, t6);
            TrainerCourse(c2, t5);
            TrainerCourse(c3, t4);
            TrainerCourse(c3, t3);
            TrainerCourse(c4, t2);
            TrainerCourse(c4, t1);


            //Assignemnts

            // C# PROJECTS FULL-TIME
            Assignment a1 = new Assignment("Website", "Build a website using HTML-CSS-JS", new DateTime(2021, 06, 26), 70, 90);a1.Id = 1;
            Assignment a2 = new Assignment("OOP", "Build a databse with classes", new DateTime(2021, 07, 10), 80, 95); a2.Id = 2;
            Assignment a3 = new Assignment("Tic Tac Toe", "Build the game tic tac toe", new DateTime(2021, 07, 25), 80, 100); a3.Id = 3;
            Assignment a4 = new Assignment("API", "Build an application using API", new DateTime(2021, 08, 11), 80, 95); a4.Id = 4;
            Assignment a5 = new Assignment("AIR TICKET", "Build an application for booking airtickets", new DateTime(2021, 08, 24), 80, 100); a5.Id = 5;
            Assignment a6 = new Assignment("Game", "Build a game with two players", new DateTime(2021, 09, 12), 60, 90); a6.Id = 6;
            Assignment a7 = new Assignment("WebDesign", "Build a website using HTML-CSS-Bootstrap", new DateTime(2021, 09, 25), 70, 90); a7.Id = 7;



            AssignmentCourse(c1, a1);
            AssignmentCourse(c1, a2);
            AssignmentCourse(c1, a3);
            AssignmentCourse(c1, a4);
            AssignmentCourse(c1, a5);
            AssignmentCourse(c1, a6);
            AssignmentCourse(c1, a7);


            // C# PROJECTS PART-TIME

            Assignment a8 = new Assignment("Uiversity Grade Claculator", "A calculator of grades", new DateTime(2021, 06, 30), 70, 90); a8.Id = 8;
            Assignment a9 = new Assignment("Fast Food Management", "Build a fast food shop", new DateTime(2021, 07, 28), 80, 95); a9.Id = 9;
            Assignment a10 = new Assignment("Employee Wage Calcualtor", "Build an employee's salary calculator", new DateTime(2021, 08, 22), 80, 100); a10.Id = 10;
            Assignment a11 = new Assignment("Paint App", "An app for painting", new DateTime(2021, 09, 15), 80, 95); a11.Id = 11;
            Assignment a12 = new Assignment("Flappy Bird", "Flappy Bird game", new DateTime(2021, 10, 10), 80, 100); a12.Id = 12;
            Assignment a13 = new Assignment("Hospital Management", "A hospital appointment arrange system", new DateTime(2021, 10, 30), 60, 90); a13.Id = 13;
            Assignment a14 = new Assignment("Text Editor", "A text editor for windows", new DateTime(2021, 12, 15), 70, 90); a14.Id = 14;


            AssignmentCourse(c2, a8);
            AssignmentCourse(c2, a9);
            AssignmentCourse(c2, a10);
            AssignmentCourse(c2, a11);
            AssignmentCourse(c2, a12);
            AssignmentCourse(c2, a13);
            AssignmentCourse(c2, a14);

            // JAVA PROJECTS FULL-TIME

            Assignment a15 = new Assignment("Car Accessories System", "Buy a car accessorie", new DateTime(2021, 06, 30), 70, 90); a15.Id = 15;
            Assignment a16 = new Assignment("Coffe Shop", "Coffe shop management system", new DateTime(2021, 07, 17), 80, 95); a16.Id = 16;
            Assignment a17 = new Assignment("Payroll Manager", "Paying your taxes", new DateTime(2021, 08, 02), 80, 100); a17.Id = 17;
            Assignment a18 = new Assignment("Supplier Management", "Supply system", new DateTime(2021, 08, 21), 80, 95); a18.Id = 18;
            Assignment a19 = new Assignment("Pacaman Shooter", "Pacman game", new DateTime(2021, 09, 10), 80, 100); a19.Id = 19;
            Assignment a20 = new Assignment("School System", "School management system", new DateTime(2021, 09, 20), 60, 90); a20.Id = 20;
            Assignment a21 = new Assignment("Contanct Book", "Build a contact book", new DateTime(2021, 09, 27), 70, 90); a21.Id = 21;

            AssignmentCourse(c3, a15);
            AssignmentCourse(c3, a16);
            AssignmentCourse(c3, a17);
            AssignmentCourse(c3, a18);
            AssignmentCourse(c3, a19);
            AssignmentCourse(c3, a20);
            AssignmentCourse(c3, a21);

            // JAVA PROJECTS PART-TIME

            Assignment a22 = new Assignment("Ludo Game", "Built a ludo game", new DateTime(2021, 06, 30), 70, 90); a22.Id = 22;
            Assignment a23 = new Assignment("Puzzle Game", "Make a puzzle", new DateTime(2021, 07, 18), 80, 95); a23.Id = 23;
            Assignment a24 = new Assignment("Pharmacy Shop", "Build a pharmacy shop", new DateTime(2021, 08, 03), 80, 100); a24.Id = 24;
            Assignment a25 = new Assignment("Quiz Game", "Build a quiz game", new DateTime(2021, 08, 24), 80, 95); a25.Id = 25;
            Assignment a26 = new Assignment("Super Market", "Build a super market", new DateTime(2021, 09, 15), 80, 100); a26.Id = 26;
            Assignment a27 = new Assignment("Image Processing", "Build an image processor", new DateTime(2021, 10, 27), 60, 90); a27.Id = 27;
            Assignment a28 = new Assignment("Music Player", "Build a music player", new DateTime(2021, 12, 20), 70, 90); a28.Id = 28;

            AssignmentCourse(c4, a22);
            AssignmentCourse(c4, a23);
            AssignmentCourse(c4, a24);
            AssignmentCourse(c4, a25);
            AssignmentCourse(c4, a26);
            AssignmentCourse(c4, a27);
            AssignmentCourse(c4, a28);


            // Populate Data

            Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28 };
            Courses = new List<Course>() { c1, c2, c3, c4 };
            Trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            Assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };




        }

        public static void CourseStudent(Course c, Student s)
        {
            c.Students.Add(s);
            s.Courses.Add(c);
        }

        public static void TrainerCourse(Course c, Trainer t)
        {
            c.Trainers.Add(t);
            t.Courses.Add(c);
        }

        public static void AssignmentCourse(Course c, Assignment a)
        {
            c.Assignments.Add(a);
            a.Courses.Add(c);
        }

        
    }


}








