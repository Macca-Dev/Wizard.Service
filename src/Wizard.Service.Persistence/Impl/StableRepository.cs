using System;
using System.Threading.Tasks;
using Wizard.Service.Persistence.Models;

namespace Wizard.Service.Persistence.Impl
{
	public class StableRepository : IStableRepository
	{
		public Task Save(StableMetadata data)
		{
			throw new NotImplementedException();
		}
	}
}
