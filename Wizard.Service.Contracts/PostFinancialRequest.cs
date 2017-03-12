namespace Wizard.Service.Contracts
{
	public class PostFinancialRequest
	{
		public string TaxNumber { get; set; }
		public string TaxRate { get; set; }
		public string TaxDate { get; set; }
		public string PreviousTaxRate { get; set; }
		public string NextInvoiceNumber { get; set; }
	}
}
