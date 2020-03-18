using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace University
{
    public class CourseSubscribersEntity
    {
        [Key]
        public int ID { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUserEntity User { get; set; }
        public int CourseID { get; set;}
        [ForeignKey("CourseID")]
        public CourseEntity Course { get; set; }
        public DateTime? StudyDate { get; set; }
    }
}
