using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class PolicyType
	{
		public List<string> GetRateType() => new List<string>()
	{
	  "Basic",
	  "Enhanced",
	  "Re-issue",
	  "Refinance",
	  "Substitution"
	};

		public List<string> GetStates() => new List<string>()
	{
	  "",
	  "AK",
	  "AL",
	  "AR",
	  "AZ",
	  "CA",
	  "CO",
	  "CT",
	  "DC",
	  "DE",
	  "FL",
	  "GA",
	  "GU",
	  "HI",
	  "IA",
	  "ID",
	  "IL",
	  "IN",
	  "KS",
	  "KY",
	  "LA",
	  "MA",
	  "MD",
	  "ME",
	  "MI",
	  "MN",
	  "MO",
	  "MP",
	  "MS",
	  "MT",
	  "NC",
	  "ND",
	  "NE",
	  "NH",
	  "NJ",
	  "NM",
	  "NV",
	  "NY",
	  "OH",
	  "OK",
	  "OR",
	  "PA",
	  "PR",
	  "RI",
	  "SC",
	  "SD",
	  "TN",
	  "TX",
	  "UT",
	  "VA",
	  "VI",
	  "VT",
	  "WA",
	  "WI",
	  "WV",
	  "WY"
	};
	}
}
