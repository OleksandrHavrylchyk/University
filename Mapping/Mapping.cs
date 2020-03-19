using AutoMapper;


namespace University.Models
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<RegistrationModel, ApplicationUserEntity>();
            CreateMap<ApplicationUserEntity, RegistrationModel>();
            CreateMap<FacebookLoginModel, ApplicationUserEntity>().BeforeMap((from, to) =>
            {
                to.Name = from.Name;
                to.LastName = from.LastName;
                to.Email = from.Email;
            });
            CreateMap<SubscribeUserModel, CourseSubscribersEntity>();
            CreateMap<UserDtoModel, ApplicationUserEntity>().BeforeMap((from, to) =>
            {
                to.UserName = to.UserName;
                to.TwoFactorEnabled = to.TwoFactorEnabled;
                to.SecurityStamp = to.SecurityStamp;
                to.PhoneNumberConfirmed = to.PhoneNumberConfirmed;
                to.PhoneNumber = to.PhoneNumber;
                to.PasswordHash = to.PasswordHash;
                to.NormalizedUserName = to.NormalizedUserName;
                to.NormalizedEmail = from.Email.ToUpper();
                to.LockoutEnd = to.LockoutEnd;
                to.LockoutEnabled = to.LockoutEnabled;
                to.EmailConfirmed = to.EmailConfirmed;
                to.ConcurrencyStamp = to.ConcurrencyStamp;
                to.AccessFailedCount = to.AccessFailedCount;
            });
        }
    }
}
