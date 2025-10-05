using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class Mortgage
	{
        private List<string> DOTStates = new List<string>()
    {
      "AK",
      "AZ",
      "CA",
      "CO",
      "DC",
      nameof (ID),
      "MD",
      "MI",
      "MO",
      "MT",
      "NE",
      "NV",
      "NC",
      "OR",
      "TN",
      "TX",
      "UT",
      "VA",
      "WA",
      "WV"
    };
        private List<string> SDStates = new List<string>()
    {
      "GA"
    };

        public int ID { get; set; }

        public string I_Mortgage_Type { get; set; }

        public string Release_Requirement { get; set; }

        public string Mortgagee { get; set; }

        public Decimal? Mortgage_Amount { get; set; }

        public DateTime? Executed { get; set; }

        public DateTime? Filed { get; set; }

        public string Document { get; set; }

        public string Instrument { get; set; }

        public string Trustee { get; set; }

        public string Signed_By { get; set; }

        public string Book { get; set; }

        public string Page { get; set; }

        public string Jurisdiction { get; set; }

        public string Foreclosing_Party { get; set; }

        public string Foreclosing_Case_Number { get; set; }

        public DateTime? Case_Filed_Date { get; set; }

        public string Doc_Number { get; set; }

        public string Last_Action { get; set; }

        public string Plaintiff_Attorney { get; set; }

        public string Contact_Info { get; set; }

        public DateTime? Sale_Date { get; set; }

        public string New_Owner { get; set; }

        public string Misc { get; set; }

        public List<Assignments> Assignments { get; set; }

        public string Item { get; set; } = "";

        public string State { get; set; }

        public string County { get; set; }
    }
}

