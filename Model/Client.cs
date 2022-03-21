using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AbstractMaker.Model
{
	public class Client
	{
		[Key]
		public int ClientID { get; set; }
		public string ClientName { get; set; }
		public ICollection<TitleAbstract> TitleAbstracts { get; set; }
	}
}
