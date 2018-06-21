using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAppModule.Modules
{
	public class Food
	{
		/// 4 id type options
		/// Id, ID, FoodId, FoodID
		/// 
		public int FoodID { get; set; }
		public string FoodName { get; set; }
		public int FoodQuantity { get; set; }
		public double FoodCost { get; set; }
		public DateTime PublishedOn { get; set; }
	}
}
