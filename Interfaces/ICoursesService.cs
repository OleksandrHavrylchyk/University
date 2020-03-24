using System.Collections.Generic;
using System.Threading.Tasks;


namespace University.Interfaces
{
    public interface ICoursesService
    {
        Task<List<CourseEntity>> GetNewCoursesAsync();

        Task<List<CourseEntity>> GetCourses();
    }
}
