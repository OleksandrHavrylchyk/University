using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
        private readonly ApplicationDbContext applicationDbContext;
        private readonly UserManager<ApplicationUserEntity> userManager;
        private readonly IMapper mapper;
        private PagingModel pagingModel;
        private UserSortingService sortingService;

        public UserManageService(ApplicationDbContext applicationDbContext, IMapper mapper, UserManager<ApplicationUserEntity> userManager)
        {
            this.userManager = userManager;
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
            sortingService = new UserSortingService();
        }
        public async Task<PagingUsersModel> GetUsersAsync(PagingUsersParameters pagingUsersParametrs)
        {
            IQueryable<ApplicationUserEntity> usersDto = applicationDbContext.Users.OrderBy(order => order.RegisteredDate);

            if (!String.IsNullOrWhiteSpace(pagingUsersParametrs.OrderBy))
            {
                usersDto = sortingService.Sort(usersDto, pagingUsersParametrs.OrderBy);
            }

            if (!String.IsNullOrWhiteSpace(pagingUsersParametrs.SearchExpression))
            {
                usersDto = usersDto.Where(user => user.Name.Contains(pagingUsersParametrs.SearchExpression)
                || user.LastName.Contains(pagingUsersParametrs.SearchExpression));
            };

            var totalUsers = await usersDto.CountAsync();

            var pagedUsers = usersDto.Select
                (user => new UserDtoModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Age = user.Age,
                    Email = user.Email,
                    RegisteredDate = user.RegisteredDate,
                    StudyDate = applicationDbContext.CourseSubscribers.Select(coursesSubscribers => new { coursesSubscribers.StudyDate, coursesSubscribers.UserId })
                                                                  .Where(coursesSubscribers => coursesSubscribers.UserId == user.Id)
                                                                  .FirstOrDefault()
                                                                  .StudyDate
                }).Skip((pagingUsersParametrs.PageNumber - 1) * pagingUsersParametrs.PageSize).Take(pagingUsersParametrs.PageSize);

            pagingModel = new PagingModel(totalUsers, pagingUsersParametrs.PageNumber);

            return (new PagingUsersModel { PagesModel = pagingModel, Users = pagedUsers });
        }

        public async Task<ApplicationUserEntity> EditUserAsync(UserDtoModel userForChange)
        {
            var userIdentity = await userManager.FindByIdAsync(userForChange.Id);
            var changedUserIdentity = mapper.Map(userForChange, userIdentity);

            await userManager.UpdateAsync(changedUserIdentity);
            await applicationDbContext.SaveChangesAsync();

            return changedUserIdentity;
        }
    }
}
