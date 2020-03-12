using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using University.Interfaces;
using University.Migrations;

namespace University.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly ApplicationDbContext context;
        public CoursesService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<CourseEntity>> GetCourseAboutBegin()
        {
            IQueryable<CourseEntity> coursesAboutToBegin = context.Courses.Where(date => date.StartDate >= DateTime.UtcNow.AddDays(1))
                                                                          .OrderBy(order => order.StartDate).Take(3);
            var coursesList =  await coursesAboutToBegin.ToListAsync();

            return coursesList;
        }
        public async Task<List<CourseEntity>> GetCourses()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
