using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodAppModule.Modules;

namespace FoodAppModule
{
	public class Context : DbContext
	{
		public DbSet<Food> Foods { get; set; }
	}
	
	}

