using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class TaxSheet
	{
		public int ID { get; set; }
		public string TaxID { get; set; }
		public string TaxYear { get; set; }
		public string PaymentType { get; set; }
		public string Frequency { get; set; }
		public Decimal? BaseAmount { get; set; }
		public Decimal? DelinquentAmount { get; set; }
		public string Status { get; set; }
		public string Payee { get; set; }
		public string PayeePhone { get; set; }
		public string PayeeAddress1 { get; set; }
		public string PayeeAddress2 { get; set; }
		public string PayeeCity { get; set; }
		public string PayeeState { get; set; }
		public string PayeeZip { get; set; }
		public List<TaxSheetUtilities> TaxSheetUtilities { get; set; }
	}
}
