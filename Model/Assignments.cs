using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class Assignments
	{
        public int? ID { get; set; }

        public int? Mortgage_Type_ID { get; set; }

        public string AssignmentType { get; set; }

        public string Assignee { get; set; }

        public Decimal? Amount { get; set; }

        public DateTime? Dated { get; set; }

        public DateTime? Filed { get; set; }

        public string Document { get; set; }

        public string Book { get; set; }

        public string Page { get; set; }

        public string BookPageInstrumentLanguage
        {
            get
            {
                string str1 = "";
                if (!string.IsNullOrWhiteSpace(this.Book))
                    str1 = str1 + "in Book " + this.Book.Trim();
                if (!string.IsNullOrWhiteSpace(this.Page))
                {
                    if (str1.Length > 0)
                        str1 += ", ";
                    str1 = str1 + "Page " + this.Page.Trim();
                }
                if (!string.IsNullOrWhiteSpace(this.Document))
                {
                    if (str1.Length > 0)
                        str1 += " ";
                    str1 = str1 + "as Instrument " + this.Document.Trim();
                }
                Decimal? amount = this.Amount;
                string str2;
                if (amount.HasValue)
                {
                    if (str1.Length > 0)
                        str1 += ", ";
                    string str3 = str1;
                    amount = this.Amount;
                    string str4 = string.Format("New loan amount {0}.", (object)amount.Value.ToString("C"));
                    str2 = str3 + str4;
                }
                else
                    str2 = str1 + ".";
                return str2;
            }
        }

        public string DatingLanguage
        {
            get
            {
                string str1 = "";
                DateTime? nullable;
                DateTime dateTime;
                if (this.Dated.HasValue)
                {
                    string str2 = str1;
                    nullable = this.Dated;
                    dateTime = nullable.Value;
                    string str3 = string.Format("dated {0}", (object)dateTime.ToShortDateString());
                    str1 = str2 + str3;
                }
                nullable = this.Filed;
                if (nullable.HasValue)
                {
                    if (str1.Length > 0)
                        str1 += ", ";
                    string str4 = str1;
                    nullable = this.Filed;
                    dateTime = nullable.Value;
                    string str5 = string.Format("recorded {0}", (object)dateTime.ToShortDateString());
                    str1 = str4 + str5;
                }
                return str1;
            }
        }

        public string AssignmentLanguage
        {
            get
            {
                if (!(this.AssignmentType == "Modification"))
                    return string.Format(" Assignment to {0} recorded on {1} {2}", (object)this.Assignee, this.Filed.HasValue ? (object)this.Filed.Value.ToShortDateString() : (object)"", (object)this.BookPageInstrumentLanguage);
                string str = "";
                if (!string.IsNullOrWhiteSpace(this.Assignee))
                    str = "from " + this.Assignee.Trim() + ", ";
                return string.Format(" Modification {2}{0}, {1}", (object)this.DatingLanguage, (object)this.BookPageInstrumentLanguage, (object)str);
            }
        }
    }
}
