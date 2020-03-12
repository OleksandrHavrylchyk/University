using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;
using University.Services;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CoursesSubscribersController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly ICourseSubscribersService courseSubscribersService;
        private readonly ApplicationDbContext databaseContext;

        public CoursesSubscribersController(UserManager<ApplicationUserEntity> userManager, ICourseSubscribersService courseSubscribersService,
                                            ApplicationDbContext databaseContext)
        {
            this.userManager = userManager;
            this.courseSubscribersService = courseSubscribersService;
            this.databaseContext = databaseContext;
        }

        [HttpPost("subscribe-course")]
        [Authorize]
        public async Task<ActionResult> SubscribeOnCourse([FromQuery(Name = "courseId")]int courseId)
        {
            var userEntity = await userManager.FindByNameAsync(User.Identity.Name);

            if (databaseContext.CourseSubscribers.Where(user => user.UserId.Contains(userEntity.Id)).ToList().Count > 0)
            {
                return BadRequest("You are already enrolled in the course");
            }

            var coursesSubscribersEntity = await courseSubscribersService.SubscribeOnCourse(userEntity, courseId);
            if(coursesSubscribersEntity == null)
            {
                return BadRequest();
            }

            return CreatedAtAction("Subscribed", coursesSubscribersEntity);
        }
    }
}
