using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class Property
	{
		public int PropertyID { get; set; }

		public ICollection<TitleAbstract> TitleAbstracts { get; set; }
	}
}
