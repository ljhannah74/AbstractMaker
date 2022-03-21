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

        public List<Assignments> Assignments { get; set; } = new List<Assignments>();

        public string Item { get; set; } = "";

        public string State { get; set; }

        public string County { get; set; }

        public string AssignmentType
        {
            get
            {
                string str = "Mortgage";
                if (this.DOTStates.Contains(this.State))
                    str = "Deed of Trust";
                if (this.SDStates.Contains(this.State))
                    str = "Security Deed";
                return str;
            }
        }

        public string BookPageCaseInstrumentLanguage
        {
            get
            {
                string str = "";
                if (!string.IsNullOrWhiteSpace(this.Book))
                    str = str + "Book " + this.Book.Trim();
                if (!string.IsNullOrWhiteSpace(this.Page))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "Page " + this.Page.Trim();
                }
                if (!string.IsNullOrWhiteSpace(this.Instrument))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "in Instrument " + this.Instrument.Trim();
                }
                if (!string.IsNullOrWhiteSpace(this.Document))
                {
                    if (str.Length > 0)
                        str += ", ";
                    str = str + "Case " + this.Document.Trim();
                }
                return str;
            }
        }

        public string MortgageReleaseLanguage
        {
            get
            {
                object[] objArray = new object[9];
                objArray[0] = (object)this.Mortgagee;
                objArray[1] = (object)this.Signed_By;
                DateTime? nullable;
                DateTime dateTime;
                string str1;
                if (!this.Executed.HasValue)
                {
                    str1 = "";
                }
                else
                {
                    nullable = this.Executed;
                    dateTime = nullable.Value;
                    str1 = dateTime.ToShortDateString();
                }
                objArray[2] = (object)str1;
                nullable = this.Filed;
                string str2;
                if (!nullable.HasValue)
                {
                    str2 = "";
                }
                else
                {
                    nullable = this.Filed;
                    dateTime = nullable.Value;
                    str2 = dateTime.ToShortDateString();
                }
                objArray[3] = (object)str2;
                objArray[4] = (object)this.BookPageCaseInstrumentLanguage;
                objArray[5] = (object)this.County;
                objArray[6] = (object)this.State;
                Decimal? mortgageAmount = this.Mortgage_Amount;
                string str3;
                if (!mortgageAmount.HasValue)
                {
                    str3 = "";
                }
                else
                {
                    mortgageAmount = this.Mortgage_Amount;
                    str3 = mortgageAmount.Value.ToString("C");
                }
                objArray[7] = (object)str3;
                objArray[8] = (object)this.AssignmentType;
                string str4 = string.Format("Payment, cancellation, satisfaction or release of the {8} from {0} to {1}, dated {2} and recorded {3}, {4}, {5} County, {6} Records, in the original principal amount of {7}.", objArray);
                foreach (Assignments assignment in this.Assignments)
                    str4 += assignment.AssignmentLanguage;
                return str4;
            }
        }
    }
}

