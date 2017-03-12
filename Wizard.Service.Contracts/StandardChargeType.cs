namespace Wizard.Service.Contracts
{
	public class StandardChargeType
	{
		public long Id { get; set; }
		public string Description { get; set; }
		public string Rate { get; set; }
		public bool InStable { get; set; }
		public string Unit { get; set; }
	}
}