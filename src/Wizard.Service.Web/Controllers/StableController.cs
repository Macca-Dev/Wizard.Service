using Microsoft.AspNetCore.Mvc;
using Wizard.Service.Contracts;

namespace Wizard.Service.Web.Controllers
{
	[Route("v1")]
	public class StableController : Controller
	{
		private IStableMapper _mapper;

		public StableController(IStableMapper mapper)
		{
			_mapper = mapper;
		}
		
		[HttpPost]
		[Route("stable")]
		public IActionResult Create([FromBody] PostStableMetadataRequest request)
		{
			if(RequestIsInvalid(request))
			{
				return BadRequest();
			}



			return Ok();
		}

        private bool RequestIsInvalid(PostStableMetadataRequest request)
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
