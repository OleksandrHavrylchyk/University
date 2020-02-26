using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        public string CourseName { get; set; }
        public string Description { get; set; }
        public float Duration { get; set; }
        public DateTime StartDate { get; set; }
        
        public string CoverUrl { get; set; }
    }
}
