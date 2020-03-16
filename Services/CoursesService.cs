using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using University.Interfaces;
using University.Migrations;
using NLog;
using System;

namespace University.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly ApplicationDbContext context;
        private static Logger logger;
        public CoursesService(ApplicationDbContext context)
        {
            this.context = context;
            logger = LogManager.GetCurrentClassLogger();
        }
        public async Task<List<CourseEntity>> GetNewCoursesAsync()
        {
            try
            {
                IQueryable<CourseEntity> coursesAboutToBegin = context.Courses.OrderBy(order => order.DateAdded).Take(3);
                var coursesList = await coursesAboutToBegin.ToListAsync();

                return coursesList;
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
        public async Task<List<CourseEntity>> GetCourses()
        {
            try
            {
                return await context.Courses.ToListAsync();
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
    }
}
