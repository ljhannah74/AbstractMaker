using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class TaxSheetUtilities
	{
		public int ID { get; set; }
		public string UtilityType { get; set; }
		public string UtilityFrequency { get; set; }
		public Decimal? UtilityAmount { get; set; }
		public string Payee { get; set; }
		public string PayeePhone { get; set; }
		public string PayeeAddress1 { get; set; }
		public string PayeeAddress2 { get; set; }
		public string PayeeCity { get; set; }
		public string PayeeState { get; set; }
		public string PayeeZip { get; set; }
	}
}
