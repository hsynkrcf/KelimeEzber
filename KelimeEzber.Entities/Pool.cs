using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.Entities
{
    public class Pool
    {
        public int PoolID { get; set; }
        public int ExerciseID { get; set; }
        public int UserID { get; set; }
        public string PoolName { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return PoolName;
        }
    }
}
