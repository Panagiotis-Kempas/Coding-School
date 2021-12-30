using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //Navigation Properties

       public List<Student> Students = new List<Student>();
       public List<Trainer> Trainers = new List<Trainer>();
       public List<Assignment> Assignments = new List<Assignment>();

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void Print()
        {
            Console.WriteLine($"{Id,-10}{Title,-20}{Stream,-25}{Type,-25}{StartDate.ToShortDateString(),-25}{EndDate.ToShortDateString(),-25}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-5}{Type}");
        }
    }
}
