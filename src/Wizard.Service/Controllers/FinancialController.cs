using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wizard.Service.Contracts;

namespace Wizard.Service.Controllers
{
	[Route("v1")]
	public class FinancialController : Controller
	{
		[HttpPost]
		[Route("financial")]
		public IActionResult Create([FromBody] PostFinancialRequest request)
		{
			return Ok();
		}

		[HttpGet]
		[Route("financial/{email}")]
		public IActionResult GetByEmail(string email)
		{
			return Ok();
		}
	}
}
