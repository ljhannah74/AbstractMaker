using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class BusinessAPICalls
	{
		public TitleAbstract GetAbstractInfo(string OrderNo)
		{
			return (TitleAbstract) null;
		}

		public List<TitleAbstract> GetAllAbstracts()
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			List<TitleAbstract> titleAbstracts = ctx.TitleAbstracts.ToList();
			
			return titleAbstracts;
		}
	}
}
