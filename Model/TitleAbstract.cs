using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
    public class TitleAbstract
    {
        public int TitleAbstractID { get; set; }
        public string OrderNo { get; set; }
        public DateTime SearchDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public Client Client { get; set; }
        public string ClientRefNo { get; set; }
        public Property Property { get; set; }
        public ProductType ProductType { get; set; }
    }
}
