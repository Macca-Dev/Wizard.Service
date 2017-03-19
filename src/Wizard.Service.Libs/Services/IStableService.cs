using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wizard.Service.Libs.Models;

namespace Wizard.Service.Libs.Services
{
	public interface IStableService
	{
		Task<StableMetadata> Save(StableMetadata data);
	}
}
