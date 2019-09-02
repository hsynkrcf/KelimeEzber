using KelimeEzber.DAL;
using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.BLL
{
    public class ExerciseBLL
    {
        public ExerciseDAL _exerciseDAL;

        public ExerciseBLL()
        {
            _exerciseDAL = new ExerciseDAL();
        }

        public bool Add(Exercise exercise)
        {
            int affectedRows = _exerciseDAL.Add(exercise);
            return affectedRows > 0;
        }

        public bool Update(Exercise exercise)
        {
            int affectedRows = _exerciseDAL.Update(exercise);
            return affectedRows > 0;
        }

        public bool Delete(int exerciseID)
        {
            int affectedRows = _exerciseDAL.Delete(exerciseID);
            return affectedRows > 0;
        }

        public Exercise GetExerciseByID(int exerciseID)
        {
            return _exerciseDAL.GetExerciseByID(exerciseID);
        }
        public List<Exercise> GetAllExercise()
        {
            return _exerciseDAL.GetAllExercise();
        }
        public List<Exercise> GetAllExerciseByRole(int roleID)
        {
            return _exerciseDAL.GetAllExercise(roleID);
        }
    }
}
