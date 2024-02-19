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
			var occupations = new List<OccupationModel>();
			
			occupations.Add(
				new OccupationModel(1, "Code", DateTime.Now, DateTime.Now)
			);

			return occupations;
		}
	}
}
