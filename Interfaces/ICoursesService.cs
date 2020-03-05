using System.Collections.Generic;
using System.Threading.Tasks;


namespace University.Interfaces
{
    public interface ICoursesService
    {
        Task<List<CourseEntity>> GetCourseAboutBegin();

        Task<List<CourseEntity>> GetCourses();
    }
}
