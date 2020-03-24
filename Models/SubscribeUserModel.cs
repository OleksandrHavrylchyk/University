using System;

namespace University.Models
{
    public class SubscribeUserModel
    {
        public int CourseID { get; set; }
        public string UserId { get; set; }
        public CourseEntity Course { get; set; }

        public DateTime StudyDate { get; set; }
    }
}
