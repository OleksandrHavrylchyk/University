using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Interfaces
{
    public interface ICourseSubscribersService
    {
        Task<CourseSubscribersEntity> SubscribeOnCourse(ApplicationUserEntity userEntity, int courseId);
    }
}
