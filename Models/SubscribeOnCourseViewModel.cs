using System;

namespace University.Models
{
    public class SubscribeOnCourseViewModel
    {
        public int CourseId { get; set; }
        public DateTime StudyDate { get; set; } = DateTime.UtcNow;
    }
}
