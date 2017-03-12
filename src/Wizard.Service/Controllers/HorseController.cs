using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Wizard.Service.Contracts;

namespace Wizard.Service.Controllers
{
	[Route("v1")]
	public class HorseController : Controller
	{
		[HttpPost]
		[Route("horse")]
		public IActionResult Create([FromBody] PostChargeTypeRequest request)
		{
			return Ok();
		}

		[HttpGet]
		[Route("horse/{email}")]
		public IActionResult GetByEmail(string email)
		{
			return Ok();
		}
	}
}
