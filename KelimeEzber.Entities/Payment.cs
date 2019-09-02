using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.Entities
{
	public class Payment
	{
		public int PaymentID { get; set; }
		public int TypeID { get; set; }
		public int UserID { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; } = 50;
	}
}
