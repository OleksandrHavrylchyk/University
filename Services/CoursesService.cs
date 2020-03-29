using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using University.Interfaces;
using University.Migrations;
using NLog;
using System;
using University.Models;

namespace University.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CoursesService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<List<CourseEntity>> GetNewCoursesAsync()
        {
            IQueryable<CourseEntity> coursesAboutToBegin = applicationDbContext.Courses.OrderBy(order => order.DateAdded).Take(3);
            var coursesList = await coursesAboutToBegin.ToListAsync();

            return coursesList;
        }

        public async Task<List<CourseEntity>> GetCoursesAsync()
        {
            return await applicationDbContext.Courses.ToListAsync();
        }

        public async Task<List<CourseEntity>> GetCourseInfoAsync(string courseUrl)
        {
            return await applicationDbContext.Courses.Where(course => course.CourseUrl == (courseUrl)).ToListAsync();
        }

        public async Task<List<AdminDashboardCoursesModel>> GetAdminDashboardCoursesAsync()
        {
            var adminDashboardCourses = await applicationDbContext.Courses.Select(course => new AdminDashboardCoursesModel()
            {
                CourseData = course,
                CourseSubscribers = applicationDbContext.CourseSubscribers.Where(courseSubscribers => courseSubscribers.CourseID == course.ID)
                .Select(courseSubscribers => new UserDtoModel()
                { 
                    Id = courseSubscribers.User.Id,
                    LastName = courseSubscribers.User.LastName,
                    Name = courseSubscribers.User.Name,
                    Email = courseSubscribers.User.Email,
                    RegisteredDate = courseSubscribers.User.RegisteredDate,
                    Age = courseSubscribers.User.Age,
                    StudyDate = applicationDbContext.CourseSubscribers.Select(coursesSubscriber => new { coursesSubscriber.StudyDate, coursesSubscriber.UserId })
                                                                  .Where(coursesSubscriber => coursesSubscriber.UserId == courseSubscribers.UserId)
                                                                  .FirstOrDefault()
                                                                  .StudyDate
                }).ToList()
            }).ToListAsync();

            return adminDashboardCourses;
        }
    }
}
