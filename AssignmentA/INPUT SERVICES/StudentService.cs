using System.Collections.Generic;

namespace AssignmentA
{
    public class StudentService
    {
        private MyDatabase db = new MyDatabase();

        public List<Student> GetStudent()
        {
            return db.Students;
        }

        public void CreateStudent(Student student)
        {
            int lastId = db.Students[db.Students.Count - 1].Id;
            student.Id = lastId + 1;
            db.Students.Add(student);
        }
    }











}



 


  

