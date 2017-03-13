using Microsoft.AspNetCore.Mvc;
using Wizard.Service.Contracts;

namespace Wizard.Service.Web.Controllers
{
    [Route("v1")]
	public class StableController : Controller
	{
		[HttpPost]
		[Route("stable")]
		public IActionResult Create([FromBody] PostStableDataRequest request)
		{
			if(RequestIsInvalid(request))
			{
				return BadRequest();
			}

			
			return Ok();
		}

        private bool RequestIsInvalid(PostStableDataRequest request)
        {
            return request == null;
        }

        [HttpGet]
		[Route("stable/{email}")]
		public IActionResult GetByEmail(string email)
		{
			return Ok();
		}
	}
}
