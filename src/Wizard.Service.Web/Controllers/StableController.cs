using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wizard.Service.Contracts;
using Wizard.Service.Libs.Mappers;
using Wizard.Service.Libs.Services;

namespace Wizard.Service.Web.Controllers
{
	[Route("v1")]
	public class StableController : Controller
	{
		private IStableMapper _mapper;
		private IStableService _service;

		public StableController(IStableMapper mapper, IStableService service)
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpPost]
		[Route("stable")]
		public async Task<IActionResult> Create([FromBody] PostStableMetadataRequest request)
		{
			if (RequestIsInvalid(request))
			{
				return BadRequest();
			}

			var data = _mapper.ToDomainObject(request);

			var uri = new System.Uri($"stable/{request.Email}", System.UriKind.Relative);
			var response = await _service.Save(data);

			return Created(uri, response);
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
