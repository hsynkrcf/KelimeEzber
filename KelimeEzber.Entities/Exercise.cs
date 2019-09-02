using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.Entities
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public string ExerciseType { get; set; }

        public override string ToString()
        {
            return ExerciseType;
        }
    }
}
