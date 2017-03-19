using Wizard.Service.Contracts;
using Wizard.Service.Libs.Models;
using Wizard.Service.Persistence.Models;

namespace Wizard.Service.Libs.Mappers
{
	public interface IStableMapper
	{
		Models.StableMetadata ToDomainObject(PostStableMetadataRequest request);
		Service.Persistence.Models.StableMetadata ToPersistenceObject(Models.StableMetadata data);
	}
}
