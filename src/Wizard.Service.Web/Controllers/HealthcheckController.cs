using Microsoft.AspNetCore.Mvc;

namespace Wizard.Service.Web.Controllers
{
	public class HealthcheckController : Controller
	{
		[Route("healthcheck")]
		[HttpGet]
		public ActionResult Healthcheck()
		{
			return Ok();
		}

		[Route("ping")]
		[HttpGet]
		public ActionResult Ping()
		{
			return Ok("pong");
		}
	}
}