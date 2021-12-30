using System.Collections.Generic;

namespace AssignmentA
{
    public class AssignmentService
    {
        private MyDatabase db = new MyDatabase();

        public List<Assignment> GetAssignment()
        {
            return db.Assignments;
        }

        public void CreateAssignment(Assignment assignment)
        {
            int lastId = db.Assignments[db.Assignments.Count - 1].Id;
            assignment.Id = lastId + 1;
            db.Assignments.Add(assignment);
        }
    }











}



 


  

