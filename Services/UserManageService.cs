using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Interfaces;
using University.Migrations;
using University.Models;

namespace University.Services
{
    public class UserManageService : IUserManageService
    {
        private readonly ApplicationDbContext applicationDbContext;
        private PagingModel pagingModel;

        public UserManageService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<PagingUsersModel> GetUsersAsync(PagingUsersParameters pagingUsersParametrs)
        {
            var totalUsers = await applicationDbContext.Users.CountAsync();
            var pagedUsers = await applicationDbContext.Users.Select(user => new UserDtoModel() { Id = user.Id,
                                                                                                  Name = user.Name,
                                                                                                  LastName = user.LastName,
                                                                                                  Age = user.Age,
                                                                                                  Email = user.Email,
                                                                                                  RegisteredDate = user.RegisteredDate,
                                                                                                  StudyDate = user.StudyDate })
                                                             .OrderBy(order => order.RegisteredDate)
                                                             .Skip((pagingUsersParametrs.PageNumber - 1) * pagingUsersParametrs.PageSize)
                                                             .Take(pagingUsersParametrs.PageSize)
                                                             .ToListAsync();

            pagingModel = new PagingModel(totalUsers, pagingUsersParametrs.PageNumber);

            return (new PagingUsersModel { PagesModel = pagingModel, Users = pagedUsers });
        }
    }
}
