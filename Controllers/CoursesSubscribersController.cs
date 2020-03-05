using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CoursesSubscribersController : ControllerBase
    {
        [HttpPost("subscribe-course")]
        public async Task<ActionResult> SubscribeOnCourse()
        {
            return BadRequest();
        }
    }
}
