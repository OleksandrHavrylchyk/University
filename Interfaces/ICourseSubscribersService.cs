using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Interfaces
{
    public interface ICourseSubscribersService
    {
        Task<CourseSubscribersEntity> SubscribeOnCourseAsync(ApplicationUserEntity userEntity, int courseId, DateTime studyDate);
        int GetNumberCourseSubscribers(int courseId);
    }
}
