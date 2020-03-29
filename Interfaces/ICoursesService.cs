using System.Collections.Generic;
using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface ICoursesService
    {
        Task<List<CourseEntity>> GetNewCoursesAsync();
        Task<List<CourseEntity>> GetCoursesAsync();
        Task<List<CourseEntity>> GetCourseInfoAsync(string courseUrl);
        Task<List<AdminDashboardCoursesModel>> GetAdminDashboardCoursesAsync();
    }
}
