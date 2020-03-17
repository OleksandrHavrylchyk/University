using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace University.Migrations.EntityConfigurations
{
    public class CoursesConfiguration : IEntityTypeConfiguration<CourseEntity>
    {
        private static DateTime currentDate;
        public CoursesConfiguration()
        {
            currentDate = DateTime.UtcNow;
        }
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {
            int courseId = 0;
            builder.HasData(
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Geometry and Trygonometry",
                Description = "Course Descriprion",
                Duration = 5f,
                DateAdded = currentDate,
                CoverUrl = "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Art",
                Description = "Course Descriprion",
                Duration = 12f,
                DateAdded = currentDate,
                CoverUrl = "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "English",
                Description = "Course Descriprion",
                Duration = 15f,
                DateAdded = currentDate,
                CoverUrl = "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Programming",
                Description = "Course Descriprion",
                Duration = 9f,
                DateAdded = currentDate,
                CoverUrl = "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "History",
                Description = "Course Descriprion",
                Duration = 8f,
                DateAdded = currentDate,
                CoverUrl = "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Chemistry",
                Description = "Course Descriprion",
                Duration = 9f,
                DateAdded = currentDate,
                CoverUrl = "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg"
            }) ; ;
        }
    }
}
