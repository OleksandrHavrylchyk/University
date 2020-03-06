using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using University.Migrations;
using University.Models;

namespace University.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CoursesSubscribersController : ControllerBase
    {
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly ApplicationDbContext databaseContext;
        private readonly IMapper mapper;

        public CoursesSubscribersController(UserManager<ApplicationUserEntity> userManager, ApplicationDbContext databaseContext, IMapper mapper)
        {
            this.userManager = userManager;
            this.databaseContext = databaseContext;
            this.mapper = mapper;
        }

        [HttpPost("subscribe-course")]
        [Authorize]
        public async Task<ActionResult> SubscribeOnCourse([FromQuery(Name = "courseId")]int courseId)
        {
            var userEntity = await userManager.FindByNameAsync(User.Identity.Name);

            if (databaseContext.CourseSubscribers.Where(user => user.UserId.Contains(user.UserId)).ToList().Count > 0)
            {
                return BadRequest("You are already enrolled in the course");
            }

            var coursesSubscribersEntity = mapper.Map<CourseSubscribersEntity>(new SubscribeUserModel { UserId = userEntity.Id, CourseID = courseId });
            var subscribeUser = databaseContext.CourseSubscribers.Add(coursesSubscribersEntity);
            await databaseContext.SaveChangesAsync();

            return CreatedAtAction("Successfully created", coursesSubscribersEntity);
        }
    }
}
