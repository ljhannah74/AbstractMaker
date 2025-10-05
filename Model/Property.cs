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
		public string Address { get; set; }
		public string Address2 { get; set;  }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string County { get; set; }
		public string PropertyType { get; set; }
		public string FullAddress { get { return $"{Address} {Address2}, {City}, {State} {PostalCode}"; } }
        public ICollection<TitleAbstract> TitleAbstracts { get; set; }
	}
}
