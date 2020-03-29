using AutoMapper;
using NLog;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

namespace University.Services
{
    public class CourseSubscribersService : ICourseSubscribersService
    {
        private readonly ApplicationDbContext databaseContext;
        private readonly IMapper mapper;
        private readonly ReminderService reminderService;

        public CourseSubscribersService(ApplicationDbContext databaseContext, IMapper mapper)
        {
            this.databaseContext = databaseContext;
            this.mapper = mapper;
            reminderService = new ReminderService();
        }
        public async Task<CourseSubscribersEntity> SubscribeOnCourseAsync(ApplicationUserEntity userEntity, int courseId, DateTime studyDate)
        {
            var courseEntity = await databaseContext.Courses.FindAsync(courseId);

            var coursesSubscribersEntity = mapper.Map<CourseSubscribersEntity>(
                new SubscribeUserModel
                {
                    CourseID = courseId,
                    UserId = userEntity.Id,
                    Course = courseEntity,
                    StudyDate = studyDate
                });
            databaseContext.CourseSubscribers.Add(coursesSubscribersEntity);
            await databaseContext.SaveChangesAsync();

            reminderService.ScheduleRemindEmails(coursesSubscribersEntity, studyDate);

            return coursesSubscribersEntity;
        }

        public int GetNumberCourseSubscribers(int courseId)
        {
            return databaseContext.CourseSubscribers.Where(courseSubscribers => courseSubscribers.CourseID == courseId).Count();
        }
    }
}
