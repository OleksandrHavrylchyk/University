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
        public CoursesService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<CourseEntity>> GetNewCoursesAsync()
        {
            IQueryable<CourseEntity> coursesAboutToBegin = context.Courses.OrderBy(order => order.DateAdded).Take(3);
            var coursesList = await coursesAboutToBegin.ToListAsync();

            return coursesList;
        }
        public async Task<List<CourseEntity>> GetCourses()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
