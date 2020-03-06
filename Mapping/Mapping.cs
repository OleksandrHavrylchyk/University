using AutoMapper;

namespace University.Models
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<RegistrationModel, ApplicationUserEntity>();
            CreateMap<ApplicationUserEntity, RegistrationModel>();
            CreateMap<SubscribeUserModel, CourseSubscribersEntity>();
            CreateMap<CourseSubscribersEntity, SubscribeUserModel>();
        }
    }
}
