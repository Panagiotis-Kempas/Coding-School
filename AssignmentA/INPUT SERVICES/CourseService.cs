using System.Collections.Generic;

namespace AssignmentA
{
    public class CourseService
    {
        private MyDatabase db = new MyDatabase();

        public List<Course> GetCourse()
        {
            return db.Courses;
        }

        public void CreateCourse(Course course)
        {
            int lastId = db.Courses[db.Courses.Count - 1].Id;
            course.Id = lastId + 1;
            db.Courses.Add(course);
        }
    }











}



 


  

