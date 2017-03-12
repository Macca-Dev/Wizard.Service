using System.Collections.Generic;

namespace Wizard.Service.Contracts
{
	public class PostChargeTypeRequest
	{
		public IEnumerable<StableChargeType> StableChargeTypes { get; set; }
		public IEnumerable<StandardChargeType> StandardChargeTypes { get; set; }
	}
}
