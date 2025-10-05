using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class Legal_Description
	{
        public int Legal_DescriptionID { get; set; }
        public int TitleAbstractID { get; set; }
        public string Text { get; set; }
		public bool PB_Legal_Description { get; set; }
		public string TaxID { get; set; }
	}
}
