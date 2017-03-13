using Microsoft.AspNetCore.Mvc;
using Wizard.Service.Contracts;

namespace Wizard.Service.Web.Controllers
{
	[Route("v1")]
	public class ChargeTypeController :Controller
	{
		[HttpPost]
		[Route("chargetype")]
		public IActionResult Create([FromBody] PostChargeTypeRequest request)
		{
			return Ok();
		}

		[HttpGet]
		[Route("chargetype/{email}")]
		public IActionResult GetByEmail(string email)
		{
			return Ok();
		}
	}
}
