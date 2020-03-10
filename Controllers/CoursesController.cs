using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using University.Interfaces;


namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesService coursesService;
        
        public CoursesController(ICoursesService coursesService)
        {
            this.coursesService = coursesService;
        }

        [HttpGet("begin-courses")]
        public async Task<ActionResult> GetCoursesAboutToBegin()
        {
            var coursesAboutToBegin = await coursesService.GetCourseAboutBegin();

            if(coursesAboutToBegin == null)
            {
                return BadRequest("No courses about to begin");
            }

            return Ok(coursesAboutToBegin);
        }

        [HttpGet("courses")]
        public async Task<ActionResult> GetCourses()
        {
            var courses = await coursesService.GetCourses();

            if (courses == null)
            {
                return BadRequest("No courses");
            }

            return Ok(courses);
        }
    }
}
