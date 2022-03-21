using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class ProductType
	{
		public int ProductTypeID { get; set; }
		public string ProductTypeName { get; set; }

		public ICollection<TitleAbstract> TitleAbstracts { get; set; }
	}
}
