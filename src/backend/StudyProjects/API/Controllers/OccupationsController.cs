using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
	[ApiController]
	public class OccupationsController : ControllerBase
	{
		[HttpGet(Name = "GetOccupations")]
		public IEnumerable<OccupationModel> Get()
		{
			return OccupationModel.GetAll();
		}

		[HttpPost(Name = "PostOccupation")]
		public OccupationModel Post(OccupationModel occupation)
		{
			occupation.Save();
			return occupation;
		}
	}
}
