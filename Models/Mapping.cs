using AutoMapper;
using University.Controllers;
using University.Controllers.LoginLogout;

namespace University.Models
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<RegistrationModel, ApplicationUser>();
            CreateMap<ApplicationUser, RegistrationModel>();
            CreateMap<LoginModel, ApplicationUser>();
            CreateMap<ApplicationUser, LoginModel>();
        }
    }
}
