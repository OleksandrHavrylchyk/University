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

        [HttpGet("new-courses")]
        public async Task<ActionResult> GetNewCoursesAsync()
        {

            var coursesAboutToBegin = await coursesService.GetNewCoursesAsync();

            if (coursesAboutToBegin == null)
            {
                return BadRequest("No new courses");
            }

            return Ok(coursesAboutToBegin);
        }

        [HttpGet("courses")]
        public async Task<ActionResult> GetCoursesAsync()
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
