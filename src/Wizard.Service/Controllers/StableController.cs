using Microsoft.AspNetCore.Mvc;
using Wizard.Service.Contracts;

namespace Wizard.Service.Controllers
{
	[Route("v1")]
	public class StableController :Controller
	{
		[HttpPost]
		[Route("stable")]
		public IActionResult Create([FromBody] PostStableDataRequest request)
		{
			return Ok();
		}

		[HttpGet]
		[Route("stable/{email}")]
		public IActionResult GetByEmail(string email)
		{
			return Ok();
		}
	}
}
