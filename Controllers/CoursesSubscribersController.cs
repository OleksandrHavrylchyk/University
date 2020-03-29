using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

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
        public async Task<ActionResult> SubscribeOnCourse(SubscribeOnCourseViewModel subscribeOnCourse)
        {
            var userEntity = await userManager.FindByNameAsync(User.Identity.Name);

            if (databaseContext.CourseSubscribers.Where(user => user.UserId.Contains(userEntity.Id)).ToList().Count > 0)
            {
                return BadRequest("You are already enrolled in the course");
            }

            var coursesSubscribersEntity = await courseSubscribersService.SubscribeOnCourseAsync(
                userEntity,
                subscribeOnCourse.CourseId,
                DateTime.ParseExact(subscribeOnCourse.StudyDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));

            if (coursesSubscribersEntity == null)
            {
                return BadRequest("Failed to enroll in the course");
            }

            return CreatedAtAction("Subscribed", coursesSubscribersEntity.Course);
        }

        [HttpGet("course-subscribers/{courseId}")]
        public ActionResult GetCourseSubscribers(int courseId)
        {
            return Ok(new { numberOfSubscribers = courseSubscribersService.GetNumberCourseSubscribers(courseId) });
        }
    }
}
