using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

namespace University.Services
{
    public class UserManageService : IUserManageService
    {
        private static Logger logger;
        private readonly ApplicationDbContext applicationDbContext;
        private PagingModel pagingModel;

        public UserManageService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            logger = LogManager.GetCurrentClassLogger();
        }
        public async Task<PagingUsersModel> GetUsersAsync(PagingUsersParameters pagingUsersParametrs)
        {
            try
            {
                IQueryable<ApplicationUserEntity> usersDto = applicationDbContext.Users.OrderBy(order => order.RegisteredDate);

                if (!String.IsNullOrEmpty(pagingUsersParametrs.SearchExpression))
                {
                    usersDto = usersDto.Where(user => user.Name.Contains(pagingUsersParametrs.SearchExpression));
                };

                var totalUsers = await usersDto.CountAsync();

                var pagedUsers = usersDto.Select(user => new UserDtoModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Age = user.Age,
                    Email = user.Email,
                    RegisteredDate = user.RegisteredDate,
                    StudyDate = user.StudyDate
                }).Skip((pagingUsersParametrs.PageNumber - 1) * pagingUsersParametrs.PageSize).Take(pagingUsersParametrs.PageSize);

                pagingModel = new PagingModel(totalUsers, pagingUsersParametrs.PageNumber);

                return (new PagingUsersModel { PagesModel = pagingModel, Users = pagedUsers });
            }
            catch (Exception exception)
            {
                logger.Error(exception);
                throw;
            }
        }
    }
}
