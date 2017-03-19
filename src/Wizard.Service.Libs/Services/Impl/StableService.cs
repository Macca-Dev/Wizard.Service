using System.Threading.Tasks;
using Wizard.Service.Libs.Mappers;
using Wizard.Service.Libs.Models;
using Wizard.Service.Persistence;


namespace Wizard.Service.Libs.Services.Impl
{
	public class StableService : IStableService
	{
		private IStableMapper _mapper;
		private IStableRepository _repository;

		public StableService(IStableMapper mapper, IStableRepository repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<StableMetadata> Save(StableMetadata request)
		{
			var data = _mapper.ToPersistenceObject(request);
			await _repository.Save(data);

			return request;
		}
	}
}
