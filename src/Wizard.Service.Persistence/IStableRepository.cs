using System.Threading.Tasks;
using Wizard.Service.Persistence.Models;

namespace Wizard.Service.Persistence
{
	public interface IStableRepository
	{
		Task Save(StableMetadata data);
	}
}
