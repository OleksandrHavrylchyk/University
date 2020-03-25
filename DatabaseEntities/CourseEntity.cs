using System;
using System.ComponentModel.DataAnnotations;

namespace University
{
    public class CourseEntity
    {
        [Key]
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public float Duration { get; set; } 
        public DateTime DateAdded { get; set; }
        public string CoverUrl { get; set; }
        public string CourseUrl { get; set; }
    }
}
