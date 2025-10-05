using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
    public class TitleAbstractDTO
    {
        public int TitleAbstractID { get; set; }
        public string OrderNo { get; set; }
        public DateTime SearchDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string ClientName { get; set; }
        public string ClientRefNo { get; set; }
        public string PropertyAddress { get; set; }
        public string ProductTypeName { get; set; }
    }
}
