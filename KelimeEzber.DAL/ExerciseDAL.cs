using KelimeEzber.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.DAL
{
    public class ExerciseDAL
    {
        Helper helper;

        public ExerciseDAL()
        {
            helper = new Helper();
        }

        public int Add(Exercise exercise) 
        {
            List<SqlParameter> listExercise = new List<SqlParameter>();
            string query = "INSERT INTO Exercise(ExerciseID,ExerciseType)VALUES(@exerciseID, @exerciseType)";
            listExercise.Add(new SqlParameter("exerciseID", exercise.ExerciseID));
            listExercise.Add(new SqlParameter("exerciseType", exercise.ExerciseType));
            helper.AddParameters(listExercise);
            return helper.ExecuteQuery(query);
        }
        public int Update(Exercise exercise)
        {
            List<SqlParameter> listExercise = new List<SqlParameter>();
            string query = "UPDATE Exercise SET ExerciseID = @exerciseID,ExerciseType = @exerciseType";
            listExercise.Add(new SqlParameter("exerciseID", exercise.ExerciseID));
            listExercise.Add(new SqlParameter("exerciseType", exercise.ExerciseType));
            helper.AddParameters(listExercise);
            return helper.ExecuteQuery(query);
        }
        public int Delete(int exerciseID)
        {
            string query = "DELETE FROM Exercise WHERE ExerciseID = @exerciseID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@exerciseID", exerciseID) });
            return helper.ExecuteQuery(query);
        }

        public Exercise GetExerciseByID(int exerciseID)
        {
            Exercise exercise = new Exercise();
            string query = "SELECT * FROM Exercise WHERE ExerciseID = @exerciseID";
            helper.AddParameters(new List<SqlParameter>() { new SqlParameter("@exerciseID", exerciseID) });
            SqlDataReader reader = helper.ExecuteReader(query);
            reader.Read();
            exercise.ExerciseID = exerciseID;
            exercise.ExerciseType = reader.GetString(1);
            reader.Close();
            return exercise;
        }
        public List<Exercise> GetAllExercise()
        {
            List<Exercise> listExercise = new List<Exercise>();
            Exercise exercise = null;
            string query = "SELECT * FROM Exercise";

            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                exercise = new Exercise();
                exercise.ExerciseID = reader.GetInt32(0);
                exercise.ExerciseType = reader.GetString(1);
                listExercise.Add(exercise);
            }
            reader.Close();

            return listExercise;
        }
        public List<Exercise> GetAllExercise(int roleID)
        {
            string query = string.Empty;
            List<Exercise> listExercise = new List<Exercise>();
            Exercise exercise = null;
            if (roleID == 2)
            {
                query = "SELECT * FROM Exercise WHERE ExerciseID BETWEEN 1 AND 2";
            }
            else
            {
                query = "SELECT * FROM Exercise";
            }

            SqlDataReader reader = helper.ExecuteReader(query);
            while (reader.Read())
            {
                exercise = new Exercise();
                exercise.ExerciseID = reader.GetInt32(0);
                exercise.ExerciseType = reader.GetString(1);
                listExercise.Add(exercise);
            }
            reader.Close();

            return listExercise;
        }
    }
}
