using System.Collections.Generic;

namespace University.Models
{
    public class AdminDashboardCoursesModel
    {
        public CourseEntity CourseData { get; set; }
        public List<UserDtoModel> CourseSubscribers { get; set; }
    }
}
