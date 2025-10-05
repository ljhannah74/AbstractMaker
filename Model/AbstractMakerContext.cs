using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AbstractMaker.Model
{
	public class AbstractMakerContext : DbContext
	{
		public AbstractMakerContext() : base()
		{

		}

		public DbSet<TitleAbstract> TitleAbstracts { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Deed> Deeds { get; set; }
		public DbSet<Legal_Description> Legal_Descriptions { get; set;
		
		}
    }
}
