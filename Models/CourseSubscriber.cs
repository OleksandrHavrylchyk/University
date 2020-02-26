using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Models;


namespace University.Models
{
    public class CourseSubscriber
    {
        [Key]
        public int ID { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int CourseID { get; set;}
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
    }
}
