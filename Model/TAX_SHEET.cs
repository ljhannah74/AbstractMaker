using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class TAX_SHEET
	{
		public bool HasPageBreak { get; set; }
		public string BorrowerOwner { get; set; }
		public List<TaxSheet> TaxSheets { get; set; } = new List<TaxSheet>();
	}
}
