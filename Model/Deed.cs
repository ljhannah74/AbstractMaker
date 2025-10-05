using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class Deed
	{
        public int ID { get; set; }
        public int TitleAbstractID { get; set; }
        public string Grantee_Name { get; set; }
        public string Grantor_Name { get; set; }
        public string Ownership_Type { get; set; }
        public string Other_Ownership_Type { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Recorded { get; set; }
        public string Document_Series { get; set; }
        public Decimal? Consideration { get; set; }
        public string Book { get; set; }
        public string Page { get; set; }
        public string Misc { get; set; }
    }
}
