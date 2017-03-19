using Wizard.Service.Contracts;
using Wizard.Service.Libs.Models;

namespace Wizard.Service.Libs.Mappers.Impl
{
	public class StableMapper : IStableMapper
	{
		public Models.StableMetadata ToDomainObject(PostStableMetadataRequest request)
		{
			var stable = request.Data;

			return new Models.StableMetadata
			{
				Address = stable.Address,
				Fax = stable.Fax,
				LegalEntity = stable.LegalEntity,
				Mobile = stable.Mobile,
				Phone = stable.Phone,
				RacingCode = stable.RacingCode,
				Trainer = stable.Trainer,
				User = new User
				{
					Email = request.Email
				}
			};
		}

		public Service.Persistence.Models.StableMetadata ToPersistenceObject(Models.StableMetadata data)
		{
			return new Service.Persistence.Models.StableMetadata
			{
				Email = data.User.Email,
				Trainer = data.Trainer,
				Address = data.Address,
				Fax = data.Fax,
				LegalEntity = data.LegalEntity,
				Mobile = data.Mobile,
				Phone = data.Phone,
				RacingCode = data.RacingCode
			};
		}
	}
}
