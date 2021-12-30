using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class Trainer
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Subject { get; set; }

        //Navigation Properties

        public List<Course> Courses = new List<Course>();

        public Trainer(string firstName, string lastName, string subject)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }


        //--METHODS

        public void Print()
        {
            Console.WriteLine($"{Id,-10}{FirstName,-20}{LastName,-25}{Subject,-25}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-25}{LastName,-25}");
        }
    }
}
