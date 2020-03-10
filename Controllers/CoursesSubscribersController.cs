using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly ApplicationDbContext databaseContext;
        private readonly IMapper mapper;
        private readonly ReminderService reminderService;

        public CoursesSubscribersController(UserManager<ApplicationUserEntity> userManager, ApplicationDbContext databaseContext, IMapper mapper)
        {
            this.userManager = userManager;
            this.databaseContext = databaseContext;
            this.mapper = mapper;
            reminderService = new ReminderService();
        }

        [HttpPost("subscribe-course")]
        [Authorize]
        public async Task<ActionResult> SubscribeOnCourse([FromQuery(Name = "courseId")]int courseId)
        {
            var userEntity = await userManager.FindByNameAsync(User.Identity.Name);
            var courseEntity = await databaseContext.Courses.FindAsync(courseId);

            if (databaseContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                return BadRequest("You are already enrolled in the course");
            }

            var coursesSubscribersEntity = mapper.Map<CourseSubscribersEntity>(new SubscribeUserModel { CourseID = courseId, UserId = userEntity.Id, Course = courseEntity });
            databaseContext.CourseSubscribers.Add(coursesSubscribersEntity);
            await databaseContext.SaveChangesAsync();

            reminderService.ScheduleRemindEmails(coursesSubscribersEntity.User, coursesSubscribersEntity.Course);

            return CreatedAtAction("Successfully created", coursesSubscribersEntity);
        }
    }
}
