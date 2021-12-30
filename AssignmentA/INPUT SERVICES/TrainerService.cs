using System.Collections.Generic;

namespace AssignmentA
{
    public class TrainerService
    {
        private MyDatabase db = new MyDatabase();

        public List<Trainer> GetTrainer()
        {
            return db.Trainers;
        }

        public void CreateTrainer(Trainer trainer)
        {
            int lastId = db.Trainers[db.Trainers.Count - 1].Id;
            trainer.Id = lastId + 1;
            db.Trainers.Add(trainer);
        }
    }











}



 


  

