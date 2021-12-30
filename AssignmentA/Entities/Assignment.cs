using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; }

        public int OralMark { get; set; }

        public int TotalMark { get; set; }

        //Navigation Properties

        public List<Course> Courses = new List<Course>();

        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
           
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public void Print()
        {
            Console.WriteLine($"{Id,-10}{Title,-50}{Description,-50}{SubDateTime.ToShortDateString(),-25}{OralMark,-25}{TotalMark,-25}");
        }

        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-30}{Description,-30}");
        }
    }

   
}



 


  

