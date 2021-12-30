using System;
using System.Collections.Generic;

namespace AssignmentA
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        //Navigation Properties

        public List<Course> Courses = new List<Course>();

        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
           
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }


        //--METHODS

        public void Print()
        {
            Console.WriteLine($"{Id,-10}{FirstName,-20}{LastName,-25}{DateOfBirth.ToShortDateString(),-25}{TuitionFees,-25}");
        }

        public void PrintName()
        {
            Console.WriteLine($"{FirstName,-25}{LastName,-25}");
        }
    }

   
}



 


  

