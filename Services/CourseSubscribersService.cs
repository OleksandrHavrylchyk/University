﻿using AutoMapper;
using NLog;
using System;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

namespace University.Services
{
    public class CourseSubscribersService : ICourseSubscribersService
    {
        private static Logger logger;
        private readonly ApplicationDbContext databaseContext;
        private readonly IMapper mapper;
        private readonly ReminderService reminderService;

        public CourseSubscribersService(ApplicationDbContext databaseContext, IMapper mapper)
        {
            this.databaseContext = databaseContext;
            this.mapper = mapper;
            reminderService = new ReminderService();
            logger = LogManager.GetCurrentClassLogger();
        }
        public async Task<CourseSubscribersEntity> SubscribeOnCourse(ApplicationUserEntity userEntity, int courseId)
        {
            try
            {
                var courseEntity = await databaseContext.Courses.FindAsync(courseId);

                var coursesSubscribersEntity = mapper.Map<CourseSubscribersEntity>(new SubscribeUserModel { CourseID = courseId, UserId = userEntity.Id, Course = courseEntity });
                databaseContext.CourseSubscribers.Add(coursesSubscribersEntity);
                await databaseContext.SaveChangesAsync();

                reminderService.ScheduleRemindEmails(coursesSubscribersEntity.User, coursesSubscribersEntity.Course);

                return coursesSubscribersEntity;
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }

        }
    }
}