using System;

namespace AbstractMaker.Model
{
	public class Judgment
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string PlaintiffType { get; set; }
		public string PlaintiffName { get; set; }
		public string DefendantType { get; set; }
		public string DefendantName { get; set; }
		public Decimal? Amount { get; set; }
		public DateTime? FiledDate { get; set; }
		public string DocumentInstrumentNumber { get; set; }
		public string Book { get; set; }
		public string Page { get; set; }
		public string Misc { get; set; }
		public bool AddsReleaseScheduleB1 { get; set; }
		public DateTime? ReleasedDate { get; set; }
		public string CaseNumber { get; set; }
	}
}